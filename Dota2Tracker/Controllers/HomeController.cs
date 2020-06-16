﻿using System;
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


        public async Task<IActionResult> Index()
        {
            string playerID = "248586332";
            var matchList = await getMatches(playerID);
            return View("Index", matchList);
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
