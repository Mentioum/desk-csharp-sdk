using System.Collections.Generic;

namespace Desk.Request
{
    /// <summary>
    /// This class is inherited by all classes that map query
    /// parameters during communication with the desk.com API.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://github.com/danielsaidi/desk-csharp-sdk
    /// </remarks>
    public class ParametersBase
    {
        private readonly IDictionary<string, object> dictionary;


        public ParametersBase()
        {
            dictionary = new Dictionary<string, object>();
        }


        public object GetParameter(string key)
        {
            return dictionary[key];
        }

        public T GetParameter<T>(string key)
        {
            return (T)GetParameter(key);
        }

        public void SetParameter(string key, object value)
        {
            dictionary.Add(key, value);
        }

        public override string ToString()
        {
            var result = string.Empty;

            if (dictionary.Count == 0)
                return result;

            foreach (var item in dictionary)
            {
                var separator = (result == string.Empty) ? "?" : "&";

                result += separator + item.Key + "=" + item.Value;
            }

            return result;
        }
    }
}
