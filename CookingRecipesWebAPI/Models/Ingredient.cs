using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingRecipesWebAPI.Models
{
    public class Ingredient
    { 
        public string IngredientId { get; set; }        
        public string Title { get; set; } 
        public string Summary { get; set; }
        public string Link { get; set; }
        public byte Weight { get; set; }
        public string ReceiptId { get; set; }
        public Receipt Receipt { get; set; }
    }
}
