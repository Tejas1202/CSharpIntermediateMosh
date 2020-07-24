using System;
using System.Collections.Generic;

namespace CSharpIntermediateConsoleApp.Classes
{
    // Internally we're using Dictionary wrapped inside HttpCookie class as opposed to using Dictionary directly because
    // we can have other properties like Expiry as well
    class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        // Indexer
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

        // Created Indexer above which is more efficient instead of creating Getter and Setter methods(although nothing wrong in it) viz.
        //public void SetItem(string key, string value) { };
        //public string GetItem(string key) { };
    }
}
