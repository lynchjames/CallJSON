using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using LitJson;
using System.Linq;
using CoJSON.Core.Extensions;

namespace CoJSON.Core
{
    public class JsonDataCrawler
    {
        public JsonDataCrawler(JsonData data)
        {
            Data = data;
        }

        protected JsonData Data { get; set; }
        private ClassSignatures _existingSignatures;

        public ClassSignatures Crawl()
        {
            CrawlRecursive(Data);
            return _existingSignatures;
        }

        private void CrawlRecursive(JsonData data)
        {
            var classSignature = GetSignature(data);
            var existingSignature = _existingSignatures.FirstOrDefault(x => x == classSignature);
            data.ValueList.ForEach(CrawlRecursive);
            if (existingSignature != null)
            {
                existingSignature.Update(classSignature);
            }
            else
            {
                _existingSignatures.Add(classSignature);
            }

        }

        private ClassSignature GetSignature(JsonData data)
        {
            return new ClassSignature();
        }
    }

    public class ClassSignatures : List<ClassSignature>
    {
        public bool HasSignature(ClassSignature signature)
        {
            return this.Any(x => x == signature);
        }

        public override string ToString()
        {
            var pocoCode = string.Concat(this.Select(x => x.ToString()));
            return pocoCode;
        }
    }

    public class ClassSignature
    {
        public string Name { get; set; }
        public SignatureType Type { get; set; }
        public ClassSignatures Properties { get; set; }
        public bool IsInTree { get; set; }

        public override bool Equals(object obj)
        {
            var signature = obj as ClassSignature;
            if (signature == null)
            {
                return false;
            }
            return signature.Properties.All(x => PropertyNames.Contains(x.Name))
                   || Properties.All(x => signature.PropertyNames.Contains(x.Name));
        }

        public void Update(ClassSignature classSignature)
        {
            var newPropertyNames = classSignature.PropertyNames.Intersect(PropertyNames);
            Properties.AddRange(classSignature.Properties.Where(x => newPropertyNames.Contains(x.Name)));
        }

        protected IEnumerable<string> PropertyNames { get { return Properties.Select(x => x.Name); } }
    }

    public enum SignatureType
    {

    }
}