using System.Collections.Generic;
using System.Security;
using System.Web.Mvc;
using CallJSON.Core;
using CallJSON.Web.Models;

namespace CallJSON.Web.Controllers
{
    public class JsonConvertController : Controller
    {
        private ConversionService _conversionService;

        public JsonConvertController()
        {
            _conversionService = new ConversionService();
        }

        [ValidateInput(false)]
        public JsonResult Post(string json, string rootName)
        {
            return Json(new JsonConversionModel(json, _conversionService.Convert(json, rootName), rootName));
        }

        public JsonResult PostRequests(string uri, string rootName)
        {
            if (string.IsNullOrEmpty(uri) || string.IsNullOrEmpty(rootName))
            {
                return Json(new JsonConversionModel(string.Empty, string.Empty, string.Empty));
            }
            var json = string.Empty;
            var code = _conversionService.ConvertUri(uri, rootName, out json);
            return Json(new JsonConversionModel(json, code, rootName));
        }
    }
}