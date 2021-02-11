using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace foodApp.Models
{
    public class Restaurant
    {
        public Restaurant(int rank)
        {
            Rank = rank;
        }


        [Required]
        public int Rank { get; }

        [Required]
        public string Name { get; set; }

        
        public string? FavDish { get; set; }

        [Required]
        public string Address { get; set; }

        
        public string? Phone { get; set; }


        public string? Website { get; set; } = "Coming Soon!";

        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
               
                Name = "Cafe Rio",
                FavDish = "Steak Salad",
                Address = "2244 N University Pkwy, Provo, UT 84604",
                Phone = "(801) 375-5133",
                Website = "https://www.caferio.com/"
            };
            Restaurant r2 = new Restaurant(2)
            {
                
                Name = "Taco Bell",
                FavDish = "$5 Naco Fries Box",
                Address = "1244 N Freedom Blvd, Provo, UT 84604",
                Phone = "(801) 377-7080",
                Website = "https://www.tacobell.com/"
            };
            Restaurant r3 = new Restaurant(3)
            {
                
                Name = "Chick-Fil-A",
                FavDish = "12 Count Nuggets",
                Address = "484 Bulldog Ln, Provo, UT 84604",
                Phone = "(801) 374-2697",
                Website = "https://www.chick-fil-a.com/"
            };
            Restaurant r4 = new Restaurant(4)
            {
                
                Name = "Five Guys",
                FavDish = "Cheese Burger",
                Address = "1051 S 750 E, Orem, UT 84097",
                Phone = "(801) 765-7556",
                Website = "https://www.fiveguys.com/"
            };
            Restaurant r5 = new Restaurant(5)
            {
                
                Name = "Mo' Bettahs",
                FavDish = "Teriyaki Chicken",
                Address = "1385 S State St, Orem, UT 84097",
                Phone = "(801) 960-4616",
                Website = "https://www.mobettahs.com"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }

    }
}
