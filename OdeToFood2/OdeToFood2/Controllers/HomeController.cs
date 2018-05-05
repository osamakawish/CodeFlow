using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OdeToFood2.Services;
using OdeToFood2.ViewModels;

namespace OdeToFood2.Controllers
{
    public class HomeController : Controller
    {
        private IGreeter greeter;
        private IRestaurantData restaurantData;

        public HomeController(IGreeter greeter, IRestaurantData restaurantData)
        {
            this.greeter = greeter; this.restaurantData = restaurantData;
        }

        //public string Index() => "Home Controller page.";

        public IActionResult Index() => View(new HomeIndexViewModel()
        {
            Greetings = greeter.Message(),
            Restaurants = restaurantData.GetAll()
        });
    }
}