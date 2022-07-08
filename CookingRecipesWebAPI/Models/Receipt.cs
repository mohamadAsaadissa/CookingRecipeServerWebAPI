using CookingRecipesWebAPI.Models;
using System;
using System.Collections.Generic;

namespace CookingRecipesWebAPI
{
    public class Receipt
    {

        public string ReceiptId { get; set; }
        public string Title { get; set; }
        public string summary { get; set; }
        public string ImageName { get; set; }
        public string VideoName { get; set; }
        public string Description { get; set; }
       
        public string AllergInfo { get; set; }
        public byte Like { get; set; }
        public DateTime PubDate { get; set; }
        // Relationship : one to one
        public virtual string KitchenId { get; set; }
        public Kitchen Kitchen { get; set; }
         public PreperationMethod PreperationMethod { get; set; }
        public Category Category { get; set; }
        public Whose Whose { get; set; }

        //Relationship: one to more
        public List<Comment>  Comments { get; set; } = new List<Comment>();

        public ICollection<Ingredient> Ingredients { get; set; }


        public Receipt()
        {

          
            Ingredients = new List<Ingredient>();


        }
    }
    public enum Category {
        Soup, Salad, Pastries, Sandwich, Candies, Vegetarian, Fruits, Drink, Lunch, Kids, Diet
    }
    public enum Whose
    {
        Vegetarian, Kids, Diet
    }
    public enum PreperationMethod { Microwave, Oven, Grills, Easy , Fast }
}
