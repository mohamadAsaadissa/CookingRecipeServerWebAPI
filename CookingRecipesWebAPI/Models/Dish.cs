using CookingRecipesWebAPI.Models;
using System;
using System.Collections.Generic;

namespace CookingRecipesWebAPI
{
    public class Dish
    {
       
        public string DishId { get; set; }

        public string  Name { get; set; }
        public string summary { get; set; }
        public string Description { get; set; }
        public byte Like { get; set; }

        public DateTime Date { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<ExtraInfo> ExtraInfos { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<PreperationMethod> PreperationMethods { get; set; }

        public Dish()
        {
            Comments = new List<Comment>();
            ExtraInfos = new List<ExtraInfo>();
            Ingredients = new List<Ingredient>();
            PreperationMethods = new List<PreperationMethod>();
           
        }
    }
}
