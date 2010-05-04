namespace CallJSON.Core.Extensions
{
    public static class StringExtensions
    {
        public static string ToLower(this object input)
        {
            return input.ToString().ToLower();
        }
    }
}