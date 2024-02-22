using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotAPI.View.ViewModel
{
    public class ProfileViewModel
    {
        public string SummonerName { get; private set; }
        public string Icon { get; private set; }
        public long Level { get; private set; }
        public string Tier { get; private set; }

        public string Rank { get; private set; }
        public string RankIcon { get; private set; }
        public int Wins { get; private set; }
        public int Losses { get; private set; }

        public ProfileViewModel(string summonerName, int icon, long level, string tier, string rank, int wins, int losses)
        {
            SummonerName = summonerName;
            Icon = "https://ddragon.leagueoflegends.com/cdn/14.4.1/img/profileicon/" + icon + ".png";
            Level = level;
            Tier = tier;
            Rank = rank;
            Wins = wins;
            Losses = losses;
            RankIcon = "/Img/Ranks/Rank=" + tier + ".png";
        }
    }
}
