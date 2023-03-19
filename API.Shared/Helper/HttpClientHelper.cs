using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace API.Shared.Helper
{
    public class HttpClientHelper
    {
        private string apiUrl;
        private bool acceptHeader;
        private string bearerToken;
        private Dictionary<string, string> additionalHeaders;
        public HttpClientHelper(string apiUrl)
        {
            this.apiUrl = apiUrl;
        }
        public HttpClientHelper(string apiUrl, bool acceptHeader) : this(apiUrl)
        {
            this.acceptHeader = acceptHeader;
        }
        public HttpClientHelper(string apiUrl, bool acceptHeader, string bearerToken) : this(apiUrl, acceptHeader)
        {
            this.bearerToken = bearerToken;
        }
        public HttpClientHelper(string apiUrl, bool acceptHeader, string bearerToken, Dictionary<string, string> additionalHeaders) : this(apiUrl, acceptHeader, bearerToken)
        {
            this.additionalHeaders = additionalHeaders;
        }

        public HttpClient GetHttpClient()
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(apiUrl)
            };
            SetHeader(httpClient);
            return httpClient;
        }
        private void SetHeader(HttpClient httpClient)
        {
            if (acceptHeader) { httpClient.DefaultRequestHeaders.Add("Accept", "application/json"); }
            if (!string.IsNullOrEmpty(bearerToken)) { httpClient.DefaultRequestHeaders.Add("Authorization", bearerToken); }
            if (additionalHeaders != null)
            {
                foreach (var header in additionalHeaders)
                {
                    httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
                }
            }
        }
    }
}
