using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingRecipesWebAPI.Models
{
    public class PreperationMethod
    {
        public string PreperationMethodId { get; set; }

        public string Title { get; set; }
        public string Summary { get; set; }
        public virtual string DishId { get; set; }
        public Dish Dish { get; set; }
    }
}
