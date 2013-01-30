using RestSharp;

namespace Desk
{
    public interface IDeskApi
    {
        IRestResponse Get(string resource);
    }
}
