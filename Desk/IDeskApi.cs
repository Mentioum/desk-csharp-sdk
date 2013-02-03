using RestSharp;

namespace Desk
{
    public interface IDeskApi
    {
        IRestResponse Call(string resource, Method method);
    }
}
