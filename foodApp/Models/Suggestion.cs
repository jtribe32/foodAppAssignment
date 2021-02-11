using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace foodApp.Models
{
    public class Suggestion
    {

        [Required(ErrorMessage ="A Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A Restaurant Name is required")]
        public string RestName { get; set; }

        [Required(ErrorMessage = "A Favorite Dish is required")]
        public string FavDish { get; set; }


        [Required(ErrorMessage = "A Name is required")]
        [RegularExpression(@"^(1-)?\d{3}-\d{3}-\d{4}$", ErrorMessage = "The Phone must be put in this format ###-###-#### or #-###-###-####")] // This allows the formats of 234-567-890  and 1-234-567-8901
        public string Phone { get; set; }
    }
}
