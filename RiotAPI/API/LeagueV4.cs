using Newtonsoft.Json;
using RiotAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotAPI.API
{
    internal class LeagueV4 : Rito
    {
        public LeagueV4(string region) : base(region)
        {
        }

        public List<EntryDTO> GetEntrys(string summonerId)
        {
            string path = "league/v4/entries/by-summoner/" + summonerId;

            var response = GetResponse(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<EntryDTO>>(content);
            }
            else
            {
                return null;
            }
        }
    }
}

