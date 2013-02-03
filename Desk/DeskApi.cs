using RestSharp;
using RestSharp.Authenticators;

namespace Desk
{
    public class DeskApi : IDeskApi
    {
        public DeskApi(string apiUrlBase, string apiKey, string apiSecret, string apiToken, string apiTokenSecret)
        {
            ApiUrlBase = apiUrlBase;

            ApiKey = apiKey;
            ApiSecret = apiSecret;
            ApiToken = apiToken;
            ApiTokenSecret = apiTokenSecret;
        }


        protected string ApiKey { get; private set; }

        protected string ApiSecret { get; private set; }

        protected string ApiToken { get; private set; }

        protected string ApiTokenSecret { get; private set; }

        protected string ApiUrlBase { get; set; }


        public IRestResponse Call(string resource, Method method)
        {
            var client = GetClient();
            var request = GetRequest(method, resource);

            return client.Execute(request);
        }


        private RestClient GetClient()
        {
            var client = new RestClient();
            client.Authenticator = OAuth1Authenticator.ForProtectedResource(ApiKey, ApiSecret, ApiToken, ApiTokenSecret);
            client.BaseUrl = ApiUrlBase;

            return client;
        }

        private RestRequest GetRequest(Method method, string resource)
        {
            var request = new RestRequest();
            request.Method = method;
            request.Resource = resource;
            request.RequestFormat = DataFormat.Json;

            return request;
        }
    }
}
