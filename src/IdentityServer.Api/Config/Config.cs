using System.Collections.Generic;
using IdentityServer4.Models;
using IdentityModel;

namespace IdentityServer.Api
{
    public static class Config
    {
        public static IEnumerable<ApiResource> GetResources()
        {
            return new List<ApiResource> {
                new ApiResource("api", "Api Test")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client> {
                new Client {
                    ClientId = "api_client",
                    ClientSecrets = {
                        new Secret("api.secret".Sha256())
                    },
                    AllowedGrantTypes = {
                        OidcConstants.GrantTypes.ClientCredentials
                    },
                    AllowedScopes = { "api" }
                }
            };
        }
    }
}