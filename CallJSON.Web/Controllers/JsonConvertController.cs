using System.Collections.Generic;
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

        public JsonResult Post(string json, string rootName)
        {
            return Json(new JsonConversionModel(json, _conversionService.Convert(json, rootName)));
        }

        public JsonResult PostRequests(Dictionary<string, string> apiRequests)
        {
            var json = string.Empty;
            var code = _conversionService.Convert(apiRequests, out json);
            return Json(new JsonConversionModel(code, json));
        }
    }
}