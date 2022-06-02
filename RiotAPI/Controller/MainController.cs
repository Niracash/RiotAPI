using RiotAPI.API;
using RiotAPI.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotAPI.Controller
{
    public class MainController
    {
        public bool GetSummoner(string summonerName)
        {
            SummonerV4 summoner_V4 = new SummonerV4(Super.Region);
            var summoner = summoner_V4.GetSummonerName(summonerName);
            Super.Summoner = summoner;

            return summoner != null;
        }
    }
}
