using CallJSON.Core;
using NUnit.Framework;

namespace CallJSON.Tests
{
    [TestFixture]
    public class TestBase
    {
        private ConversionService _conversionService;

        #region Facebook

        public string FacebookUserJSON =
            @"{
               ""id"": ""220439"",
               ""name"": ""Bret Taylor"",
               ""first_name"": ""Bret"",
               ""last_name"": ""Taylor"",
               ""link"": ""http://www.facebook.com/btaylor"",
               ""about"": ""Testing"",
               ""work"": [
                  {
                     ""employer"": {
                        ""id"": 20531316728,
                        ""name"": ""Facebook""
                     },
                     ""position"": {
                        ""id"": 111595812193665,
                        ""name"": ""Director, Product""
                     },
                     ""start_date"": ""2009-08""
                  },
                  {
                     ""employer"": {
                        ""id"": 107618122602757,
                        ""name"": ""FriendFeed""
                     },
                     ""position"": {
                        ""id"": 115097051838153,
                        ""name"": ""Founder & CEO""
                     },
                     ""start_date"": ""2007-10"",
                     ""end_date"": ""2009-08""
                  },
                  {
                     ""employer"": {
                        ""id"": 111122355573466,
                        ""name"": ""Benchmark Capital""
                     },
                     ""position"": {
                        ""id"": 108219395878755,
                        ""name"": ""Entrepreneur in Residence""
                     },
                     ""start_date"": ""2007-06"",
                     ""end_date"": ""2007-09""
                  },
                  {
                     ""employer"": {
                        ""id"": 104958162837,
                        ""name"": ""Google""
                     },
                     ""position"": {
                        ""id"": 110433382317858,
                        ""name"": ""Group Product Manager""
                     },
                     ""start_date"": ""2003-03"",
                     ""end_date"": ""2007-06""
                  }
               ],
               ""education"": [
                  {
                     ""school"": {
                        ""id"": 112075895485567,
                        ""name"": ""Acalanes High""
                     },
                     ""year"": {
                        ""id"": 108220712545752,
                        ""name"": ""1998""
                     }
                  },
                  {
                     ""school"": {
                        ""id"": 6192688417,
                        ""name"": ""Stanford University""
                     },
                     ""year"": {
                        ""id"": 108159685885670,
                        ""name"": ""2002""
                     },
                     ""concentration"": [
                        {
                           ""id"": 111986405495645,
                           ""name"": ""Computer Science""
                        }
                     ]
                  },
                  {
                     ""school"": {
                        ""id"": 6192688417,
                        ""name"": ""Stanford University""
                     },
                     ""degree"": {
                        ""id"": 113118705373612,
                        ""name"": ""MS""
                     },
                     ""year"": {
                        ""id"": 111069712250208,
                        ""name"": ""2003""
                     },
                     ""concentration"": [
                        {
                           ""id"": 111986405495645,
                           ""name"": ""Computer Science""
                        }
                     ]
                  }
               ],
               ""relationship_status"": ""Married"",
               ""significant_other"": {
                  ""name"": ""Karen Padham Taylor"",
                  ""id"": ""1138911382""
               },
               ""website"": ""http://bret.appspot.com/"",
               ""timezone"": -7,
               ""updated_time"": ""2010-03-23T16:21:09+0000""
            }";

        public string FacebookVideoJSON =
            @"{
               ""id"": ""614004947048"",
               ""from"": {
                  ""name"": ""Facebook Engineering Tech Talks"",
                  ""category"": ""Professional_services"",
                  ""id"": ""32508286546""
               },
               ""name"": ""Tornado Tech Talk (9/23/2009)"",
               ""picture"": ""http://vthumb.ak.fbcdn.net/vthumb-ak-sf2p/v10817/41/56/4702676/t4702676_614004947048_1262.jpg"",
               ""embed_html"": ""<object width=\""400\"" height=\""224\"" ><param name=\""allowfullscreen\"" value=\""true\"" /><param name=\""allowscriptaccess\"" value=\""always\"" /><param name=\""movie\"" value=\""http://www.facebook.com/v/614004947048\"" /><embed src=\""http://www.facebook.com/v/614004947048\"" type=\""application/x-shockwave-flash\"" allowscriptaccess=\""always\"" allowfullscreen=\""true\"" width=\""400\"" height=\""224\""></embed></object>"",
               ""icon"": ""http://static.ak.fbcdn.net/rsrc.php/z75M0/hash/6z01mawk.gif"",
               ""created_time"": ""2009-09-25T00:54:30+0000"",
               ""updated_time"": ""2009-09-25T00:54:30+0000""
            }";

        #endregion

        #region Twitter

        public string TwitterSearchJSON =
            @"{
                ""results"": [
                    {
                        ""profile_image_url"": ""http://a3.twimg.com/profile_images/867128891/twitterProfilePhoto_normal.jpg"",
                        ""created_at"": ""Mon, 03 May 2010 01:06:25 +0000"",
                        ""from_user"": ""chuvachenurse"",
                        ""metadata"": {
                            ""result_type"": ""recent""
                        },
                        ""to_user_id"": null,
                        ""text"": ""Damon of VD on HBO, Gossip. :) We can't find any good movie to watch on TV. Even on Velvet. Bummer. http://pos... http://plurk.com/p/4zsxqi"",
                        ""id"": 13277039355,
                        ""from_user_id"": 21182185,
                        ""geo"": null,
                        ""iso_language_code"": ""en"",
                        ""source"": ""&lt;a href=&quot;http://apiwiki.twitter.com/&quot; rel=&quot;nofollow&quot;&gt;API&lt;/a&gt;""
                    },
                    {
                        ""profile_image_url"": ""http://a3.twimg.com/profile_images/867128891/twitterProfilePhoto_normal.jpg"",
                        ""created_at"": ""Mon, 03 May 2010 01:06:24 +0000"",
                        ""from_user"": ""chuvachenurse"",
                        ""metadata"": {
                            ""result_type"": ""recent""
                        },
                        ""to_user_id"": null,
                        ""text"": ""Damon of VD on HBO, Gossip. :) We can't find any good movie to watch on TV. Even on Velvet. Bummer. http://post.ly/eZpx"",
                        ""id"": 13277038182,
                        ""from_user_id"": 21182185,
                        ""geo"": null,
                        ""iso_language_code"": ""en"",
                        ""source"": ""&lt;a href=&quot;http://posterous.com&quot; rel=&quot;nofollow&quot;&gt;Posterous&lt;/a&gt;""
                    },
                    {
                        ""profile_image_url"": ""http://a1.twimg.com/profile_images/864742946/6220_257432315569_718960569_8258182_5116401_n_normal.jpg"",
                        ""created_at"": ""Mon, 03 May 201001:06:24 +0000"",
                        ""from_user"": ""elsamts"",
                        ""metadata"": {
                            ""result_type"": ""recent""
                        },
                        ""to_user_id"": null,
                        ""text"": ""Loooove it RT @miguelmudesi: I think I'm gonna watch a movie with my parents :) &quot;Facing the Giants&quot;"",
                        ""id"": 13277038140,
                        ""from_user_id"": 15378467,
                        ""geo"": null,
                        ""iso_language_code"": ""en"",
                        ""source"": ""&lt;a href=&quot;http://ubertwitter.com&quot; rel=&quot;nofollow&quot;&gt;UberTwitter&lt;/a&gt;""
                    },
                    {
                        ""profile_image_url"": ""http://a1.twimg.com/profile_images/674535994/demand.s_normal.jpg"",
                        ""created_at"": ""Mon, 03 May 2010 01:06:11 +0000"",
                        ""from_user"": ""Demandonthebeat"",
                        ""metadata"": {
                            ""result_type"": ""recent""
                        },
                        ""to_user_id"": null,
                        ""text"": ""Ok it came on and went off 2 times then it came on and stayed theyalso gave us free movie passes so its all good :-) \nDJDEMAND ECONOMICS"",
                        ""id"": 13277027188,
                        ""from_user_id"": 43944529,
                        ""geo"": null,
                        ""iso_language_code"": ""en"",
                        ""source"": ""&lt;a href=&quot;/devices&quot; rel=&quot;nofollow&quot;&gt;txt&lt;/a&gt;""
                    },
                    {
                        ""profile_image_url"": ""http://a3.twimg.com/profile_images/361255715/me____rin_normal.JPG"",
                        ""created_at"": ""Mon, 03 May 2010 01:06:01 +0000"",
                        ""from_user"": ""ChelseiMack"",
                        ""metadata"": {
                            ""result_type"": ""recent""
                        },
                        ""to_user_id"": null,
                        ""text"": ""OMGEE ! Just felt like blurting that out , but I can't right now . It's dinner and a movie time :)"",
                        ""id"": 13277019041,
                        ""from_user_id"": 37675544,
                        ""geo"": null,
                        ""iso_language_code"": ""en"",
                        ""source"": ""&lt;a href=&quot;/devices&quot; rel=&quot;nofollow&quot;&gt;txt&lt;/a&gt;""
                    },
                    {
                        ""profile_image_url"": ""http://a1.twimg.com/profile_images/820784832/123_normal.jpg"",
                        ""created_at"": ""Mon, 03 May 2010 01:05:56 +0000"",
                        ""from_user"": ""Livaliciouss"",
                        ""metadata"": {
                            ""result_type"": ""recent""
                        },
                        ""to_user_id"": null,
                        ""text"": ""awww that was a really good movie :)"",
                        ""id"": 13277014793,
                        ""from_user_id"": 102717706,
                        ""geo"": null,
                        ""iso_language_code"": ""en"",
                        ""source"": ""&lt;a href=&quot;http://ubertwitter.com&quot; rel=&quot;nofollow&quot;&gt;UberTwitter&lt;/a&gt;""
                    },
                    {
                        ""profile_image_url"": ""http://a3.twimg.com/profile_images/740709405/New_Me_002_normal.jpg"",
                        ""created_at"": ""Mon, 03 May 2010 01:05:24 +0000"",
                        ""from_user"": ""ReallyChey"",
                        ""metadata"": {
                            ""result_type"": ""recent""
                        },
                        ""to_user_id"": null,
                        ""text"": ""Dentist app tomorrow then physical therapy on wednesday :P Then movie night with Devyn and possibly Diana :D"",
                        ""id"": 13276988329,
                        ""from_user_id"": 80817098,
                        ""geo"": null,
                        ""iso_language_code"": ""en"",
                        ""source"": ""&lt;a href=&quot;http://twitter.com/&quot;&gt;web&lt;/a&gt;""
                    },
                    {
                        ""profile_image_url"": ""http://a3.twimg.com/profile_images/290887279/I_ROCK_normal.jpg"",
                        ""created_at"": ""Mon, 03 May 2010 01:05:15 +0000"",
                        ""from_user"": ""inishababy95"",
                        ""metadata"": {
                            ""result_type"": ""recent""
                        },
                        ""to_user_id"": null,
                        ""text"": ""_ Meet The Robinsons Is On :D ! Favorite Movie :)  Buhh Uhm Text Me ; 984-1569:)"",
                        ""id"": 13276979744,
                        ""from_user_id"": 25469533,
                        ""geo"": null,
                        ""iso_language_code"": ""en"",
                        ""source"": ""&lt;a href=&quot;http://www.myspace.com/sync&quot; rel=&quot;nofollow&quot;&gt;MySpace&lt;/a&gt;""
                    },
                    {
                        ""profile_image_url"": ""http://a3.twimg.com/profile_images/739408763/uppsidedown_normal.jpg"",
                        ""created_at"": ""Mon, 03 May 2010 01:05:10 +0000"",
                        ""from_user"": ""shawnashortstuf"",
                        ""metadata"": {
                            ""result_type"": ""recent""
                        },
                        ""to_user_id"": null,
                        ""text"": ""Hey bestfran i havent seen that movie yet . :) lol"",
                        ""id"": 13276976034,
                        ""from_user_id"": 110870714,
                        ""geo"": null,
                        ""iso_language_code"": ""en"",
                        ""source"": ""&lt;a href=&quot;/devices&quot; rel=&quot;nofollow&quot;&gt;txt&lt;/a&gt;""
                    },
                    {
                        ""profile_image_url"": ""http://a3.twimg.com/profile_images/854925775/IMG_6109_normal.jpg"",
                        ""created_at"": ""Mon, 03 May 2010 01:05:10 +0000"",
                        ""from_user"": ""JasonDalBianco"",
                        ""metadata"": {
                            ""result_type"": ""recent""
                        },
                        ""to_user_id"": null,
                        ""text"": "":D RT @AFortiori Even though he was missing teeth...I wanted tomake out with him in that movie. Such a passionate character. #scriptchat"",
                        ""id"": 13276975300,
                        ""from_user_id"": 15984283,
                        ""geo"": null,
                        ""iso_language_code"": ""en"",
                        ""source"": ""&lt;a href=&quot;http://twitterrific.com&quot; rel=&quot;nofollow&quot;&gt;Twitterrific&lt;/a&gt;""
                    },
                    {
                        ""profile_image_url"": ""http://a3.twimg.com/profile_images/836968189/tictack4915_normal.jpg"",
                        ""created_at"": ""Mon, 03 May 2010 01:04:57 +0000"",
                        ""from_user"": ""tictack4915"",
                        ""metadata"": {
                            ""result_type"": ""recent""
                        },
                        ""to_user_id"": 110870632,
                        ""text"": ""@IzzyMonsterrr Yo fo shooo!! Lol! I LOOVE YOOU!! &lt;33\nwell I was watching a movie but I got hungrey so I am eating a sammich now! :) YOU?!"",
                        ""id"": 13276964264,
                        ""from_user_id"": 103166449,
                        ""to_user"": ""IzzyMonsterrr"",
                        ""geo"": null,
                        ""iso_language_code"": ""en"",
                        ""source"": ""&lt;a href=&quot;http://twitterrific.com&quot; rel=&quot;nofollow&quot;&gt;Twitterrific&lt;/a&gt;""
                    },
                    {
                        ""profile_image_url"": ""http://a1.twimg.com/profile_images/858763038/greatest_memory_normal.jpg"",
                        ""created_at"": ""Mon, 03 May 2010 01:04:52 +0000"",
                        ""from_user"": ""sweetirishrose7"",
                        ""metadata"": {
                            ""result_type"": ""recent""
                        },
                        ""to_user_id"": null,
                        ""text"": ""OMG i love this movie!!! Meet the robinsons FTW! :)"",
                        ""id"": 13276960183,
                        ""from_user_id"": 9482019,
                        ""geo"": null,
                        ""iso_language_code"": ""en"",
                        ""source"": ""&lt;a href=&quot;http://twitter.com/&quot;&gt;web&lt;/a&gt;""
                    },
                    {
                        ""profile_image_url"": ""http://a1.twimg.com/profile_images/821235932/jjonathan_edit_normal.jpg"",
                        ""created_at"": ""Mon, 03 May 2010 01:04:51 +0000"",
                        ""from_user"": ""KAITLINBRAND"",
                        ""metadata"": {
                            ""result_type"": ""recent""
                        },
                        ""to_user_id"": 6730068,
                        ""text"": ""@MattWRoberts nothin much senior watching scary movie 2 :D lol!"",
                        ""id"": 13276959380,
                        ""from_user_id"": 25398565,
                        ""to_user"": ""MattWRoberts"",
                        ""geo"": null,
                        ""iso_language_code"": ""en"",
                        ""source"": ""&lt;a href=&quot;http://www.echofon.com/&quot; rel=&quot;nofollow&quot;&gt;Echofon&lt;/a&gt;""
                    },
                    {
                        ""profile_image_url"": ""http://a3.twimg.com/profile_images/814751993/3354919358a12418397400l_2__normal.jpg"",
                        ""created_at"": ""Mon, 03 May 2010 01:04:43 +0000"",
                        ""from_user"": ""jordiiful_x"",
                        ""metadata"": {
                            ""result_type"": ""recent""
                        },
                        ""to_user_id"": 8002549,
                        ""text"": ""@KILLERSNEVERDIE as freaked out as the movie makes me,the Nightmare design is wicked :)"",
                        ""id"": 13276952888,
                        ""from_user_id"": 33713231,
                        ""to_user"": ""KILLERSNEVERDIE"",
                        ""geo"": null,
                        ""iso_language_code"": ""en"",
                        ""source"": ""&lt;a href=&quot;http://twitter.com/&quot;&gt;web&lt;/a&gt;""
                    },
                    {
                        ""profile_image_url"": ""http://a1.twimg.com/profile_images/565921362/sexytinki_normal.jpg"",
                        ""created_at"": ""Mon, 03 May2010 01:04:41 +0000"",
                        ""from_user"": ""pwrpuffgrl"",
                        ""metadata"": {
                            ""result_type"": ""recent""
                        },
                        ""to_user_id"": null,
                        ""text"": ""I lovethat movie :D"",
                        ""id"": 13276951524,
                        ""from_user_id"": 14105896,
                        ""geo"": null,
                        ""iso_language_code"": ""en"",
                        ""source"": ""&lt;a href=&quot;http://twitter.com/&quot;&gt;web&lt;/a&gt;""
                    }
                ],
                ""max_id"": 13277039355,
                ""since_id"": 0,
                ""refresh_url"": ""?since_id=13277039355&q=movie+%3A%29"",
                ""next_page"": ""?page=2&max_id=13277039355&q=movie+%3A%29"",
                ""results_per_page"": 15,
                ""page"": 1,
                ""completed_in"": 0.021501,
                ""query"": ""movie+%3A%29""
            }";

        #endregion

        [TestFixtureSetUp]
        public void Setup()
        {
            _conversionService = new ConversionService();
        }
    }
}