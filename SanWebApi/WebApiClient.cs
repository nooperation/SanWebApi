using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security;
using System.Text.RegularExpressions;
using SanWebApi.Json;

namespace SanWebApi
{
    public partial class WebApiClient
    {
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

        public async Task<BusinessRulesResponse> GetBusinessRules()
        {
            var result = await GetJsonAsync<BusinessRulesResponse>(Extraction.Services.Subscriptions.V1, "/sansar-business-rules");
            return result;
        }

        public async Task<LibraryResponse> GetLibrary()
        {
            var result = await GetJsonAsync<LibraryResponse>(Services.Services.Inventory.V1, "/inventory/library/");
            return result;
        }

        public async Task<ProfileResponse> GetProfile(string handle)
        {
            var result = await GetJsonAsync<ProfileResponse>(WebApi.Services.ProfilesApi.V1, $"/profiles/{handle}");
            return result;
        }

        public async Task<ProfilesResponse> GetProfiles(List<string> personaIds)
        {
            var queryString = string.Join(",", personaIds);

            var result = await GetJsonAsync<ProfilesResponse>(WebApi.Services.ProfilesApi.V1, "/profiles", new Dictionary<string, string>()
            {
                {"ids", queryString}
            });
            return result;
        }

        public async Task<PersonaDetails> GetPersonaDetails(string personaId)
        {
            return await GetJsonAsync<PersonaDetails>(Services.Services.SansarPersonas.V1, $"/persona/persona/{personaId}");
        }

        public async Task<PersonaDetails> SetAvatarIdAsync(string personaId, string avatarId)
        {
            var avatarDesc = await GetPersonaDetails(personaId);

            var match = Regex.Match(avatarDesc.app_desc, @"avatarAssetId\s*=\s*""(?<avatarAssetId>ERROR|[a-zA-Z0-9]{32})""");
            if (!match.Success)
            {
                Console.WriteLine("Invalid match. app_desc = " + avatarDesc.app_desc);
                throw new Exception();
            }

            var originalAvatarAssetId = match.Groups["avatarAssetId"].Value;
            var newAppDesc = avatarDesc.app_desc.Replace(originalAvatarAssetId, avatarId);

            var appDescUpdate = new PersonaDetails_AppDescOnly
            {
                app_desc = newAppDesc
            };

            var jsonPayload = Newtonsoft.Json.JsonConvert.SerializeObject(appDescUpdate);
            return await PatchJsonAsync<PersonaDetails>(Services.Services.SansarPersonas.V1, $"/persona/persona/{personaId}", jsonPayload);
        }

        public async Task<ProfileResponse> SetProfileByHandleAsync(string personaHandle, string bio, string avatarImageAssetId)
        {
            var request = new SetProfileRequestAll(bio, avatarImageAssetId);
            var jsonPayload = Newtonsoft.Json.JsonConvert.SerializeObject(request);

            return await PatchJsonAsync<ProfileResponse>(WebApi.Services.ProfilesApi.V1, $"/profiles/{personaHandle}", jsonPayload);
        }

        public async Task<MarketplaceCategoriesResponse> GetMarketplaceCategoriesAsync()
        {
            return await GetJsonAsync<MarketplaceCategoriesResponse>(WebApi.Services.MarketplaceApi.V3, "/categories");
        }
        public async Task<BalanceResponse> GetBalanceAsync()
        {
            return await GetJsonAsync<BalanceResponse>(WebApi.Services.MarketplaceApi.V3, "/user/balance");
        }

        public async Task<AccountConnectorResponse> GetAccountConnectorAsync()
        {
            client.DefaultRequestHeaders.Add("X-Request-Id", new Guid().ToString());
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
            client.DefaultRequestHeaders.Add("X-Sansar-Session", new Guid().ToString());

            try
            {
                var result = await PostJsonAsync<AccountConnectorResponse>(Services.Services.RegionConductor.V6, "/accountconnector", ProtoVersionPayload);
                return result;
            }
            finally
            {
                client.DefaultRequestHeaders.Remove("X-Request-Id");
                client.DefaultRequestHeaders.Remove("X-Sansar-Client-Big-Endian");
                //client.DefaultRequestHeaders.Remove("X-Sansar-Client-Cpu");
                //client.DefaultRequestHeaders.Remove("X-Sansar-Client-Gpu");
                //client.DefaultRequestHeaders.Remove("X-Sansar-Client-Gpu-Driver-Version");
                //client.DefaultRequestHeaders.Remove("X-Sansar-Client-Gpu-Memory");
                client.DefaultRequestHeaders.Remove("X-Sansar-Client-Hyper-Threading");
                //client.DefaultRequestHeaders.Remove("X-Sansar-Client-Id");
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

        public async Task<AccountConnectorSceneResult> GetAccountConnectorSceneAsync(string personaHandle, string sceneHandle)
        {
            var result = await PostJsonAsync<AccountConnectorSceneResult>(Services.Services.RegionConductor.V6, $"/scene/{personaHandle}/{sceneHandle}", ProtoVersionPayload);
            return result;
        }

        public async Task<ExperimentsResponse> GetExperiementsAsync()
        {
            return await GetJsonAsync<ExperimentsResponse>(WebApi.Services.ProfilesApi.V1, "/experiments", new Dictionary<string, string>()
            {
                {"clientId", "5e0c1e35-73cd-4e10-b1b1-a08cb86c6173"}
            });
        }

        public async Task<ClientConfigResponse> GetClientConfigAsync()
        {
            return await GetJsonAsync<ClientConfigResponse>(WebApi.Services.Config.V1);
        }

        public async Task<IsEUResponse> GetIsEUAsync()
        {
            return await GetJsonAsync<IsEUResponse>(WebApi.Services.Account.V1, "/api/isEU");
        }

        public async Task<SoftwareVersionsResponse> GetSoftwareVersionsAsync()
        {
            return await GetJsonAsync<SoftwareVersionsResponse>(Services.Services.SoftwareVersions.V1);
        }

        public async Task<GridStatusResponse> GetGridStatusAsync()
        {
            return await GetJsonAsync<GridStatusResponse>(Services.Services.GridStatus.V1);
        }

        public async Task<ServicesResponse> GetServicesAsync()
        {
            return await GetJsonAsync<ServicesResponse>(new Uri("https://api.sansar.com/v2/services/"));
        }
        public async Task<ProfileDetailsResponse> GetProfileDetails(string personaId)
        {
            return await GetJsonAsync<ProfileDetailsResponse>(WebApi.Services.ProfilesApi.V1, $"/details/{personaId}");
        }


        public async Task<TokenResponse> GetTokenAsync(SecureString username, SecureString password)
        {
            var usernamePtr = IntPtr.Zero;
            var passwordPtr = IntPtr.Zero;

            try
            {
                // Convert the SecureString values to plain strings
                usernamePtr = Marshal.SecureStringToGlobalAllocUnicode(username);
                passwordPtr = Marshal.SecureStringToGlobalAllocUnicode(password);
                var plainUsername = Marshal.PtrToStringUni(usernamePtr);
                var plainPassword = Marshal.PtrToStringUni(passwordPtr);

                // Make the API request with the plain strings
                return await PostAsync<TokenResponse>(Extraction.Services.Auth.V3, "/token", new Dictionary<string, string>() {
                    {"client_id", ClientID},
                    {"client_secret", ""},
                    {"grant_type", "password"},
                    {"username", plainUsername},
                    {"password", plainPassword},
                    {"scope", "email,persona_info,persona_create,user_info,sansar_login,read_marketplace,write_marketplace,read_subscription_json,read_subscription,read_events,write_events,read_payment_method,write_payment_method,read_invoice,read_wallet,write_invoice,persona_id:default"},
                });
            }
            catch (Exception ex)
            {
                Output("Failed to GetTokenAsync: " + ex.Message);
                throw;
            }
            finally
            {
                // Clear the memory used to store the plain strings
                if (usernamePtr != IntPtr.Zero)
                {
                    Marshal.ZeroFreeGlobalAllocUnicode(usernamePtr);
                }
                if (passwordPtr != IntPtr.Zero)
                {
                    Marshal.ZeroFreeGlobalAllocUnicode(passwordPtr);
                }
            }
        }

        public async Task RefreshTokenAsync()
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

        public async Task<MyStoresResponse> GetMyStores()
        {
            return await GetJsonAsync<MyStoresResponse>(WebApi.Services.MarketplaceApi.V1, $"/user/stores/");
        }

        public async Task<GetUploadUrlsResponse> GetUploadUrls(GetUploadUrlsRequest request)
        {
            return await PostJsonAsync<GetUploadUrlsResponse>(new Uri("https://asset-director-v3.sansar.com/v3"), "/asset/get-upload-urls/", payload: request);
        }

        public async Task UploadProductImage(string url, byte[] data)
        {
            HttpClient httpClient = new HttpClient();
            HttpContent httpContent = new ByteArrayContent(data);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("image/png");

            var response = await httpClient.PutAsync(url, httpContent);
            response.EnsureSuccessStatusCode();
        }

        public async Task UploadAsset(string url, GetUploadUrlsResponse.Headers headers, byte[] data)
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, url)
            {
                Content = new ByteArrayContent(data)
            };
            request.Content.Headers.ContentType = new MediaTypeHeaderValue(headers.ContentType[0]);

            request.Headers.Add("Content-Encoding", headers.ContentEncoding[0]);
            request.Headers.Add("X-Amz-Acl", headers.XAmzAcl[0]);
            request.Headers.Add("X-Amz-Meta-Be-At", headers.XAmzMetaBeAt[0]);
            request.Headers.Add("X-Amz-Meta-Be-Cap", headers.XAmzMetaBeCap[0]);
            request.Headers.Add("X-Amz-Meta-Be-Vers", headers.XAmzMetaBeVers[0]);

            var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
        }

        public async Task<CreateListingResponse> CreateListing(CreateListingRequest request)
        {
            return await PostJsonAsync<CreateListingResponse>(WebApi.Services.MarketplaceApi.V1, $"/stores/{request.data.relationships.store.data.id}/products", payload: request);
        }

        public async Task<CreateListingResponse> SetListingImage(string productId, SetListingImageRequest request)
        {
            var jsonPayload = Newtonsoft.Json.JsonConvert.SerializeObject(request);
            return await PatchJsonAsync<CreateListingResponse>(WebApi.Services.MarketplaceApi.V1, $"/products/{productId}", jsonParameters: jsonPayload);
        }

        public async Task<AddProductImageResponse> AddProductImage(AddProductImageRequest request)
        {
            return await PostJsonAsync<AddProductImageResponse>(WebApi.Services.MarketplaceApi.V1, $"/images", payload: request);
        }

        public async Task<CreateProductImageUrlResponse> CreateProductImageUrl()
        {
            return await GetJsonAsync<CreateProductImageUrlResponse>(new Uri("https://store.sansar.com/proxies/web/util/v1/sign?application=marketplace&contentType=image/png&resource=listings"));
        }

        public enum AssetType
        {
            Cluster,
            Sound,
            World,
        }
        public async Task<InventoryResponse.Item> PostInventoryItem(AssetType assetType, string assetName, string thumbnailId, string licenseAssetId, string personaId, string assetId, List<string> itemCapabilities)
        {
            var asset_hint = 0;
            switch (assetType)
            {
                case AssetType.Cluster:
                case AssetType.Sound:
                    asset_hint = 1;
                    break;
                case AssetType.World:
                    asset_hint = 2;
                    break;
                default:
                    break;
            }

            var item = new AddInventoryItemRequest
            {
                compat_version = "0fffba5e0fffba5e0fffba5e0fffba5e",
                licensee_label = assetName,
                licensor_label = assetName,
                origin = 0,
                state = 1,
                licensor_pid = personaId,
                revisions = new InventoryResponse.Revision[]
            {
                    new InventoryResponse.Revision()
                    {
                        asset_hint = asset_hint,
                        asset_type = assetType.ToString(),
                        asset_id = assetId,
                        thumbnail_asset_id = thumbnailId,
                        license_asset_id = licenseAssetId,
                        capabilities = itemCapabilities.ToArray()
                    },
            }
            };

            return await PostJsonAsync<InventoryResponse.Item>(Services.Services.Inventory.V1, $"/inventory/", payload: item);
        }
    }
}
