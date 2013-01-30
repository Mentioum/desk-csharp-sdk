namespace Desk.TestData
{
    /// <summary>
    /// This class represents the response that is received
    /// when calling the topics service.
    /// 
    /// The class can be used to assure that existing parse
    /// functionality works, to create dummy data providers
    /// etc. Make sure to keep it in sync with the API data.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://github.com/danielsaidi/desk-csharp-sdk
    /// </remarks>
    public static class GetTopicsResponseTestData
    {
        public static string Json
        {
            get
            {
                return @"
{
        'results':
        [
                {
                        'topic':
                        {
                                'id':1,
                                'name':'Sample :: General',
                                'description':'Sample Topic Description :: Information about our company',
                                'show_in_portal':true,
                                'position':1
                        }
                },
                {
                        'topic':
                        {
                                'id':2,
                                'name':'Canned Responses',
                                'description':'Internal responses to common questions',
                                'show_in_portal':false,
                                'position':2
                        }
                },
                {
                        'topic':
                        {
                                'id':3,
                                'name':'Sample :: Products',
                                'description':'Sample Topic Description :: Information about our products',
                                'show_in_portal':true,
                                'position':3
                        }
                }
        ],
        'page':1,
        'count':20,
        'total':3
}".Replace("'", "\"");
            }
        }
    }
}
