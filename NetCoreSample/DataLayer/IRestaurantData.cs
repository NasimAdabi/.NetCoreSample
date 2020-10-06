using ClassLibrary.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        public class InMemoryRestaurantData : IRestaurantData
        {
            readonly List<Restaurant> restaurants;
            public InMemoryRestaurantData()
            {
                restaurants = new List<Restaurant>()
                {
                    new Restaurant {Id = 1, Name = "Mexican Pizza", Location = "West Street", Cuisin = CuisinType.Mexican},
                    new Restaurant {Id = 2, Name = "Persian Pizza", Location = "West Georgia Street", Cuisin = CuisinType.Persian}
                };
            }
            public IEnumerable<Restaurant> GetAll()
            {
                return from r in restaurants
                       orderby r.Name
                       select r;
            }
        }
    }
}
