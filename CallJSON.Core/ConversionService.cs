using System.Net;
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

        public string ConvertUri(string uri, string rootName, out string json)
        {
            using(var client = new WebClient())
            {
                json = client.DownloadString(uri);
            }
            _crawler = new JsonDataCrawler(JsonMapper.ToObject(json), rootName);
            return HttpUtility.HtmlEncode(_crawler.Crawl().ToString());
        }
    }
}
