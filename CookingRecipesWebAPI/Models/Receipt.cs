using CookingRecipesWebAPI.Models;
using System;
using System.Collections.Generic;

namespace CookingRecipesWebAPI
{
    public class Receipt
    {

        public string ReceiptId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string ImageLink{ get; set; }
        public string VideoLink{ get; set; }
        public string Description { get; set; }
       
        public string AllergInfo { get; set; }
        public byte Like { get; set; }
        public DateTime PubDate { get; set; }
        // Relationship : one to one
        public string Country { get; set; }
        public Kitchen Kitchen { get; set; }

         public PreperationMethod PreperationMethod { get; set; }
        public Category Category { get; set; }
        

        //Relationship: one to more
        public List<Comment>  Comments { get; set; } = new List<Comment>();

        public ICollection<Ingredient> Ingredients { get; set; }


        public Receipt()
        {          
            Ingredients = new List<Ingredient>();

        }
    }
    public enum Category {
        Soup, Salad, Pastries, Sandwich, Candies, Vegetarian, Fruits, Drink, Lunch, Kids, Diet,Dessert
    }
    public enum Kitchen
    {
        Natural, Vegetarian, Kids, Diet
    }
    public enum PreperationMethod { Microwave, Oven, Grills, Easy , Fast }
}
