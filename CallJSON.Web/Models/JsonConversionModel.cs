using JsonPrettyPrinterPlus;

namespace CallJSON.Web.Models
{
    public class JsonConversionModel
    {
        public JsonConversionModel(string json, string code)
        {
            Json = json.PrettyPrintJson();
            ConvertedCode = code;
        }

        public string ConvertedCode { get; set; }
        public string Json { get; set; }
    }
}