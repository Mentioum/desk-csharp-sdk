using System;
using Desk.Entities;
using Desk.Request;
using Desk.Response;
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


        public IRestResponse GetTopics(GetTopicsParameters parameters)
        {
            return Api.Get("topics.json" + parameters);
        }

        public GetTopicsResponse GetTopicsMapped(GetTopicsParameters parameters)
        {
            return new GetTopicsResponse(GetTopics(parameters));
        }

        public IRestResponse VerifyConnection()
        {
            return Api.Get("account/verify_credentials.json");
        }
    }
}
