using System;
using System.Collections.Generic;
using System.Linq;
using CallJSON.Core.Extensions;
using CallJSON.Core.NVelocity;
using LitJson;

namespace CallJSON.Core
{
    public class ClassSignature : IEquatable<ClassSignature>
    {
        public ClassSignature()
        {
            Properties = new ClassSignatureCollection();
        }

        public string Name { get; set; }
        public JsonType Type { get; set; }
        public string TypeString { get { return Type.ToLower(); } }
        public JsonType ArrayContentsType { get; set; }
        public string ArrayContentsTypeString { get { return ArrayContentsType.ToLower(); } }
        public ClassSignatureCollection Properties { get; set; }
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

        public void Update(ClassSignature classSignature)
        {
            foreach (var property in classSignature.Properties.Where(x => PropertyNames.Contains(x.Name)))
            {
                var existingProperty = Properties.FirstOrDefault(x => x.Name == property.Name);
                if (property.Type != JsonType.Object)
                {
                    Properties[Properties.IndexOf(existingProperty)] = classSignature.Properties.FirstOrDefault(x => x.Name == property.Name);
                }
            }
            var newPropertyNames = classSignature.PropertyNames.Except(PropertyNames);
            Properties.AddRange(classSignature.Properties.Where(x => newPropertyNames.Contains(x.Name)));
        }

        protected IEnumerable<string> PropertyNames { get { return Properties.Select(x => x.Name); } }
    }
}