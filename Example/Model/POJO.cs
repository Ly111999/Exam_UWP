using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Example.Model
{
    public class POJO
    {
        public static async Task<List<POJO.RootObject>> GetYoutube()
        {
            var http = new HttpClient();
            var url =
                "http://youtube-video-api-1608.appspot.com/youtube/api";
            var resp = await http.GetAsync(url);
            var result = await resp.Content.ReadAsStringAsync();
            List<POJO.RootObject> list = JsonConvert.DeserializeObject<List<POJO.RootObject>>(result);
            return list;
        }

        public class RootObject
        {
            public string videoId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string keywords { get; set; }
            public string category { get; set; }
            public string genre { get; set; }
            public string authorName { get; set; }
            public string authorEmail { get; set; }
            public string birthday { get; set; }
        }
    }
}
