﻿using System.Security;
using System.Web;
using Newtonsoft.Json;
using SanWebApi.Json;

namespace SanWebApi
{
    public partial class WebApiClient
    {
        public event EventHandler<string> OnOutput;

        public static readonly string ClientID = "0a29b9ed-801e-47bf-8e38-12d9536e7b23";
        public static readonly string UserAgent = "SansarClient/1.0";
        public static readonly Dictionary<string, string> ProtoVersionPayload = new() {
            //{"proto", "fea57ee5fea57ee5fea57ee5fea57ee5" },
            //{"proto", "d017fa57d017fa57d017fa57d017fa57" }, // 2020-09-10 ?
            //{"proto", "f111f111f111f111f111f111f111f111" }, // 2020-09-18
            //{"proto", "facef001facef001facef001facef001" }, // 2020-09-30
            //{"proto", "c0d1f1edc0d1f1edc0d1f1edc0d1f1ed" }, // 2021-03-24
            {"proto", "0b5e55ed0b5e55ed0b5e55ed0b5e55ed" }, // 2021-03-25
            {"version", "0fffba5e0fffba5e0fffba5e0fffba5e" }
        };

        private readonly HttpClient client = new();

        private ServicesResponse Services { get; set; }
        private ExtractionResponse Extraction { get; set; }
        private WebApiResponse WebApi { get; set; }
        private ClientConfigResponse ClientConfig { get; set; }

        private TokenResponse Token { get; set; }
        private DateTime TokenDate { get; set; }

        public WebApiClient()
        {
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        private string BuildQueryString(Dictionary<string, string> values, string initialQueryString = "")
        {
            var queryString = HttpUtility.ParseQueryString(initialQueryString);
            foreach (var item in values)
            {
                if (item.Value != null)
                {
                    queryString[item.Key] = item.Value;
                }
            }

            return queryString.ToString();
        }


        private async Task<T> GetJsonAsync<T>(Uri serviceUri, string path = "", Dictionary<string, string> parameters = null)
        {
            UriBuilder builder = new UriBuilder(serviceUri);
            if (path.Length > 0 && builder.Path.EndsWith('/'))
            {
                builder.Path += path.Substring(1);
            }
            else
            {
                builder.Path += path;
            }

            if (parameters != null)
            {
                var query = BuildQueryString(parameters, serviceUri.Query);

                builder.Query = query.ToString();
            }

            var response = await client.GetAsync(builder.Uri);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            response.EnsureSuccessStatusCode();

            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }

        private async Task<T> PostAsync<T>(Uri serviceUri, string path = "", Dictionary<string, string> parameters = null)
        {
            UriBuilder builder = new UriBuilder(serviceUri);
            if (builder.Path.EndsWith('/'))
            {
                builder.Path += path.Substring(1);
            }
            else
            {
                builder.Path += path;
            }

            HttpContent content = new FormUrlEncodedContent(parameters);

            var response = await client.PostAsync(builder.Uri, content);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            response.EnsureSuccessStatusCode();

            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }

        private async Task<T> PostJsonAsync<T>(Uri serviceUri, string path = "", object payload = null)
        {
            UriBuilder builder = new UriBuilder(serviceUri);
            if (builder.Path.EndsWith('/'))
            {
                builder.Path += path.Substring(1);
            }
            else
            {
                builder.Path += path;
            }

            var json = JsonConvert.SerializeObject(payload);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync(builder.Uri, content);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            response.EnsureSuccessStatusCode();

            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }

        private async Task<T> PatchJsonAsync<T>(Uri serviceUri, string path = "", string jsonParameters = null)
        {
            UriBuilder builder = new UriBuilder(serviceUri);
            if (builder.Path.EndsWith('/'))
            {
                builder.Path += path.Substring(1);
            }
            else
            {
                builder.Path += path;
            }

            HttpContent content = new StringContent(jsonParameters);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await client.PatchAsync(builder.Uri, content);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            response.EnsureSuccessStatusCode();

            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }

        private async Task UpdateTokenIfNecessaryAsync()
        {
            if (Token == null)
            {
                return;
            }

            var authTokenAge = (DateTime.Now - TokenDate).TotalSeconds;
            if (authTokenAge >= Token.ExpiresIn - 30)
            {
                await RefreshTokenAsync();
            }
        }

        private void Output(string message)
        {
            OnOutput?.Invoke(this, message);
        }

        public async Task Login(SecureString username, SecureString password)
        {
            Output("Discovering services...");
            Services = await GetServicesAsync();
            Output("OK");

            Output("Discovering extraction services...");
            Extraction = await GetJsonAsync<ExtractionResponse>(Services.Domains.Extraction.V2);
            Output("OK");

            Output("Discovering WebAPI services...");
            WebApi = await GetJsonAsync<WebApiResponse>(Services.Domains.Webapi.V2);
            Output("OK");

            Output("Getting grid status...");
            var gridStatus = await GetGridStatusAsync();
            if (!gridStatus.Status)
            {
                Output($"FAIL: Grid is currently down: {gridStatus.Message}");
                throw new Exception($"Grid is currently down: {gridStatus.Message}");
            }
            Output("OK");

            Output("Getting token...");
            var token = await GetTokenAsync(username, password);
            Output("OK");

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(token.TokenType, token.AccessToken);
            Token = token;
            TokenDate = DateTime.Now;
        }
    }
}
