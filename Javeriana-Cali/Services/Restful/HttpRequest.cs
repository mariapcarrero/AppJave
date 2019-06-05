using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JaverianaCali.Services.Restful
{
    public class HttpRequest<T>
    {
        private readonly Dictionary<string, string> queryParameters;
        private readonly Dictionary<string, string> headerParameters;
        private readonly HttpClient client;

        public HttpRequest() {
            this.queryParameters = new Dictionary<String, String>();
            this.headerParameters = new Dictionary<String, String>();
            this.client = new HttpClient();
        }
        public void AddUrlParameter(String key, String value) {
            queryParameters.Add(key, value);
        }

        public void AddHeaderParameter(String key, String value) {
            headerParameters.Add(key, value);
        }

        public async Task<T> Query(String url) {
            String encodedParameters = await new FormUrlEncodedContent(queryParameters).ReadAsStringAsync();
            foreach (KeyValuePair<string, string> entry in headerParameters) {
                client.DefaultRequestHeaders.Add(entry.Key, entry.Value);
            }
            String defaultUrl = url;
            if (queryParameters.Count > 0) {
                defaultUrl += "?" + encodedParameters;
            }
            string content = await client.GetStringAsync(defaultUrl);
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
