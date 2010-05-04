using System.Collections.Generic;

namespace CallJSON.Tests
{
    public class items
{
    public string id { get; set; }
    public string uploaded { get; set; }
    public string updated { get; set; }
    public string uploader { get; set; }
    public string category { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public List<string> tags { get; set; }
    public thumbnail thumbnail { get; set; }
    public player player { get; set; }
    public content content { get; set; }
    public int duration { get; set; }
    public string aspectRatio { get; set; }
    public double rating { get; set; }
    public string likeCount { get; set; }
    public int ratingCount { get; set; }
    public int viewCount { get; set; }
    public int favoriteCount { get; set; }
    public int commentCount { get; set; }
    public accessControl accessControl { get; set; }
    public string recorded { get; set; }
    public string location { get; set; }
    public status status { get; set; }
    public List<restrictions> restrictions { get; set; }
}

public class thumbnail
{
    public string sqDefault { get; set; }
    public string hqDefault { get; set; }
}

public class player
{
    public string @default { get; set; }
    public string mobile { get; set; }
}

public class content
{
    
}

public class accessControl
{
    public string syndicate { get; set; }
    public string commentVote { get; set; }
    public string rate { get; set; }
    public string comment { get; set; }
    public string embed { get; set; }
    public string videoRespond { get; set; }
}

public class status
{
    public string value { get; set; }
    public string reason { get; set; }
}

public class restrictions
{
    public string type { get; set; }
    public string relationship { get; set; }
    public string countries { get; set; }
}

public class youtube
{
    public string apiVersion { get; set; }
    public youtubedata data { get; set; }
}

public class youtubedata
{
    public string updated { get; set; }
    public int totalItems { get; set; }
    public int startIndex { get; set; }
    public int itemsPerPage { get; set; }
    public List<items> items { get; set; }
}


}