using CookingRecipesWebAPI;
using CookingRecipesWebAPI.Models;
using System;
using System.Linq;

namespace CookingRecipesWebAPI.Models
{
    public static class SampleData
    {
        public static void Initialize(ApplicationContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Name = "Moh", Access=true, Email="axx@gmail.com",
                        PubDate=DateTime.Parse("12/02/2020"), Tel="1212121",
                        Pass = "WwSS323", UserId="0001"

                    },
                     new User
                     {
                         UserId = "0002",
                         Name = "Ahm",
                         Access = true,
                         Email = "bxx@gmail.com",
                         PubDate = DateTime.Parse("02/02/2020"), 
                         Tel = "5235235523",  Pass="WwSS323"
                     }
                );
                context.SaveChanges();
            }

            
            if (!context.Kitchens.Any())
            {
                context.Kitchens.AddRange(
                    new Kitchen
                    {
                        Country="Maroca", Summary="", KitchenId="12123", 
                       
                    },
                     new Kitchen
                     {
                         Country = "Emarate", KitchenId="23123",
                         Summary = ""
                     }
                ); ; 
                context.SaveChanges();
            }
            if (!context.Receipts.Any())
            {
                context.Receipts.AddRange(
                    new Receipt
                    {
                         Title="Basal bela ban", Summary="", ReceiptId="0111"
                    },
                     new Receipt
                     {
                         Title = "Bandora neya bela ban", ReceiptId="2300",
                         Summary = ""
                     }
                ); ;
                context.SaveChanges();
            }
            if (!context.Dishs.Any())
            {
                context.Dishs.AddRange(
                    new Dish
                    {
                        KitchenId = "12123",
                        ReceiptId = "0111",
                        Like = 0,
                        DishId = "0220",
                        PubDate = DateTime.Now,
                        Title = "Havisa sookar",
                        summary = "xvxcxvxcvxvxvxxv"
                    },
                     new Dish
                     {
                         KitchenId = "23123",
                         ReceiptId = "2300", Like=0, DishId="0220", PubDate=DateTime.Now,  Title="Mama spaah", summary="gsdfe36534653636"
                     }
                ); ;
                context.SaveChanges();
            }
        }

    }
}

//entityframeworkcore.sqlserver
//entityframeworkcore.tools
//models
//appcontext
//sampaledata
//appsetting
// scope.ServiceProvider
//Configuration.GetConnectionString("DefaultConnection");
