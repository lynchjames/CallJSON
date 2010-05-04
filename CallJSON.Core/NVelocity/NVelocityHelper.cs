using System.Configuration;
using System.IO;
using Commons.Collections;
using NVelocity;
using NVelocity.App;
using NVelocity.Context;
using NVelocity.Runtime;

namespace CallJSON.Core.NVelocity
{
    public static class NVelocityHelper
    {
        private static VelocityEngine _velocity;

        static NVelocityHelper()
        {
            _velocity = new VelocityEngine();
            var props = new ExtendedProperties();
            props.AddProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, ConfigurationManager.AppSettings["TemplateFolder"]);
            _velocity.Init(props);
        }

        public static Template GetTemplate(TemplateEnum template)
        {
            var location = string.Format("{0}.vm", template);
            if (_velocity.TemplateExists(location))
            {
                return _velocity.GetTemplate(location);
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