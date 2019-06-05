using System;
namespace JaverianaCali.Services.Restful
{
    public class HttpRequestBuilder<T>
    {
        private HttpRequest<T> httpRequest;

        public HttpRequestBuilder() {
            this.httpRequest = new HttpRequest<T>();
        }

        public HttpRequestBuilder<T> AddUrlParameters(String [] keys, String [] values) {
            for (int i = 0; i < keys.Length; i ++) {
                httpRequest.AddUrlParameter(keys[i], values[i]);
            }
            return this;
        }

        public HttpRequestBuilder<T> AddHeaderParameters(String[] keys, String[] values) {
            for (int i = 0; i < keys.Length; i++) {
                httpRequest.AddHeaderParameter(keys[i], values[i]);
            }
            return this;
        }

        public HttpRequest<T> Build() {
            return httpRequest;
        }
    }
}
