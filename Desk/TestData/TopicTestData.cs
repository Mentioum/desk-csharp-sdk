namespace Desk.TestData
{
    /// <summary>
    /// This class represents the data that is received for
    /// a certain topic.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://github.com/danielsaidi/desk-csharp-sdk
    /// </remarks>
    public static class TopicTestData
    {
        public static string Json
        {
            get
            {
                return @"
{
    'id':1,
    'name':'Sample :: General',
    'description':'Sample Topic Description :: Information about our company',
    'show_in_portal':true,
    'position':1
}".Replace("'", "\"");
            }
        }
    }
}
