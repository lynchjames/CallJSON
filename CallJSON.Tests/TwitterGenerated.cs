using System.Collections.Generic;

namespace CallJSON.Tests
{
    public class results
    {
        public virtual string profile_image_url { get; set; }
        public virtual string created_at { get; set; }
        public virtual string from_user { get; set; }
        public virtual metadata metadata { get; set; }
        public virtual long? to_user_id { get; set; }
        public virtual string text { get; set; }
        public virtual long id { get; set; }
        public virtual int from_user_id { get; set; }
        public virtual geo geo { get; set; }
        public virtual string iso_language_code { get; set; }
        public virtual string source { get; set; }
        public virtual string to_user { get; set; }
    }

    public class geo
    {
        
    }

    public class metadata
    {
        public virtual string result_type { get; set; }
    }

    public class Search
    {
        public virtual List<results> results { get; set; }
        public virtual long max_id { get; set; }
        public virtual int since_id { get; set; }
        public virtual string refresh_url { get; set; }
        public virtual string next_page { get; set; }
        public virtual int results_per_page { get; set; }
        public virtual int page { get; set; }
        public virtual double completed_in { get; set; }
        public virtual string query { get; set; }
    }
}