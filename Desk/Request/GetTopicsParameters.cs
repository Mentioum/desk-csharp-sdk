namespace Desk.Request
{
    /// <summary>
    /// This class represents the request parameters that can
    /// be used when calling the topics service.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://github.com/danielsaidi/desk-csharp-sdk
    /// </remarks>
    public class GetTopicsParameters : ParametersBase
    {
        public int Count
        {
            get { return GetParameter<int>("count"); }
            set { SetParameter("count", value); }
        }

        public int Page
        {
            get { return GetParameter<int>("page"); }
            set { SetParameter("page", value); }
        }
    }
}
