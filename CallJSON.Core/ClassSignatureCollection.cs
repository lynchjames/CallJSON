using System.Collections.Generic;
using System.Linq;
using CallJSON.Core.NVelocity;
using NVelocity;

namespace CallJSON.Core
{
    public class ClassSignatureCollection : List<ClassSignature>
    {
        public bool HasSignature(ClassSignature signature)
        {
            return this.Any(x => x.Equals(signature));
        }

        public override string ToString()
        {
            var velocityContext = new VelocityContext();
            velocityContext.Put("signatures", this);
            var code = NVelocityHelper.MergeTemplate(velocityContext, TemplateEnum.Class);
            return code;
        }
    }
}