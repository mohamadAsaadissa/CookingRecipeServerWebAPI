using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingRecipesWebAPI.Models
{
    public class ExtraInfo
    {
        public string ExtraInfoId { get; set; }

        public string Title { get; set; }
        public string Summary { get; set; }
        public ICollection<Video> Videos { get; set; }

        public ExtraInfo()
        {
            Videos = new List<Video>();
        }
        public string DishId { get; set; }
     
        public Dish Dish { get; set; }
    }
}
