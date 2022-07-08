using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingRecipesWebAPI.Models
{
    public class Kitchen
    {
        public string KitchenId { get; set; }
     
        public string Country { get; set; }
        public string Summary { get; set; }

       
        public Receipt Receipt { get; set; }
    }
}
