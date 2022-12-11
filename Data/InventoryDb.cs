using InventoryApi.Models;
using Microsoft.EntityFrameworkCore;
namespace InventoryApi.Data
{
    public class InventoryDb : DbContext
    {
        public InventoryDb(DbContextOptions<InventoryDb> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; } //= null!;

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Item>().ToTable("Item");

        //}
    }
}
