using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SanWebApi.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace SanWebApi
{
    public partial class WebApi
    {
        public static readonly string ClientID = "0a29b9ed-801e-47bf-8e38-12d9536e7b23";
        public static readonly string UserAgent = "SansarClient/1.0";

        private readonly HttpClient client = new HttpClient();

        private ServicesResponse Services { get; set; }
        private ExtractionResponse Extraction { get; set; }
        private WebApiResponse WebApiResponse { get; set; }
        private ClientConfigResponse ClientConfig { get; set; }

        private TokenResponse Token { get; set; }
        private DateTime TokenDate { get; set; }

        public WebApi()
        {
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public async Task<TosResponse> RequestTos()
        {
            var tos = await GetJsonAsync<TosResponse>(Extraction.Services.Tos.V1);
            return tos;
        }

        public async Task<UserInfoResponse> RequestUserInfo()
        {
            var result = await GetJsonAsync<UserInfoResponse>(Extraction.Services.Accounts.V1, "/user-info");
            return result;
        }

        public async Task<PersonasByAccountResponse> RequestPersonaByAccount(string accountId)
        {
            var result = await GetJsonAsync<PersonasByAccountResponse>(Extraction.Services.Personas.V2, $"/persona/by-account/{accountId}");
            return result;
        }

        public async Task<PersonaPrivateResponse> GetPersonaPrivate(string personaId)
        {
            var result = await GetJsonAsync<PersonaPrivateResponse>(Services.Services.SansarPersonas.V1, $"/persona/persona/{personaId}");
            return result;
        }

        public async Task<AccountConfigurationResponse> GetAccountConfiguration(string accountId)
        {
            var result = await GetJsonAsync<AccountConfigurationResponse>(Services.Services.SansarAccount.V1, $"/account/configuration/{accountId}");
            return result;
        }

        public async Task<SubscriptionsResponse> GetSubscriptions()
        {
            var result = await GetJsonAsync<SubscriptionsResponse>(Extraction.Services.Subscriptions.V1);
            return result;
        }

        public async Task<SubscriptionsResponse> GetBusinessRules()
        {
            var result = await GetJsonAsync<SubscriptionsResponse>(Extraction.Services.Subscriptions.V1, "/sansar-business-rules");
            return result;
        }

        public async Task<LibraryResponse> GetLibrary()
        {
            var result = await GetJsonAsync<LibraryResponse>(Services.Services.Inventory.V1, "/inventory/library/");
            return result;
        }

        public async Task<ProfileResponse> GetProfile(string handle)
        {
            var result = await GetJsonAsync<ProfileResponse>(new Uri($"https://profiles-api.sansar.com/v1/profiles/{handle}"));
            return result;
        }
        
        public async Task<ProfilesResponse> GetProfiles(List<string> personaIds)
        {
            var queryString = string.Join(",", personaIds);

            var result = await GetJsonAsync<ProfilesResponse>(new Uri($"https://profiles-api.sansar.com/v1/profiles?ids={queryString}"));
            return result;
        }

        public async Task<PersonaDetails> GetPersonaDetails(string personaId)
        {
            return await GetJsonAsync<PersonaDetails>(new Uri($"https://sansar-personas.sansar.com/v1/persona/persona/{personaId}"));
        }

        public async Task<PersonaDetails> SetAvatarId(string personaId, string avatarId)
        {
            var avatarDesc = await GetPersonaDetails(personaId);

            var match = Regex.Match(avatarDesc.app_desc, @"avatarAssetId\s*=\s*""(?<avatarAssetId>ERROR|[a-zA-Z0-9]{32})""");
            if (!match.Success)
            {
                Console.WriteLine("Innvalid match. app_desc = " + avatarDesc.app_desc);
                throw new Exception();
            }

            var originalAvatarAssetId = match.Groups["avatarAssetId"].Value;
            var newAppDesc = avatarDesc.app_desc.Replace(originalAvatarAssetId, avatarId);

            var appDescUpdate = new PersonaDetails_AppDescOnly
            {
                app_desc = newAppDesc
            };

            var jsonPayload = Newtonsoft.Json.JsonConvert.SerializeObject(appDescUpdate);

            return await PatchJsonAsync<PersonaDetails>(new Uri($"https://sansar-personas.sansar.com/v1/persona/persona/{personaId}"), null, jsonPayload);
        }

        public ProfileResponse SetProfileByHandle(string personaHandle, string bio, string avatarImageAssetId)
        {
            var request = new SetProfileRequestAll(bio, avatarImageAssetId);
            var jsonPayload = Newtonsoft.Json.JsonConvert.SerializeObject(request);

            return PatchJsonAsync<ProfileResponse>(new Uri($"https://profiles-api.sansar.com/v1/profiles/{personaHandle}"), null, jsonPayload).Result;
        }

        public async Task<MarketplaceCategoriesResponse> GetMarketplaceCategoriesAsync()
        {
            return await GetJsonAsync<MarketplaceCategoriesResponse>(WebApiResponse.Services.MarketplaceApi.V3, "/categories");
        }
        public async Task<BalanceResponse> GetBalanceAsync()
        {
            return await GetJsonAsync<BalanceResponse>(WebApiResponse.Services.MarketplaceApi.V3, "/user/balance");
        }

        public async Task<AccountConnectorResponse> GetAccountConnector()
        {
            client.DefaultRequestHeaders.Add("X-Request-Id", "d7f4f6f0-ff5c-43a2-bb6b-d63f52ff7bff");
            client.DefaultRequestHeaders.Add("X-Sansar-Client-Big-Endian", "false");
            //client.DefaultRequestHeaders.Add("X-Sansar-Client-Cpu", "");
            //client.DefaultRequestHeaders.Add("X-Sansar-Client-Gpu", "");
            //client.DefaultRequestHeaders.Add("X-Sansar-Client-Gpu-Driver-Version", "");
            //client.DefaultRequestHeaders.Add("X-Sansar-Client-Gpu-Memory", "");
            client.DefaultRequestHeaders.Add("X-Sansar-Client-Hyper-Threading", "true");
            //client.DefaultRequestHeaders.Add("X-Sansar-Client-Id:", "");
            client.DefaultRequestHeaders.Add("X-Sansar-Client-Instance-Id", "23860");
            client.DefaultRequestHeaders.Add("X-Sansar-Client-Max-Sse", "80");
            client.DefaultRequestHeaders.Add("X-Sansar-Client-Memory", "32GB");
            client.DefaultRequestHeaders.Add("X-Sansar-Client-Num-Monitors", "2");
            client.DefaultRequestHeaders.Add("X-Sansar-Client-Os", "Windows 10 Pro 10.0.18362");
            client.DefaultRequestHeaders.Add("X-Sansar-Client-Pop-Cnt", "true");
            client.DefaultRequestHeaders.Add("X-Sansar-Client-Thread-Count", "16");
            client.DefaultRequestHeaders.Add("X-Sansar-Client-Type", "sansar-client");
            client.DefaultRequestHeaders.Add("X-Sansar-Client-Version", "40.12.0.1810783");
            client.DefaultRequestHeaders.Add("X-Sansar-Session", "4ff1fa4f-1fce-f4f5-8f7a-2daf2fc210ff");

            try
            {
                var result = await PostJsonAsync<AccountConnectorResponse>(Services.Services.RegionConductor.V6, "/accountconnector", new Dictionary<string, string>() {
                    //{"proto", "fea57ee5fea57ee5fea57ee5fea57ee5" },
                    //{"proto", "d017fa57d017fa57d017fa57d017fa57" }, // 2020-09-10 ?
                    //{"proto", "f111f111f111f111f111f111f111f111" }, // 2020-09-18
                   // {"proto", "facef001facef001facef001facef001" }, // 2020-09-30
                   // {"proto", "c0d1f1edc0d1f1edc0d1f1edc0d1f1ed" }, // 2021-03-24
                    {"proto", "0b5e55ed0b5e55ed0b5e55ed0b5e55ed" }, // 2021-03-25
                    {"version", "0fffba5e0fffba5e0fffba5e0fffba5e" }
                });

                return result;
            }
            finally
            {
                client.DefaultRequestHeaders.Remove("X-Request-Id");
                client.DefaultRequestHeaders.Remove("X-Sansar-Client-Big-Endian");
                client.DefaultRequestHeaders.Remove("X-Sansar-Client-Cpu");
                client.DefaultRequestHeaders.Remove("X-Sansar-Client-Gpu");
                client.DefaultRequestHeaders.Remove("X-Sansar-Client-Gpu-Driver-Version");
                client.DefaultRequestHeaders.Remove("X-Sansar-Client-Gpu-Memory");
                client.DefaultRequestHeaders.Remove("X-Sansar-Client-Hyper-Threading");
                client.DefaultRequestHeaders.Remove("X-Sansar-Client-Id");
                client.DefaultRequestHeaders.Remove("X-Sansar-Client-Instance-Id");
                client.DefaultRequestHeaders.Remove("X-Sansar-Client-Max-Sse");
                client.DefaultRequestHeaders.Remove("X-Sansar-Client-Memory");
                client.DefaultRequestHeaders.Remove("X-Sansar-Client-Num-Monitors");
                client.DefaultRequestHeaders.Remove("X-Sansar-Client-Os");
                client.DefaultRequestHeaders.Remove("X-Sansar-Client-Pop-Cnt");
                client.DefaultRequestHeaders.Remove("X-Sansar-Client-Thread-Count");
                client.DefaultRequestHeaders.Remove("X-Sansar-Client-Type");
                client.DefaultRequestHeaders.Remove("X-Sansar-Client-Version");
                client.DefaultRequestHeaders.Remove("X-Sansar-Session");
            }
        }

        public async Task<AccountConnectorSceneResult> GetAccountConnectorScene(string personaHandle, string sceneHandle)
        {
            var result = await PostJsonAsync<AccountConnectorSceneResult>(Services.Services.RegionConductor.V6, $"/scene/{personaHandle}/{sceneHandle}", new Dictionary<string, string>() {
                //{"proto", "fea57ee5fea57ee5fea57ee5fea57ee5" },
                //{"proto", "d017fa57d017fa57d017fa57d017fa57" }, // 2020-09-10 ?
                //{"proto", "f111f111f111f111f111f111f111f111" }, // 2020-09-18
                //{"proto", "facef001facef001facef001facef001" }, // 2020-09-30
                //{"proto", "c0d1f1edc0d1f1edc0d1f1edc0d1f1ed" }, // 2021-03-24
                {"proto", "0b5e55ed0b5e55ed0b5e55ed0b5e55ed" }, // 2021-03-25
                {"version", "0fffba5e0fffba5e0fffba5e0fffba5e" }
            });

            return result;
        }

        private static string BuildQueryString(Dictionary<string, string> values, string initialQueryString = "")
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

            //Output("-----------------");
            //Output(builder.Uri.ToString());
            //Output("-----------------");

            var response = await client.GetAsync(builder.Uri);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            //Output("-----------------");
            //Output(jsonResponse);
            //Output("-----------------");

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

            Output("-----------------");
            Output(builder.Uri.ToString());
            Output("-----------------");

            var response = await client.PostAsync(builder.Uri, content);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            Output("-----------------");
            Output(jsonResponse);
            Output("-----------------");

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

            Output("-----------------");
            Output(builder.Uri.ToString());
            Output("-----------------");

            var response = await client.PostAsync(builder.Uri, content);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            Output("-----------------");
            Output(jsonResponse);
            Output("-----------------");

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

            Output("-----------------");
            Output(builder.Uri.ToString());
            Output("-----------------");

            var response = await client.PatchAsync(builder.Uri, content);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            Output("-----------------");
            Output(jsonResponse);
            Output("-----------------");

            response.EnsureSuccessStatusCode();

            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }

        private async Task UpdateTokenIfNecessary()
        {
            if (Token == null)
            {
                return;
            }

            var authTokenAge = (DateTime.Now - TokenDate).TotalSeconds;
            if (authTokenAge >= Token.ExpiresIn - 30)
            {
                await RefreshToken();
            }
        }

        private void Output(string message)
        {
            Console.WriteLine(message);
        }

        public async Task Login(string username, string password)
        {
            Output("Discovering services...");
            Services = await GetJsonAsync<ServicesResponse>(new Uri("https://api.sansar.com/v2/services/"));
            Output("OK");

            Output("Discovering extraction services...");
            Extraction = await GetJsonAsync<ExtractionResponse>(Services.Domains.Extraction.V2);
            Output("OK");

            Output("Discovering WebAPI services...");
            WebApiResponse = await GetJsonAsync<WebApiResponse>(Services.Domains.Webapi.V2);
            Output("OK");
            
            Output("Getting grid status...");
            var gridStatus = await GetJsonAsync<GridStatusResponse>(new Uri("https://sansar-asset-production.s3-us-west-2.amazonaws.com/bardo/grid-status.json"));
            if(!gridStatus.Status)
            {
                Output($"FAIL: Grid is currently down: {gridStatus.Message}");
                throw new Exception($"Grid is currently down: {gridStatus.Message}");
            }
            Output("OK");

            //Output("Getting software version...");
            //var softwareVersions = await GetJsonAsync<SoftwareVersionsResponse>(Services.Services.SoftwareVersions.V1);
            //Output($"Version: {softwareVersions.Version}");


            //Output("Posting creepy tracking status..."); // we should not do this
            //var response1 = await PostJsonAsync<string>(WebApiResponse.Services.Tracking.V1, "", new ExtTrackingPayload(){
            //    eventname = "sansar_client_regNavigateToPage",
            //    clienttimestamp = DateTime.Now,
            //    clientversion = "43.5.5.1813481",
            //    display_mode = "desktop",
            //    grid = "",
            //    trackerid = "",
            //    macaddress = "12:34:56:78:9A:BC",
            //    pageid = "login"
            //});;
            //Output(response1);


            //Output("Checking profiles api V1...");
            //var nullProfile = await GetJsonAsync<ProfilesResponse>(WebApiResponse.Services.ProfilesApi.V1, "/profiles", new Dictionary<string, string>()
            //{
            //    {"ids", "00000000-0000-0000-0000-000000000000"}
            //});
            //if(nullProfile.Errors.Length != 1 || nullProfile.Errors[0].Message != "Not Found")
            //{
            //    throw new Exception($"Unexpected profile response: {nullProfile}");
            //}
            //Output("OK");

            //Output("Discovering ClientConfig...");
            //ClientConfig = await GetJsonAsync<ClientConfigResponse>(WebApiResponse.Services.Config.V1);
            //Output("OK");

            //Output("Getting experiments...");
            //var experiments = await GetJsonAsync<ExperimentsResponse>(WebApiResponse.Services.ProfilesApi.V1, "/experiments", new Dictionary<string, string>()
            //{
            //    {"clientId", "5e0c1e35-73cd-4e10-b1b1-a08cb86c6173"}
            //});
            //Output("OK");

            //Output("Getting isEU response...");
            //var isEuResponse = await GetJsonAsync<IsEUResponse>(WebApiResponse.Services.Account.V1, "/api/isEU");
            //Output($"OK - europeanUnion={isEuResponse.europeanUnion}");


            Output("Getting token...");
            var token = await PostAsync<TokenResponse>(Extraction.Services.Auth.V3, "/token", new Dictionary<string, string>() {
                {"client_id", ClientID},
                {"client_secret", ""},
                {"grant_type", "password"},
                {"username", username},
                {"password", password},
                {"scope", "email,persona_info,persona_create,user_info,sansar_login,read_marketplace,write_marketplace,read_subscription_json,read_subscription,read_events,write_events,read_payment_method,write_payment_method,read_invoice,read_wallet,write_invoice,persona_id:default"},
            });
            Output("OK");

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(token.TokenType, token.AccessToken);
            Token = token;
            TokenDate = DateTime.Now;
        }


        public async Task RefreshToken()
        {
            var token = await PostAsync<TokenResponse>(Extraction.Services.Auth.V4, "/token", new Dictionary<string, string>() {
                {"client_id", ClientID},
                {"client_secret", ""},
                {"grant_type", "refresh_token"},
                {"refresh_token", Token.RefreshToken},
                {"scope", "email,persona_info,persona_create,user_info,sansar_login,read_marketplace,write_marketplace,read_subscription_json,read_subscription,read_events,write_events,read_payment_method,write_payment_method,read_invoice,read_wallet,write_invoice,persona_id:default"},
            });

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(token.TokenType, token.AccessToken);
            Token = token;
            TokenDate = DateTime.Now;
        }

    }
}
