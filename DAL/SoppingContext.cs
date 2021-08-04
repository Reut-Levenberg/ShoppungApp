using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class SoppingContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<SoppingList> SoppingLists { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<store> stores { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        
        public SoppingContext() : base("ShoppindDB")
        {
            Database.SetInitializer(new ShoppingDBInitializer());
        }

    }
}
