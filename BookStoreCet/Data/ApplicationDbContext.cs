using BookStoreCet.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStoreCet.Data;

public class MyDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(
            "Server=(local);Database=BookStoreDb2;User ID=sa;Password=Aa123456;MultipleActiveResultSets=true;Trust Server Certificate = true");
    }
}

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Publisher> Publisher { get; set; }
    public DbSet<Category> Category { get; set; }
    


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
        
    }
}