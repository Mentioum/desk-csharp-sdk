using System.Collections.Generic;
using Desk.Entities;
using Newtonsoft.Json;
using RestSharp;

namespace Desk.Response
{
    /// <summary>
    /// This class represents the response that is received
    /// when calling the topics service.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://github.com/danielsaidi/desk-csharp-sdk
    /// </remarks>
    public class GetTopicsResponse
    {
        public GetTopicsResponse()
        {
        }

        public GetTopicsResponse(IRestResponse rawResponse)
        {
            ParseResult(rawResponse);
        }


        public int Count { get; set; }

        public int Page { get; set; }

        public int Total { get; set; }

        public IEnumerable<Topic> Topics { get; set; }


        private void ParseResult(IRestResponse rawResponse)
        {
            dynamic result = JsonConvert.DeserializeObject(rawResponse.Content);

            if (result == null)
                return;

            Count = result["count"];
            Page = result["page"];
            Total = result["total"];

            var topics = new List<Topic>();
            foreach (var topic in result["results"])
                topics.Add(new Topic(topic["topic"]));
            Topics = topics;
        }
    }
}
