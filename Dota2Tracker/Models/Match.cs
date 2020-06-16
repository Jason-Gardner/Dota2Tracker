using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2Tracker.Models
{
    public class playerMatch
    {
        public string matchID { get; set; }
        public string heroID { get; set; }
        public string matchKDA { get; set; }

        public playerMatch()
        {

        }

        public playerMatch(string MatchID, string HeroID, string MatchKDA)
        {
            matchID = MatchID;
            heroID = HeroID;
            matchKDA = MatchKDA;
        }
    }
}
