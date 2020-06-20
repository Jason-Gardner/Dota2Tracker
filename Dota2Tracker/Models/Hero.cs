using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2Tracker.Models
{
    public class Hero
    {
        public string heroID { get; set; }
        public string heroName { get; set; }

        public Hero(string HeroID, string HeroName)
        {
            heroID = HeroID;
            heroName = HeroName;
        }
    }
}
