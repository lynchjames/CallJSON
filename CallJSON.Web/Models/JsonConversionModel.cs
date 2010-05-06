using JsonPrettyPrinterPlus;

namespace CallJSON.Web.Models
{
    public class JsonConversionModel
    {
        public JsonConversionModel(string json, string code, string rootName)
        {
            Json = json.PrettyPrintJson();
            ConvertedCode = code;
            RootName = rootName;
        }

        public string ConvertedCode { get; set; }
        public string Json { get; set; }
        public string RootName { get; set; }
    }
}