using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LitJson;
using Newtonsoft.Json;
using NUnit.Framework;

namespace CallJSON.Tests
{
    [TestFixture]
    public class LitJsonTests : TestBase
    {
        #region JSON
        
        private string SampleJSON =
                        @"{""id"":""220439"", ""name"":""BretTaylor"", ""first_name"":""Bret"", ""last_name"":""Taylor"", ""link"":""http://www.facebook.com/btaylor"", ""about"":""Testing"", ""work"":[ { ""employer"":{ ""id"":20531316728, ""name"":""Facebook"" }, ""position"":{ ""id"":111595812193665, ""name"":""Director,Product"" }, ""start_date"":""2009-08"" }, { ""employer"":{ ""id"":107618122602757, ""name"":""FriendFeed"" }, ""position"":{ ""id"":115097051838153, ""name"":""Founder&CEO"" }, ""start_date"":""2007-10"", ""end_date"":""2009-08"" }, { ""employer"":{ ""id"":111122355573466, ""name"":""BenchmarkCapital"" }, ""position"":{ ""id"":108219395878755, ""name"":""EntrepreneurinResidence"" }, ""start_date"":""2007-06"", ""end_date"":""2007-09"" }, { ""employer"":{ ""id"":104958162837, ""name"":""Google"" }, ""position"":{ ""id"":110433382317858, ""name"":""GroupProductManager"" }, ""start_date"":""2003-03"", ""end_date"":""2007-06"" } ], ""education"":[ { ""school"":{ ""id"":112075895485567, ""name"":""AcalanesHigh"" }, ""year"":{ ""id"":108220712545752, ""name"":""1998"" } }, { ""school"":{ ""id"":6192688417, ""name"":""StanfordUniversity"" }, ""year"":{ ""id"":108159685885670, ""name"":""2002"" }, ""concentration"":[ { ""id"":111986405495645, ""name"":""ComputerScience"" } ] }, { ""school"":{ ""id"":6192688417, ""name"":""StanfordUniversity"" }, ""degree"":{ ""id"":113118705373612, ""name"":""MS"" }, ""year"":{ ""id"":111069712250208, ""name"":""2003"" }, ""concentration"":[ { ""id"":111986405495645, ""name"":""ComputerScience"" } ] } ], ""relationship_status"":""Married"", ""significant_other"":{ ""name"":""KarenPadhamTaylor"", ""id"":""1138911382"" }, ""website"":""http://bret.appspot.com/"", ""timezone"":-10, ""updated_time"":""2010-03-23T16:21:09+0000"" }";

        #endregion

        [Test]
        public void ConvertJSONToHashTable()
        {
            var jsonObject = JsonConvert.DeserializeObject(SampleJSON);
            Assert.IsNotNull(jsonObject);
            var hashTable = JsonMapper.ToObject(SampleJSON);
            Assert.IsNotNull(hashTable);
            Assert.IsNotEmpty(hashTable);
        }
    }
}
