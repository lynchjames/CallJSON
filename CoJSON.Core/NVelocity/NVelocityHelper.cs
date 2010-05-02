using System.IO;
using NVelocity;
using NVelocity.App;
using NVelocity.Context;

namespace CoJSON.Core.NVelocity
{
    public static class NVelocityHelper
    {
        private static readonly VelocityEngine velocity;

        static NVelocityHelper()
        {
            velocity = new VelocityEngine();
            velocity.AddProperty("assembly.resource.loader.assembly", new[] { "CoJSON.Core" });
            velocity.Init();
        }

        public static Template GetTemplate(TemplateEnum template)
        {
            var location = string.Format("CoJSON.Core.NVelocity.Templates.{0}.vm", template);
            if (velocity.TemplateExists(location))
            {
                return velocity.GetTemplate(location);
            }
            return null;
        }

        public static string MergeTemplate(IContext context, TemplateEnum templateName)
        {
            var writer = new StringWriter();
            var template = GetTemplate(templateName);
            template.Merge(context, writer);
            return writer.GetStringBuilder().ToString();
        }
    }
}