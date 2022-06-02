using Newtonsoft.Json;
using RiotAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotAPI.API
{
    internal class SummonerV4 : Rito
    {
        public SummonerV4(string region) : base(region)
        {
        }
        public SummonerDTO GetSummonerName(string summonerName)
        {
            string path = "summoner/v4/summoners/by-name/" + summonerName;
            var response = GetResponse(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            //try
            //{

            //    response.EnsureSuccessStatusCode();
            //    return JsonConvert.DeserializeObject<SummonerDTO>(content);

            //}
            //catch (Exception ex)
            //{
            //    return null;
            //}

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<SummonerDTO>(content);
            }
            else
            {
                return null;
            }
        }

    }
}
