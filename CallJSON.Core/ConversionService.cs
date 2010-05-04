using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using LitJson;

namespace CallJSON.Core
{
    public class ConversionService
    {
        private JsonDataCrawler _crawler;

        public string Convert(string json, string rootName)
        {
            _crawler = new JsonDataCrawler(JsonMapper.ToObject(json), rootName);
            return HttpUtility.HtmlEncode(_crawler.Crawl().ToString());
        }

        public string Convert(Dictionary<string,string> apiRequests, out string json)
        {
            var results = new ClassSignatureCollection();
            json = string.Empty;
            foreach (var apiRequest in apiRequests)
            {
                var client = new WebClient();
                json += client.DownloadString(apiRequest.Value);
                _crawler = new JsonDataCrawler(JsonMapper.ToObject(json), apiRequest.Key);
                results.AddRange(_crawler.Crawl());
            }
            return HttpUtility.HtmlEncode(results.ToString());
        }
    }
}
