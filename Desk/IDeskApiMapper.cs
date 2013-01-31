using Desk.Request;
using Desk.Response;
using RestSharp;

namespace Desk
{
    public interface IDeskApiMapper
    {
        IRestResponse GetTopics(GetTopicsParameters parameters);
        GetTopicsResponse GetTopicsMapped(GetTopicsParameters parameters);
        IRestResponse VerifyConnection();
    }
}
