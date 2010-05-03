using System.Diagnostics;
using CallJSON.Core;
using LitJson;
using Newtonsoft.Json;
using NUnit.Framework;

namespace CallJSON.Tests
{
    public class IntegrationTests : TestBase
    {
        [Test]
        public void Can_Convert_Facebook_JSON_To_POCOs()
        {
            var crawler = new JsonDataCrawler(JsonMapper.ToObject(FacebookVideoJSON), "Video");
            var code = crawler.Crawl();
            Debug.Write(code);
        }

        [Test]
        public void Can_Convert_Twitter_JSON_To_POCOs()
        {
            var crawler = new JsonDataCrawler(JsonMapper.ToObject(TwitterSearchJSON), "Search");
            var code = crawler.Crawl();
            Debug.Write(code);
        }

        [Test]
        public void Can_Deserialize_Facebook_User_JSON_Using_Generated_Pocos()
        {
            var facebookUser = JsonConvert.DeserializeObject<User>(FacebookUserJSON);
            Assert.IsNotNull(facebookUser);
        }

        [Test]
        public void Can_Deserialize_Facebook_Video_JSON_Using_Generated_Pocos()
        {
            var facebookUser = JsonConvert.DeserializeObject<Video>(FacebookVideoJSON);
            Assert.IsNotNull(facebookUser);
        }
    }
}