using Desk.Request;
using RestSharp;

namespace Desk
{
    public class DeskApiMapper : IDeskApiMapper
    {
        public DeskApiMapper(IDeskApi connection)
        {
            Api = connection;
        }


        public IDeskApi Api { get; set; }


        public IRestResponse GetTopics()
        {
            return GetTopics(new GetTopicsParameters());
        }

        public IRestResponse GetTopics(GetTopicsParameters parametersBase)
        {
            return Api.Get("topics.json" + parametersBase);
        }

        public IRestResponse VerifyConnection()
        {
            return Api.Get("account/verify_credentials.json");
        }
    }
}
