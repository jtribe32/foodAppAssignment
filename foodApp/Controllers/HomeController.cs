using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using foodApp.Models;

namespace foodApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();
            foreach (Restaurant rest in Restaurant.GetRestaurants())
            {
                restaurantList.Add(string.Format($"#{rest.Rank}. {rest.Name} - {rest.FavDish ?? "It's all tasty!"} - {rest.Address} - {rest.Phone} - {rest.Website} "));
            }
            return View(restaurantList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Suggestions()
        {
            return View(TempStorage.Suggestions);
        }

        [HttpGet("FoodForm")]
        public IActionResult FoodForm()
        {
            return View();
        }

        //This redirects to the confirmation page after a movie is added.
        [HttpPost("FoodForm")]
        public IActionResult FoodForm(Suggestion suggestionResponse)
        {

            if (ModelState.IsValid)
            {
                TempStorage.AddSuggestion(suggestionResponse);
                return View("Confirmation");
            }
            else
            {
                return View(suggestionResponse);
            }
            
        }

        public IActionResult Confirmation()
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
