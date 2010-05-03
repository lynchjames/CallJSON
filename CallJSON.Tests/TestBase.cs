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

        public string FacebookWallJSON =
            @"{
               ""data"": [
                  {
                     ""id"": ""511395092_118069844882101"",
                     ""from"": {
                        ""name"": ""John Joseph Shanley"",
                        ""id"": ""511395092""
                     },
                     ""message"": ""Jamie Moyer: if you were Greek you'd be only six years off a pension.  What a man.  What a guy."",
                     ""icon"": ""http://static.ak.fbcdn.net/rsrc.php/z35B8/hash/c0s37sii.gif"",
                     ""attribution"": ""Mobile Web"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/511395092/posts/118069844882101""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/511395092/posts/118069844882101""
                        }
                     ],
                     ""created_time"": ""2010-05-03T03:12:54+0000"",
                     ""updated_time"": ""2010-05-03T03:12:54+0000""
                  },
                  {
                     ""id"": ""61016961_687841638291"",
                     ""from"": {
                        ""name"": ""James Lynch"",
                        ""id"": ""61016961""
                     },
                     ""picture"": ""http://platform.ak.fbcdn.net/www/app_full_proxy.php?app=174829003346&v=1&size=z&cksum=a9a29ad7d721d9fa7194bcfa77f2558f&src=http%3A%2F%2Fwww.spotify.com%2Fwp-content%2Fuploads%2Fspfb-profile-enabled.png"",
                     ""link"": ""http://open.spotify.com/user/lynchjames"",
                     ""name"": ""top 250 songs of the noughties by Ben McIlwaine, keep her lit"",
                     ""caption"": ""James subscribed to top 250 songs of the noughties by Ben McIlwaine, keep her lit by bhmcilwaine"",
                     ""icon"": ""http://photos-c.ak.fbcdn.net/photos-ak-sf2p/v27562/74/174829003346/app_2_174829003346_2760.gif"",
                     ""attribution"": ""Spotify"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/61016961/posts/687841638291""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/61016961/posts/687841638291""
                        },
                        {
                           ""name"": ""Subscribe to the playlist"",
                           ""link"": ""http://open.spotify.com/user/bhmcilwaine/playlist/67t8S67WFSmbYc1d9b8k0B""
                        }
                     ],
                     ""privacy"": {
                        ""description"": ""Friends of Friends"",
                        ""value"": ""FRIENDS_OF_FRIENDS""
                     },
                     ""created_time"": ""2010-05-02T22:36:20+0000"",
                     ""updated_time"": ""2010-05-02T22:36:20+0000""
                  },
                  {
                     ""id"": ""138481129434_118678804820786"",
                     ""from"": {
                        ""name"": ""Twibbon"",
                        ""id"": ""138481129434""
                     },
                     ""message"": ""The Philippines Presidential election is kicking off on Twibbon! http://bit.ly/9xDRmy - http://bit.ly/cuIFt8 - http://bit.ly/9E4pHZ"",
                     ""picture"": ""http://external.ak.fbcdn.net/safe_image.php?d=22f248e2a16f5960da6efa29a1a7e7a5&w=130&h=130&url=http%3A%2F%2Ftwibbon.s3.amazonaws.com%2F47%2Fe1b12528-7e61-4547-adcd-7fa8bc35008d.png"",
                     ""link"": ""http://bit.ly/9xDRmy"",
                     ""name"": ""Search Twibbon - Start Something! - Twibbon.com"",
                     ""caption"": ""bit.ly"",
                     ""icon"": ""http://static.ak.fbcdn.net/rsrc.php/zB010/hash/9yvl71tw.gif"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/138481129434/posts/118678804820786""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/138481129434/posts/118678804820786""
                        }
                     ],
                     ""privacy"": {
                        ""description"": ""Everyone"",
                        ""value"": ""EVERYONE""
                     },
                     ""created_time"": ""2010-05-02T21:44:06+0000"",
                     ""updated_time"": ""2010-05-03T02:35:15+0000"",
                     ""likes"": 7,
                     ""comments"": {
                        ""data"": [
                           {
                              ""id"": ""138481129434_118678804820786_451646"",
                              ""from"": {
                                 ""name"": ""Adam Horri"",
                                 ""id"": ""100000544033115""
                              },
                              ""message"": ""ANIMALS OF AFRICA \n\nhttp://www.facebook.com/home.php?#!/pages/ANIMALS-OF-AFRICA/112020772163847?ref=ts"",
                              ""created_time"": ""2010-05-02T21:45:05+0000""
                           },
                           {
                              ""id"": ""138481129434_118678804820786_451783"",
                              ""from"": {
                                 ""name"": ""Aberon Voltaire Solano Pala\u00f1a"",
                                 ""id"": ""1595783975""
                              },
                              ""message"": ""Long live the Philippines! Mabuhay!"",
                              ""created_time"": ""2010-05-02T22:13:29+0000""
                           },
                           {
                              ""id"": ""138481129434_118678804820786_451786"",
                              ""from"": {
                                 ""name"": ""Heronimus Ronnie \u30d8\u30ed\u30cb\u30de\u30b9"",
                                 ""id"": ""100000007895185""
                              },
                              ""message"": ""http://facebook.com/pages/heronimusstepblogspotcom/109660825737970"",
                              ""created_time"": ""2010-05-02T22:14:14+0000""
                           },
                           {
                              ""id"": ""138481129434_118678804820786_452017"",
                              ""from"": {
                                 ""name"": ""Sarah Turberville"",
                                 ""id"": ""775626941""
                              },
                              ""message"": ""People power?!"",
                              ""created_time"": ""2010-05-02T23:00:53+0000""
                           },
                           {
                              ""id"": ""138481129434_118678804820786_453247"",
                              ""from"": {
                                 ""name"": ""Elizabeth Michaela Nanon"",
                                 ""id"": ""1533965632""
                              },
                              ""message"": ""\""People Power\""?yan lang kaya gawin ni noynoy hehehe!mula congress hanggang senate naupo lang at ngayon gusto sa malakanyang naman maupo for 6 yrs?!wow!great! :D"",
                              ""created_time"": ""2010-05-03T02:35:15+0000""
                           }
                        ]
                     }
                  },
                  {
                     ""id"": ""527291942_113909248648832"",
                     ""from"": {
                        ""name"": ""Jane Campbell"",
                        ""id"": ""527291942""
                     },
                     ""message"": ""kicking Alan's ass at Guitar Hereo!! Rock on!! :)"",
                     ""icon"": ""http://static.ak.fbcdn.net/rsrc.php/z35B8/hash/c0s37sii.gif"",
                     ""attribution"": ""Mobile Web"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/527291942/posts/113909248648832""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/527291942/posts/113909248648832""
                        }
                     ],
                     ""created_time"": ""2010-05-02T21:02:51+0000"",
                     ""updated_time"": ""2010-05-02T21:02:51+0000"",
                     ""likes"": 1
                  },
                  {
                     ""id"": ""688711950_110503965658038"",
                     ""from"": {
                        ""name"": ""Deborah Cumming"",
                        ""id"": ""688711950""
                     },
                     ""message"": ""feet sanded, de-scaled, buffed and polished... whens the sun due? For once im ready for it!"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/688711950/posts/110503965658038""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/688711950/posts/110503965658038""
                        }
                     ],
                     ""created_time"": ""2010-05-02T20:18:54+0000"",
                     ""updated_time"": ""2010-05-02T20:18:54+0000""
                  },
                  {
                     ""id"": ""511395092_124254137584938"",
                     ""from"": {
                        ""name"": ""John Joseph Shanley"",
                        ""id"": ""511395092""
                     },
                     ""message"": ""Can anyone tell me if the U.S. television networks will be showing the results of the U.K. elections this Thursdays?"",
                     ""icon"": ""http://static.ak.fbcdn.net/rsrc.php/z35B8/hash/c0s37sii.gif"",
                     ""attribution"": ""Mobile Web"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/511395092/posts/124254137584938""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/511395092/posts/124254137584938""
                        }
                     ],
                     ""created_time"": ""2010-05-02T20:04:18+0000"",
                     ""updated_time"": ""2010-05-02T21:49:50+0000"",
                     ""comments"": {
                        ""data"": [
                           {
                              ""id"": ""511395092_124254137584938_546637"",
                              ""from"": {
                                 ""name"": ""Gavin Scott"",
                                 ""id"": ""100000226618106""
                              },
                              ""message"": ""BBC?"",
                              ""created_time"": ""2010-05-02T21:48:12+0000""
                           },
                           {
                              ""id"": ""511395092_124254137584938_546643"",
                              ""from"": {
                                 ""name"": ""John Joseph Shanley"",
                                 ""id"": ""511395092""
                              },
                              ""message"": ""I'm not sure we get BBC America."",
                              ""created_time"": ""2010-05-02T21:49:50+0000""
                           }
                        ]
                     }
                  },
                  {
                     ""id"": ""500324032_115690908464459"",
                     ""from"": {
                        ""name"": ""Mario Cruzado"",
                        ""id"": ""500324032""
                     },
                     ""picture"": ""http://external.ak.fbcdn.net/safe_image.php?d=3339944e5a235755f911e1db9a0afdfe&w=130&h=130&url=http%3A%2F%2Fi.ytimg.com%2Fvi%2Fkm8AwsqNFw8%2F2.jpg"",
                     ""link"": ""http://www.youtube.com/watch?v=km8AwsqNFw8&feature=fvw"",
                     ""source"": ""http://www.youtube.com/v/km8AwsqNFw8&autoplay=1"",
                     ""name"": ""Magnetic Fields - No One Will Ever Love You Honestly"",
                     ""caption"": ""www.youtube.com"",
                     ""icon"": ""http://static.ak.fbcdn.net/rsrc.php/z9XZ8/hash/976ulj6z.gif"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/500324032/posts/115690908464459""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/500324032/posts/115690908464459""
                        }
                     ],
                     ""created_time"": ""2010-05-02T17:51:30+0000"",
                     ""updated_time"": ""2010-05-02T17:51:30+0000"",
                     ""likes"": 1
                  },
                  {
                     ""id"": ""500324032_118664654825274"",
                     ""from"": {
                        ""name"": ""Mario Cruzado"",
                        ""id"": ""500324032""
                     },
                     ""message"": ""Oh dear."",
                     ""picture"": ""http://external.ak.fbcdn.net/safe_image.php?d=c504e95d31fc09893fd34b95043848ee&w=130&h=130&url=http%3A%2F%2Fstatic.guim.co.uk%2Fsys-images%2FGuardian%2FPix%2Fpictures%2F2010%2F5%2F1%2F1272753749984%2FPhilippa-Stroud-006.jpg"",
                     ""link"": ""http://www.guardian.co.uk/politics/2010/may/02/conservatives-philippa-stroud-gay-cure"",
                     ""name"": ""Rising Tory star Philippa Stroud ran prayer sessions to 'cure' gay people | Politics | The Observer"",
                     ""caption"": ""www.guardian.co.uk"",
                     ""description"": ""Philippa Stroud, the Conservative parliamentary candidate for Sutton and Cheam, has founded US-style evangelical churches in Bedford and in Birmingham. Photograph: Graeme Robertson"",
                     ""icon"": ""http://static.ak.fbcdn.net/rsrc.php/zB010/hash/9yvl71tw.gif"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/500324032/posts/118664654825274""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/500324032/posts/118664654825274""
                        }
                     ],
                     ""created_time"": ""2010-05-02T17:08:02+0000"",
                     ""updated_time"": ""2010-05-02T17:08:02+0000""
                  },
                  {
                     ""id"": ""748578071_120057981354099"",
                     ""from"": {
                        ""name"": ""Matt Craven"",
                        ""id"": ""748578071""
                     },
                     ""picture"": ""http://external.ak.fbcdn.net/safe_image.php?d=dc3f54b785823f7ce803acc46b5b1fe3&w=130&h=130&url=http%3A%2F%2Fi.ytimg.com%2Fvi%2FSOrmjhWpPrY%2F2.jpg"",
                     ""link"": ""http://www.youtube.com/watch?v=SOrmjhWpPrY&feature=fvw"",
                     ""source"": ""http://www.youtube.com/v/SOrmjhWpPrY&autoplay=1"",
                     ""name"": ""Nirvana - Aneurysm Live"",
                     ""caption"": ""www.youtube.com"",
                     ""description"": ""Aneurysm en directo en el Tonight! Sold Out!"",
                     ""icon"": ""http://static.ak.fbcdn.net/rsrc.php/z9XZ8/hash/976ulj6z.gif"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/748578071/posts/120057981354099""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/748578071/posts/120057981354099""
                        }
                     ],
                     ""created_time"": ""2010-05-02T12:29:56+0000"",
                     ""updated_time"": ""2010-05-02T12:34:53+0000"",
                     ""likes"": 1,
                     ""comments"": {
                        ""data"": [
                           {
                              ""id"": ""748578071_120057981354099_460411"",
                              ""from"": {
                                 ""name"": ""Richard Bell"",
                                 ""id"": ""512838717""
                              },
                              ""message"": ""Tune!!"",
                              ""created_time"": ""2010-05-02T12:34:53+0000""
                           }
                        ]
                     }
                  },
                  {
                     ""id"": ""500324032_118672248157687"",
                     ""from"": {
                        ""name"": ""Mario Cruzado"",
                        ""id"": ""500324032""
                     },
                     ""message"": ""needs a name for a band."",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/500324032/posts/118672248157687""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/500324032/posts/118672248157687""
                        }
                     ],
                     ""created_time"": ""2010-05-02T12:11:42+0000"",
                     ""updated_time"": ""2010-05-02T17:37:04+0000"",
                     ""comments"": {
                        ""data"": [
                           {
                              ""id"": ""500324032_118672248157687_449900"",
                              ""from"": {
                                 ""name"": ""Heather Baker"",
                                 ""id"": ""339900083""
                              },
                              ""message"": ""Still not come up with anything? Slow moves."",
                              ""created_time"": ""2010-05-02T13:11:24+0000""
                           },
                           {
                              ""id"": ""500324032_118672248157687_450430"",
                              ""from"": {
                                 ""name"": ""Mario Cruzado"",
                                 ""id"": ""500324032""
                              },
                              ""message"": ""Slow moves? I like that. "",
                              ""created_time"": ""2010-05-02T14:39:24+0000""
                           },
                           {
                              ""id"": ""500324032_118672248157687_450546"",
                              ""from"": {
                                 ""name"": ""Heather Baker"",
                                 ""id"": ""339900083""
                              },
                              ""message"": ""That wasn't so much a suggestion as a comment on your delayed progress... but whatever works."",
                              ""created_time"": ""2010-05-02T15:03:23+0000""
                           },
                           {
                              ""id"": ""500324032_118672248157687_450649"",
                              ""from"": {
                                 ""name"": ""Elpis Pavlidou"",
                                 ""id"": ""551974860""
                              },
                              ""message"": ""MMS (make mom smile)"",
                              ""created_time"": ""2010-05-02T15:22:14+0000""
                           },
                           {
                              ""id"": ""500324032_118672248157687_451369"",
                              ""from"": {
                                 ""name"": ""Mario Cruzado"",
                                 ""id"": ""500324032""
                              },
                              ""message"": ""No need to be a total biatch Heather. Pfffffffffffffff..."",
                              ""created_time"": ""2010-05-02T17:05:26+0000""
                           },
                           {
                              ""id"": ""500324032_118672248157687_451433"",
                              ""from"": {
                                 ""name"": ""Heather Baker"",
                                 ""id"": ""339900083""
                              },
                              ""message"": ""A biatch? Oh no you didn't. Hahaha."",
                              ""created_time"": ""2010-05-02T17:13:32+0000""
                           },
                           {
                              ""id"": ""500324032_118672248157687_451622"",
                              ""from"": {
                                 ""name"": ""Mario Cruzado"",
                                 ""id"": ""500324032""
                              },
                              ""message"": "":)"",
                              ""created_time"": ""2010-05-02T17:37:04+0000""
                           }
                        ]
                     }
                  },
                  {
                     ""id"": ""688711950_113850991983590"",
                     ""from"": {
                        ""name"": ""Deborah Cumming"",
                        ""id"": ""688711950""
                     },
                     ""picture"": ""http://platform.ak.fbcdn.net/www/app_full_proxy.php?app=102452128776&v=1&size=z&cksum=405e5374ccfc2d83dffa60e27af64be0&src=http%3A%2F%2Fstatic-3.farmville.com%2Fv25349%2Fassets%2Fnewsfeed%2Fsm_recruit.png"",
                     ""link"": ""http://apps.facebook.com/onthefarm/track.php?creative&cat=feed_start_mission&subcat&key=05d8861a5443b6609085fbd5471767fc&next"",
                     ""name"": ""Deborah started the Pumpkin Pie O'Plenty! job in FarmVille and wants YOU to help!"",
                     ""caption"": ""Deborah just started the Pumpkin Pie O'Plenty! job and needs to harvest 1400 Pumpkins in 1 days 13 hrs. Finishing the job promises a huge payout to all farmers involved!"",
                     ""icon"": ""http://photos-a.ak.fbcdn.net/photos-ak-sf2p/v43/144/102452128776/app_2_102452128776_416.gif"",
                     ""attribution"": ""FarmVille"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/688711950/posts/113850991983590""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/688711950/posts/113850991983590""
                        },
                        {
                           ""name"": ""Join their Co-op!"",
                           ""link"": ""http://apps.facebook.com/onthefarm/track.php?creative=&cat=feed_start_mission&subcat=&key=3870cd48dc72b6c64f26474b672ed5ab&next=reward.php%3FfrHost%3D688711950%26frId%3D535c7c25910caadaa564cae0ef8ddef1%26frType%3DSocialMissionRecruitFriendReward""
                        }
                     ],
                     ""created_time"": ""2010-05-02T11:46:13+0000"",
                     ""updated_time"": ""2010-05-02T11:46:13+0000""
                  },
                  {
                     ""id"": ""748578071_113826541990686"",
                     ""from"": {
                        ""name"": ""Matt Craven"",
                        ""id"": ""748578071""
                     },
                     ""message"": ""you said it Yogi!"",
                     ""picture"": ""http://external.ak.fbcdn.net/safe_image.php?d=6001f21c5801dfc6de7259797f3965d2&w=130&h=130&url=http%3A%2F%2Fnewsimg.bbc.co.uk%2Fmedia%2Fimages%2F47760000%2Fjpg%2F_47760529_hughes_282b.jpg"",
                     ""link"": ""http://news.bbc.co.uk/sport1/hi/football/teams/h/hibernian/8656100.stm"",
                     ""name"": ""BBC Sport - Football - 'Fearful' Hibernian frustrate manager John Hughes"",
                     ""caption"": ""news.bbc.co.uk"",
                     ""description"": ""\""We got a great start to the second half with the penalty,\"" said Hughes. \""I felt that was the turning point. We were afraid after that."",
                     ""icon"": ""http://static.ak.fbcdn.net/rsrc.php/z8I3N/hash/8cy5lbr7.png"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/748578071/posts/113826541990686""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/748578071/posts/113826541990686""
                        }
                     ],
                     ""created_time"": ""2010-05-02T11:38:27+0000"",
                     ""updated_time"": ""2010-05-02T13:43:12+0000"",
                     ""comments"": {
                        ""data"": [
                           {
                              ""id"": ""748578071_113826541990686_357879"",
                              ""from"": {
                                 ""name"": ""Simon Gilhooley"",
                                 ""id"": ""554746812""
                              },
                              ""message"": ""he says it every week tho. Should never have lost at the tattie bowl, but he managed to fuck that up. He's totally inept."",
                              ""created_time"": ""2010-05-02T13:04:10+0000""
                           },
                           {
                              ""id"": ""748578071_113826541990686_358078"",
                              ""from"": {
                                 ""name"": ""Matt Craven"",
                                 ""id"": ""748578071""
                              },
                              ""message"": ""2 goalkeeping errors...Smith failed to clear 2 easy shots"",
                              ""created_time"": ""2010-05-02T13:43:12+0000""
                           }
                        ]
                     }
                  },
                  {
                     ""id"": ""703248078_117715708249875"",
                     ""from"": {
                        ""name"": ""Ann-Marie Amd Dalgleish"",
                        ""id"": ""703248078""
                     },
                     ""message"": ""Glee!!! :)"",
                     ""icon"": ""http://static.ak.fbcdn.net/rsrc.php/z35B8/hash/c0s37sii.gif"",
                     ""attribution"": ""Mobile Web"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/703248078/posts/117715708249875""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/703248078/posts/117715708249875""
                        }
                     ],
                     ""created_time"": ""2010-05-02T11:18:36+0000"",
                     ""updated_time"": ""2010-05-02T11:18:36+0000"",
                     ""likes"": 1
                  },
                  {
                     ""id"": ""589380939_117791531574609"",
                     ""from"": {
                        ""name"": ""Chris Bowen"",
                        ""id"": ""589380939""
                     },
                     ""picture"": ""http://platform.ak.fbcdn.net/www/app_full_proxy.php?app=234860566661&v=1&size=z&cksum=a4c903ef2401637f7f6b82a6f3c86838&src=http%3A%2F%2Fassets.treasure.zynga.com%2Fv9012%2Fassets%2Fnewsfeed%2Ffeed_fruit_90x90.png"",
                     ""link"": ""http://apps.facebook.com/treasureisle/tracks.php?creative&cat=box_of_fruit&subcat=share&key=39a74cdf24c60319781bf9d557355a7c%24%24gkO%2AVUXV6YyMY4M5I%21s2Ux%21xfPSoMBNVK1hb%29c%28%2AbjxTb3GeB&next=reward.php%3FfrHost%3D1%3A589380939%26frId%3D0bb039a02b6c0efdc5e6ebadc615298c%26frType%3DBoxOfFruitFriendReward%26v%3Dfeed%26zmc_id%3D0bb039a02b6c0efdc5e6ebadc615298c%26cts%3D1272797879"",
                     ""name"": ""Chris found a Fruit Crate in Treasure Isle!"",
                     ""caption"": ""Chris is sharing a Fruit Crate with their friends. There are only a few left!"",
                     ""icon"": ""http://photos-f.ak.fbcdn.net/photos-ak-sf2p/v43/161/234860566661/app_2_234860566661_6691.gif"",
                     ""attribution"": ""Treasure Isle"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/589380939/posts/117791531574609""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/589380939/posts/117791531574609""
                        },
                        {
                           ""name"": ""Get a fruit"",
                           ""link"": ""http://apps.facebook.com/treasureisle/tracks.php?creative=&cat=box_of_fruit&subcat=share&key=39a74cdf24c60319781bf9d557355a7c$$gkO*VUXV6YyMY4M5I!s2Ux!xfPSoMBNVK1hb)c(*bjxTb3GeB&next=reward.php%3FfrHost%3D1%3A589380939%26frId%3D0bb039a02b6c0efdc5e6ebadc615298c%26frType%3DBoxOfFruitFriendReward%26v%3Dfeed%26zmc_id%3D0bb039a02b6c0efdc5e6ebadc615298c%26cts%3D1272797879""
                        }
                     ],
                     ""created_time"": ""2010-05-02T10:58:04+0000"",
                     ""updated_time"": ""2010-05-02T10:58:04+0000""
                  },
                  {
                     ""id"": ""517894718_118739551477245"",
                     ""from"": {
                        ""name"": ""Mark Glancy"",
                        ""id"": ""517894718""
                     },
                     ""message"": ""is running late! dam you hangover"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/517894718/posts/118739551477245""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/517894718/posts/118739551477245""
                        }
                     ],
                     ""created_time"": ""2010-05-02T10:45:52+0000"",
                     ""updated_time"": ""2010-05-02T15:28:40+0000"",
                     ""likes"": 4,
                     ""comments"": {
                        ""data"": [
                           {
                              ""id"": ""517894718_118739551477245_440239"",
                              ""from"": {
                                 ""name"": ""Mark Glancy"",
                                 ""id"": ""517894718""
                              },
                              ""message"": ""its not good! I have to be at christening in 20 minutes"",
                              ""created_time"": ""2010-05-02T11:08:57+0000""
                           },
                           {
                              ""id"": ""517894718_118739551477245_440360"",
                              ""from"": {
                                 ""name"": ""Mark Glancy"",
                                 ""id"": ""517894718""
                              },
                              ""message"": ""made it! but totally under dressed lol. "",
                              ""created_time"": ""2010-05-02T11:33:53+0000""
                           },
                           {
                              ""id"": ""517894718_118739551477245_440395"",
                              ""from"": {
                                 ""name"": ""Lee Tulleth"",
                                 ""id"": ""1571614422""
                              },
                              ""message"": ""lol"",
                              ""created_time"": ""2010-05-02T11:41:05+0000""
                           },
                           {
                              ""id"": ""517894718_118739551477245_441725"",
                              ""from"": {
                                 ""name"": ""Nicole Stoddart"",
                                 ""id"": ""1392863624""
                              },
                              ""message"": ""You missed most of it!"",
                              ""created_time"": ""2010-05-02T15:28:40+0000""
                           }
                        ]
                     }
                  },
                  {
                     ""id"": ""703248078_435295858078"",
                     ""from"": {
                        ""name"": ""Ann-Marie Amd Dalgleish"",
                        ""id"": ""703248078""
                     },
                     ""picture"": ""http://photos-d.ak.fbcdn.net/hphotos-ak-snc3/hs579.snc3/31538_435300308078_703248078_5635925_6819003_s.jpg"",
                     ""link"": ""http://www.facebook.com/photo.php?pid=5635925&id=703248078"",
                     ""icon"": ""http://static.ak.fbcdn.net/rsrc.php/z6T48/hash/d9b9ivs6.gif"",
                     ""attribution"": ""via <a href=\""/mobile/?v=photos\"">Facebook Mobile</a>"",
                     ""created_time"": ""2010-05-02T10:37:11+0000"",
                     ""updated_time"": ""2010-05-02T10:37:11+0000""
                  },
                  {
                     ""id"": ""61016961_687653555211"",
                     ""from"": {
                        ""name"": ""James Lynch"",
                        ""id"": ""61016961""
                     },
                     ""picture"": ""http://platform.ak.fbcdn.net/www/app_full_proxy.php?app=174829003346&v=1&size=z&cksum=a9a29ad7d721d9fa7194bcfa77f2558f&src=http%3A%2F%2Fwww.spotify.com%2Fwp-content%2Fuploads%2Fspfb-profile-enabled.png"",
                     ""link"": ""http://open.spotify.com/user/lynchjames"",
                     ""name"": ""lynchjames's profile in Spotify"",
                     ""caption"": ""lynchjames just activated Facebook for Spotify making it easier to find friends' Spotify playlists.  Click to see lynchjames's Spotify profile with playlists and favourite music."",
                     ""icon"": ""http://photos-c.ak.fbcdn.net/photos-ak-sf2p/v27562/74/174829003346/app_2_174829003346_2760.gif"",
                     ""attribution"": ""Spotify"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/61016961/posts/687653555211""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/61016961/posts/687653555211""
                        },
                        {
                           ""name"": ""Get Spotify"",
                           ""link"": ""http://www.spotify.com""
                        }
                     ],
                     ""privacy"": {
                        ""description"": ""Friends of Friends"",
                        ""value"": ""FRIENDS_OF_FRIENDS""
                     },
                     ""created_time"": ""2010-05-02T00:02:07+0000"",
                     ""updated_time"": ""2010-05-02T00:02:07+0000""
                  },
                  {
                     ""id"": ""703248078_117955044892928"",
                     ""from"": {
                        ""name"": ""Ann-Marie Amd Dalgleish"",
                        ""id"": ""703248078""
                     },
                     ""message"": ""Wonders"",
                     ""icon"": ""http://static.ak.fbcdn.net/rsrc.php/z35B8/hash/c0s37sii.gif"",
                     ""attribution"": ""Mobile Web"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/703248078/posts/117955044892928""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/703248078/posts/117955044892928""
                        }
                     ],
                     ""created_time"": ""2010-05-01T23:08:46+0000"",
                     ""updated_time"": ""2010-05-01T23:08:46+0000""
                  },
                  {
                     ""id"": ""527291942_122391121110454"",
                     ""from"": {
                        ""name"": ""Jane Campbell"",
                        ""id"": ""527291942""
                     },
                     ""picture"": ""http://platform.ak.fbcdn.net/www/app_full_proxy.php?app=234860566661&v=1&size=z&cksum=454cfda2881f4bedff38e63c267caad0&src=http%3A%2F%2Fassets.treasure.zynga.com%2Fv9012%2Fassets%2Fnewsfeed%2Frequest_gem_blue.png"",
                     ""link"": ""http://apps.facebook.com/treasureisle/tracks.php?creative&cat=gems&subcat=ask&key=1ef8c4c88713c6c2090f28d5933e93db%24%24geM%21WVXW%2AYyMY4MayVYEP_3%21LyrDmrHDEfy2%28%29U&next=http%3A%2F%2Fapps.facebook.com%2Ftreasureisle%2Freward.php%3FfrHost%3D1%3A527291942%26frType%3DAskForGemReward%26frId%3D89e6498a4b7448f506151a67cff11f0a%26v%3Dfeed%26cts%3D1272749869"",
                     ""name"": ""Jane needs Blue Gems in Treasure Isle!"",
                     ""caption"": ""Jane needs gems to help them find more treasure."",
                     ""icon"": ""http://photos-f.ak.fbcdn.net/photos-ak-sf2p/v43/161/234860566661/app_2_234860566661_6691.gif"",
                     ""attribution"": ""Treasure Isle"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/527291942/posts/122391121110454""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/527291942/posts/122391121110454""
                        },
                        {
                           ""name"": ""Send Gift!"",
                           ""link"": ""http://apps.facebook.com/treasureisle/tracks.php?creative=&cat=gems&subcat=ask&key=1ef8c4c88713c6c2090f28d5933e93db$$geM!WVXW*YyMY4MayVYEP_3!LyrDmrHDEfy2()U&next=http%3A%2F%2Fapps.facebook.com%2Ftreasureisle%2Freward.php%3FfrHost%3D1%3A527291942%26frType%3DAskForGemReward%26frId%3D89e6498a4b7448f506151a67cff11f0a%26v%3Dfeed%26cts%3D1272749869""
                        }
                     ],
                     ""created_time"": ""2010-05-01T21:37:51+0000"",
                     ""updated_time"": ""2010-05-01T21:37:51+0000""
                  },
                  {
                     ""id"": ""527291942_123625437652248"",
                     ""from"": {
                        ""name"": ""Jane Campbell"",
                        ""id"": ""527291942""
                     },
                     ""message"": ""just saw Iron Man 2.  As far as sequel films go it was pretty good!! Will need to add it to the DVD collection for sure!"",
                     ""icon"": ""http://static.ak.fbcdn.net/rsrc.php/z35B8/hash/c0s37sii.gif"",
                     ""attribution"": ""Mobile Web"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/527291942/posts/123625437652248""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/527291942/posts/123625437652248""
                        }
                     ],
                     ""created_time"": ""2010-05-01T19:45:44+0000"",
                     ""updated_time"": ""2010-05-01T23:15:33+0000"",
                     ""comments"": {
                        ""data"": [
                           {
                              ""id"": ""527291942_123625437652248_552848"",
                              ""from"": {
                                 ""name"": ""Laura Wood"",
                                 ""id"": ""539425035""
                              },
                              ""message"": ""we must go and see it - i've been loking forward to it, much to the dismay of some of the girls at work."",
                              ""created_time"": ""2010-05-01T23:15:33+0000""
                           }
                        ]
                     }
                  },
                  {
                     ""id"": ""688711950_119766171382221"",
                     ""from"": {
                        ""name"": ""Deborah Cumming"",
                        ""id"": ""688711950""
                     },
                     ""message"": ""let the nachos fest begin!!!"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/688711950/posts/119766171382221""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/688711950/posts/119766171382221""
                        }
                     ],
                     ""created_time"": ""2010-05-01T18:26:46+0000"",
                     ""updated_time"": ""2010-05-01T18:26:46+0000""
                  },
                  {
                     ""id"": ""517894718_115528078482080"",
                     ""from"": {
                        ""name"": ""Mark Glancy"",
                        ""id"": ""517894718""
                     },
                     ""message"": ""loves the co-op! walked in drunk! left with more booze :D"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/517894718/posts/115528078482080""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/517894718/posts/115528078482080""
                        }
                     ],
                     ""created_time"": ""2010-05-01T18:22:00+0000"",
                     ""updated_time"": ""2010-05-01T23:13:15+0000"",
                     ""likes"": 8,
                     ""comments"": {
                        ""data"": [
                           {
                              ""id"": ""517894718_115528078482080_391365"",
                              ""from"": {
                                 ""name"": ""Rachel Walsh"",
                                 ""id"": ""577036651""
                              },
                              ""message"": ""think they'll serve me now? =P"",
                              ""created_time"": ""2010-05-01T23:13:15+0000""
                           }
                        ]
                     }
                  },
                  {
                     ""id"": ""748578071_122550641090948"",
                     ""from"": {
                        ""name"": ""Matt Craven"",
                        ""id"": ""748578071""
                     },
                     ""message"": ""another shoddy finish by Hibs"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/748578071/posts/122550641090948""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/748578071/posts/122550641090948""
                        }
                     ],
                     ""created_time"": ""2010-05-01T16:32:00+0000"",
                     ""updated_time"": ""2010-05-01T22:06:01+0000"",
                     ""likes"": 1,
                     ""comments"": {
                        ""data"": [
                           {
                              ""id"": ""748578071_122550641090948_518447"",
                              ""from"": {
                                 ""name"": ""Rory Flynn"",
                                 ""id"": ""1049385635""
                              },
                              ""message"": ""fantastico you lot are gash 4 games and 4 games you aint looked like beating us!even cheating for a pen with your hibby daft ref that twat mcdonald should be banned from doing hearts games!!!"",
                              ""created_time"": ""2010-05-01T22:06:01+0000""
                           }
                        ]
                     }
                  },
                  {
                     ""id"": ""61011491_113565885347667"",
                     ""from"": {
                        ""name"": ""Alex Marshall"",
                        ""id"": ""61011491""
                     },
                     ""message"": ""is in love with the Psychedelic Furs, and having a crisis of conscience. D\u00e9j\u00e0-vu..."",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/61011491/posts/113565885347667""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/61011491/posts/113565885347667""
                        }
                     ],
                     ""created_time"": ""2010-05-01T15:45:21+0000"",
                     ""updated_time"": ""2010-05-01T15:45:21+0000"",
                     ""likes"": 2
                  },
                  {
                     ""id"": ""703248078_113543632016415"",
                     ""from"": {
                        ""name"": ""Ann-Marie Amd Dalgleish"",
                        ""id"": ""703248078""
                     },
                     ""message"": ""I am going to vote for myself on Thursday!"",
                     ""actions"": [
                        {
                           ""name"": ""Comment"",
                           ""link"": ""http://www.facebook.com/703248078/posts/113543632016415""
                        },
                        {
                           ""name"": ""Like"",
                           ""link"": ""http://www.facebook.com/703248078/posts/113543632016415""
                        }
                     ],
                     ""created_time"": ""2010-05-01T15:26:00+0000"",
                     ""updated_time"": ""2010-05-02T15:45:47+0000"",
                     ""likes"": 1,
                     ""comments"": {
                        ""data"": [
                           {
                              ""id"": ""703248078_113543632016415_355463"",
                              ""from"": {
                                 ""name"": ""Eve Onne Egan"",
                                 ""id"": ""672659282""
                              },
                              ""message"": ""Vote for Brown!!"",
                              ""created_time"": ""2010-05-01T15:32:46+0000""
                           },
                           {
                              ""id"": ""703248078_113543632016415_355489"",
                              ""from"": {
                                 ""name"": ""Ann-Marie Amd Dalgleish"",
                                 ""id"": ""703248078""
                              },
                              ""message"": ""Dalgleish!"",
                              ""created_time"": ""2010-05-01T15:36:01+0000""
                           },
                           {
                              ""id"": ""703248078_113543632016415_355510"",
                              ""from"": {
                                 ""name"": ""Drew Smillie"",
                                 ""id"": ""801479195""
                              },
                              ""message"": ""I will vote for you Ann-Marie as I am bored of those other 3 fannies, what is your manifesto though?"",
                              ""created_time"": ""2010-05-01T15:39:58+0000""
                           },
                           {
                              ""id"": ""703248078_113543632016415_355560"",
                              ""from"": {
                                 ""name"": ""Ann-Marie Amd Dalgleish"",
                                 ""id"": ""703248078""
                              },
                              ""message"": ""Hooray my first supporter! I propose cheap drink, a 3 day weekend where you can pick either friday or monday and of course the 1st drink in every pub is a bottle of wine. With a straw!"",
                              ""created_time"": ""2010-05-01T15:48:44+0000""
                           },
                           {
                              ""id"": ""703248078_113543632016415_355566"",
                              ""from"": {
                                 ""name"": ""Eve Onne Egan"",
                                 ""id"": ""672659282""
                              },
                              ""message"": ""I can't drink I'm pregnant! Will you lower the tax on soft drinks please Prime Minister?"",
                              ""created_time"": ""2010-05-01T15:50:31+0000""
                           },
                           {
                              ""id"": ""703248078_113543632016415_355941"",
                              ""from"": {
                                 ""name"": ""Ann-Marie Amd Dalgleish"",
                                 ""id"": ""703248078""
                              },
                              ""message"": ""seriously??? omg congratulations babe!!! :) i will make nappies free xx"",
                              ""created_time"": ""2010-05-01T16:58:26+0000""
                           },
                           {
                              ""id"": ""703248078_113543632016415_356055"",
                              ""from"": {
                                 ""name"": ""Jennifer Phillips Main"",
                                 ""id"": ""715487383""
                              },
                              ""message"": ""i'll vote for you too ann-marie! :)"",
                              ""created_time"": ""2010-05-01T17:14:45+0000""
                           },
                           {
                              ""id"": ""703248078_113543632016415_356181"",
                              ""from"": {
                                 ""name"": ""Fiona Watt"",
                                 ""id"": ""100000480316551""
                              },
                              ""message"": ""i will vote for you too hun,lol xxx"",
                              ""created_time"": ""2010-05-01T17:31:36+0000""
                           },
                           {
                              ""id"": ""703248078_113543632016415_361810"",
                              ""from"": {
                                 ""name"": ""David Gordon Wilson"",
                                 ""id"": ""1143158357""
                              },
                              ""message"": ""i would vote for you too, if i was alloud to vote, lol"",
                              ""created_time"": ""2010-05-02T15:45:47+0000""
                           }
                        ]
                     }
                  }
               ],
               ""paging"": {
                  ""previous"": ""http://graph.facebook.com/61016961/home?access_token=2227470867%7C2.e7U87YhRSncq8Pf8FOb5gQ__.3600.1272862800-61016961%7CWGmFKX5bqAr1XH9kJr9t9hQt4y0.&limit=25&since=2010-05-03T03%3A12%3A54%2B0000"",
                  ""next"": ""http://graph.facebook.com/61016961/home?access_token=2227470867%7C2.e7U87YhRSncq8Pf8FOb5gQ__.3600.1272862800-61016961%7CWGmFKX5bqAr1XH9kJr9t9hQt4y0.&limit=25&until=2010-05-01T15%3A26%3A00%2B0000""
               }
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