using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RiotAPI.API
{
    public class Rito
    {
        public string Key { get; set; }
        public string Region { get; set; }

        public Rito(string region)
        {
            Region = region;
            Key = FetchKey("API/key.txt");
        }
        protected HttpResponseMessage GetResponse(string url)
        {
            using(HttpClient client = new HttpClient())
            {
                var result = client.GetAsync(url);
                result.Wait();
                return result.Result;
            }
        }
        protected string GetURI(string path)
        {
            return "https://" + Region + ".api.riotgames.com/lol/" + path + "?api_key=" + Key;
        }

        public string FetchKey(string path)
        {
            StreamReader sr = new StreamReader(path);
            string key = sr.ReadToEnd();
            return key;
        }
    }
}
