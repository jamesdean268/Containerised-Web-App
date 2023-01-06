using Microsoft.EntityFrameworkCore;

// ------ LEARNING CODE ADDITION ------
// Add the database context
public class ItemContext : DbContext
{
    public ItemContext(DbContextOptions<ItemContext> options)
        : base(options)
    {
    }

    public DbSet<Item> Items { get; set; }
}
