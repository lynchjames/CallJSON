using LitJson;
using Newtonsoft.Json;
using NUnit.Framework;

namespace CallJSON.Tests
{
    public class LitJsonTests : TestBase
    {
        [Test]
        public void ConvertJSONToHashTable()
        {
            var hashTable = JsonMapper.ToObject(FacebookUserJSON);
            Assert.IsNotNull(hashTable);
            Assert.IsNotEmpty(hashTable);
        }
    }
}
