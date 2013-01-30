using Desk.Request;
using RestSharp;

namespace Desk
{
    public interface IDeskApiMapper
    {
        IRestResponse GetTopics();
        IRestResponse GetTopics(GetTopicsParameters parametersBase);
        IRestResponse VerifyConnection();
    }
}
