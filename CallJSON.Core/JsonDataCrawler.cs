using LitJson;
using System.Linq;
using CallJSON.Core.Extensions;

namespace CallJSON.Core
{
    public class JsonDataCrawler
    {
        public JsonDataCrawler(JsonData data, string rootName)
        {
            Data = data;
            RootName = rootName;
            _existingSignatures = new ClassSignatureCollection();
        }

        protected string RootName { get; set; }
        protected JsonData Data { get; set; }
        private ClassSignatureCollection _existingSignatures;

        public ClassSignatureCollection Crawl()
        {
            CrawlRecursive(RootName, Data);
            return _existingSignatures;
        }

        private void CrawlRecursive(string name, JsonData data)
        {
            var classSignature = GetSignature(name, data);
            var existingSignature = _existingSignatures.FirstOrDefault(x => x.Name == classSignature.Name);
            if (data != null && data.IsObject)
            {
                var keys = data.Keys;
                if (existingSignature != null)
                {
                    existingSignature.Update(classSignature);
                }
                else
                {
                    _existingSignatures.Add(classSignature);
                }
                data.KeyList.Where(x => data[x] != null && (data[x].IsObject || data[x].IsArray)).ForEach(x => CrawlRecursive(x, data[x]));
            }
        }

        private ClassSignature GetSignature(string name, JsonData data)
        {
            var signature = new ClassSignature();
            signature.Name = name;
            signature.Type = GetJsonType(data);
            if (data == null)
            {
                return signature;
            }
            if (data.IsObject)
            {
                var keys = data.Keys;
                foreach (var key in data.KeyList)
                {
                    signature.Properties.Add(GetSignature(key, data[key]));
                }
            }
            if (data.IsArray)
            {
                data.ArrayContents.Where(x => x.IsObject || x.IsArray).ForEach(
                    x => CrawlRecursive(signature.Name, x));
            }
            return signature;
        }

        private JsonType GetJsonType(JsonData data)
        {
            return data != null ? data.GetJsonType() : JsonType.Object;
        }
    }
}