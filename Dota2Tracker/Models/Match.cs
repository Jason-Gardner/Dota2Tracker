using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2Tracker.Models
{
    public class Match
    {
        private int matchID { get; set; }
        private int heroID { get; set; }
        private int[] matchKDA { get; set; }

        public Match(int MatchID, int HeroID, int[] MatchKDA)
        {
            matchID = MatchID;
            heroID = HeroID;
            matchKDA = MatchKDA;
        }
    }
}
