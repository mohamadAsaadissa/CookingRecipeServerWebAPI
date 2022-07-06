using Microsoft.EntityFrameworkCore;


namespace CookingRecipesWebAPI.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Dish> Dishs { get; set; }
        public DbSet<ExtraInfo> ExtraInfos { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Kitchen> Kitchens { get; set; }

        public ApplicationContext()
        {

        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
