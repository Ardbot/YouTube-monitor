using System;
using System.Collections.Generic;
using Newtonsoft.Json; //Подключить NuGet
using System.Net; //Подключить

/*____________________________⚙_P+E+M_⚙______________________________\
  | Об устройстве: Монитор видео на Youtube   Ver. 1.0                  |
  | By Programming + Electronics + Mechanics   (feat. Brian Lough)      |
  | Вопросы  сюда: https://vk.com/pr_el_mh                              |
  \___________________________⚙_P+E+M_⚙______________________________*/

namespace Yotube_Stat
{
    public class basis
    {
     public class PageInfo
        {
            public int totalResults { get; set; }
            public int resultsPerPage { get; set; }
        }

        public class Statistics
        {
            public string viewCount { get; set; }
            public string likeCount { get; set; }
            public string dislikeCount { get; set; }
            public string favoriteCount { get; set; }
            public string commentCount { get; set; }
        }

        public class Item
        {
            public string kind { get; set; }
            public string etag { get; set; }
            public string id { get; set; }
            public Statistics statistics { get; set; }
        }

       public class RootObject
        {
            public string kind { get; set; }
            public string etag { get; set; }
            public PageInfo pageInfo { get; set; }
            public List<Item> items { get; set; }
        }
        
        public static void Main()
        {
            var jsonString = new WebClient().DownloadString(@"https://www.googleapis.com/youtube/v3/videos?part=statistics&id=[ID_video]&key=[Ваш_API_key]"); // Здесь необходимо указать Id видео и API ключ от Ютуба. Как получить:  https://www.slickremix.com/docs/get-api-key-for-youtube/
            var itemsFromApi = JsonConvert.DeserializeObject<RootObject>(jsonString);

            Console.WriteLine("viewCount: {0}", itemsFromApi.items[0].statistics.viewCount);
            Console.WriteLine("viewCount: {0}", itemsFromApi.items[0].statistics.likeCount);
            Console.WriteLine("dislikeCount: {0}", itemsFromApi.items[0].statistics.dislikeCount);
            Console.WriteLine("commentCount: {0}", itemsFromApi.items[0].statistics.commentCount);

            Console.ReadKey();

        }
    }
}





