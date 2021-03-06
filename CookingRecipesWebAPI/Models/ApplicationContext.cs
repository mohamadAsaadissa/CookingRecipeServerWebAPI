using Microsoft.EntityFrameworkCore;


namespace CookingRecipesWebAPI.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
       
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Comment>  Comments { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
            Database.EnsureCreated();
        }
    }
}
