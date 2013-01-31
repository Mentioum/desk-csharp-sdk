using Desk.Request;
using RestSharp;

namespace Desk
{
    public interface IDeskApiMapper
    {
        IRestResponse GetTopics(GetTopicsParameters parametersBase);
        IRestResponse VerifyConnection();
    }
}
