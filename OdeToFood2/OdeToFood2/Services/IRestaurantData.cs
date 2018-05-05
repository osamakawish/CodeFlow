using OdeToFood2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood2.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int Id);
    }

    public class RestaurantData : IRestaurantData
    {
        IEnumerable<Restaurant> restaurants;

        public RestaurantData()
        {
            restaurants = new List<Restaurant>
            {
                new Restaurant{ Id = 1, Name = "Pizz" },
                new Restaurant{ Id = 2, Name = "Tims Horts"},
                new Restaurant{ Id = 3, Name = "Fly Chics"}
            };
        }

        public Restaurant Get(int Id) => restaurants.FirstOrDefault(x => x.Id == Id);

        public IEnumerable<Restaurant> GetAll() => restaurants.OrderBy(r => r.Name);
    }
}
