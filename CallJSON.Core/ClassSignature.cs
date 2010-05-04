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
            var newPropertyNames = classSignature.PropertyNames.Except(PropertyNames);
            Properties.AddRange(classSignature.Properties.Where(x => newPropertyNames.Contains(x.Name)));
        }

        protected IEnumerable<string> PropertyNames { get { return Properties.Select(x => x.Name); } }
    }
}