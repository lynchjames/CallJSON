using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using CallJSON.Core.NVelocity;
using LitJson;
using System.Linq;
using CallJSON.Core.Extensions;
using NVelocity;

namespace CallJSON.Core
{
    public class JsonDataCrawler
    {
        public JsonDataCrawler(JsonData data, string rootName)
        {
            Data = data;
            RootName = rootName;
            _existingSignatures = new ClassSignatures();
        }

        protected string RootName { get; set; }
        protected JsonData Data { get; set; }
        private ClassSignatures _existingSignatures;

        public ClassSignatures Crawl()
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
                data.KeyList.Where(x => data[x].IsObject || data[x].IsArray).ForEach(x => CrawlRecursive(x, data[x]));
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

    public class ClassSignatures : List<ClassSignature>
    {
        public bool HasSignature(ClassSignature signature)
        {
            return this.Any(x => x.Equals(signature));
        }

        public override string ToString()
        {
            var code = string.Empty;
            ForEach(x => code += x.ToString());
            return code;
        }
    }

    public class ClassSignature : IEquatable<ClassSignature>
    {
        public ClassSignature()
        {
            Properties = new ClassSignatures();
        }

        public string Name { get; set; }
        public JsonType Type { get; set; }
        public string TypeString { get { return Type.ToLower(); } }
        public ClassSignatures Properties { get; set; }
        public bool IsInTree { get; set; }

        public bool Equals(ClassSignature other)
        {
            var signature = other;
            if (signature == null)
            {
                return false;
            }
            return signature.Properties.All(x => PropertyNames.Contains(x.Name))
                   || Properties.All(x => signature.PropertyNames.Contains(x.Name));
        }

        public override string ToString()
        {
            var velocityContext = new VelocityContext();
            velocityContext.Put("signature", this);
            return NVelocityHelper.MergeTemplate(velocityContext, TemplateEnum.Class);
        }

        public void Update(ClassSignature classSignature)
        {
            var newPropertyNames = classSignature.PropertyNames.Except(PropertyNames);
            Properties.AddRange(classSignature.Properties.Where(x => newPropertyNames.Contains(x.Name)));
        }

        protected IEnumerable<string> PropertyNames { get { return Properties.Select(x => x.Name); } }
    }
}