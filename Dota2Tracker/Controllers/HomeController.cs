using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dota2Tracker.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace Dota2Tracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<List<playerMatch>> getMatches(string playerID)
        {
            var matches = await playerMatches(playerID);
            return matches;
        }

        public async Task<List<playerMatch>> playerMatches(string playerID)
        {
            List<playerMatch> matchList = new List<playerMatch>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://api.opendota.com/api/players/" + playerID + "/recentMatches"))
                {
                    var summary = await response.Content.ReadAsStringAsync();
                    var matches = JsonDocument.Parse(summary);
                    var list = matches.RootElement.GetArrayLength();

                    for (int i = 0; i < list; i++)
                    {
                        playerMatch thisMatch = new playerMatch();
                        var names = matches.RootElement[i].GetProperty("match_id");
                        thisMatch.heroID = matches.RootElement[i].GetProperty("hero_id").ToString();
                        thisMatch.matchID = matches.RootElement[i].GetProperty("match_id").ToString();
                        thisMatch.matchKDA = matches.RootElement[i].GetProperty("kills").ToString();
                        matchList.Add(thisMatch);
                    }
                }

                return matchList;
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetList()
        {
            string playerID = "248586332";
            var matchList = await getMatches(playerID);
            List<Hero> heroNames = await getHeroName();
            foreach (playerMatch inst in matchList)
            {
                foreach (Hero names in heroNames)
                {
                    if (names.heroID == inst.heroID)
                    {
                        inst.heroID = names.heroName;
                    }
                }
            }

            return Json(matchList);
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<List<Hero>> getHeroName()
        {
            List<Hero> heroNames = new List<Hero>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://api.opendota.com/api/heroes"))
                {
                    var stringHero = await response.Content.ReadAsStringAsync();
                    var heroList = JsonDocument.Parse(stringHero);

                    for (int i = 0; i < heroList.RootElement.GetArrayLength(); i++)
                    {
                        heroNames.Add(new Hero(heroList.RootElement[i].GetProperty("id").ToString(),heroList.RootElement[i].GetProperty("localized_name").ToString()));
                    }
                }
            }

            return heroNames;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
