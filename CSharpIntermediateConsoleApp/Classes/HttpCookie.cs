using System;
using System.Collections.Generic;

namespace CSharpIntermediateConsoleApp.Classes
{
    class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get
            {
                if(_dictionary.ContainsKey(key))
                    return _dictionary[key];

                return null;
            }
            set
            {
                _dictionary[key] = value;
            }
        }
    }
}
