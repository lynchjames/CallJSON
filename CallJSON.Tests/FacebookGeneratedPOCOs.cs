using System.Collections.Generic;

namespace CallJSON.Tests
{
    public class work
    {
        public virtual employer employer { get; set; }
        public virtual position position { get; set; }
        public virtual string start_date { get; set; }
        public virtual string end_date { get; set; }
    }

    public class employer
    {
        public virtual long id { get; set; }
        public virtual string name { get; set; }
    }

    public class position
    {
        public virtual long id { get; set; }
        public virtual string name { get; set; }
    }

    public class education
    {
        public virtual school school { get; set; }
        public virtual year year { get; set; }
        public virtual List<concentration> concentration { get; set; }
        public virtual degree degree { get; set; }
    }

    public class school
    {
        public virtual long id { get; set; }
        public virtual string name { get; set; }
    }

    public class year
    {
        public virtual long id { get; set; }
        public virtual string name { get; set; }
    }

    public class concentration
    {
        public virtual long id { get; set; }
        public virtual string name { get; set; }
    }

    public class degree
    {
        public virtual long id { get; set; }
        public virtual string name { get; set; }
    }

    public class User
    {
        public virtual string id { get; set; }
        public virtual string name { get; set; }
        public virtual string first_name { get; set; }
        public virtual string last_name { get; set; }
        public virtual string link { get; set; }
        public virtual string about { get; set; }
        public virtual List<work> work { get; set; }
        public virtual List<education> education { get; set; }
        public virtual string relationship_status { get; set; }
        public virtual significant_other significant_other { get; set; }
        public virtual string website { get; set; }
        public virtual int timezone { get; set; }
        public virtual string updated_time { get; set; }
    }

    public class significant_other
    {
        public virtual string name { get; set; }
        public virtual string id { get; set; }
    }



    public class Video
    {
        public virtual string id { get; set; }
        public virtual from from { get; set; }
        public virtual string name { get; set; }
        public virtual string picture { get; set; }
        public virtual string embed_html { get; set; }
        public virtual string icon { get; set; }
        public virtual string created_time { get; set; }
        public virtual string updated_time { get; set; }
    }

    public class from
    {
        public virtual string name { get; set; }
        public virtual string category { get; set; }
        public virtual string id { get; set; }
    }
}