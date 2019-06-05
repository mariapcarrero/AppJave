using System;
using System.Collections.Generic;

namespace JaverianaCali.Services.Restful
{
    public class HttpRequestPersistence
    {
        private static Dictionary<string, string> cachedRequests = new Dictionary<string, string>();

        public HttpRequestPersistence()
        {
        }

        public static Dictionary<string, string> GetCachedRequests()
        {
            return cachedRequests;
        }

        public static void CleanCache()
        {
            cachedRequests.Clear();
        }
    }
}
