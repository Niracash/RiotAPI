using RiotAPI.API;
using RiotAPI.DTO;
using RiotAPI.Utility;
using RiotAPI.View.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotAPI.Controller
{
    public class ProfileController
    {
        public object GetContext()
        {
            var summoner = Super.Summoner;
            var entry = GetEntry(summoner);
            return new ProfileViewModel(summoner.Name, summoner.ProfileIconId, summoner.SummonerLevel, entry.Tier, entry.Rank, entry.Wins, entry.Losses);
        }

        private EntryDTO GetEntry(SummonerDTO summoner)
        {
            LeagueV4 league = new LeagueV4(Super.Region);
            var entry = league.GetEntrys(summoner.Id).Where(s => s.QueueType.Equals("RANKED_SOLO_5x5")).FirstOrDefault();

            return entry ?? new EntryDTO();
        }
    }
}
