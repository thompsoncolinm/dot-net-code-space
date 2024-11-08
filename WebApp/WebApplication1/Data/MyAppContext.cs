// Data/MyAppContext.cs should only contain MyAppContext
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
    }
}