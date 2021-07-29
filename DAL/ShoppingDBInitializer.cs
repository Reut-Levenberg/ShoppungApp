using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class ShoppingDBInitializer : DropCreateDatabaseAlways<SoppingContext>
    {
        protected override void Seed(SoppingContext context)
        {
            IList<Product> defaultProducts = new List<Product>();

            defaultProducts.Add(new Product() { Category = BE.Enums.categories.Food, Name = "Milk", Id = 1, Price = 5.90 });
            defaultProducts.Add(new Product() { Category = BE.Enums.categories.Food, Name = "Bread", Id = 2, Price = 7.90 });
            defaultProducts.Add(new Product() { Category = BE.Enums.categories.Food, Name = "Eggs", Id = 3, Price = 15 });

            context.Products.AddRange(defaultProducts);


            IList<SoppingList> defaultShoppingLists = new List<SoppingList>();

            defaultShoppingLists.Add(new SoppingList { Id = 1, Products = new List<Product>() { defaultProducts[0], defaultProducts[1], defaultProducts[2] } });

            context.SoppingLists.AddRange(defaultShoppingLists);


            IList<User> defaultUsers = new List<User>();

            defaultUsers.Add(new User{ Name="Yair Cohen" , Id = 1, SoppingLists=new List<SoppingList>() { defaultShoppingLists[0] } });

            context.Users.AddRange(defaultUsers);


            base.Seed(context);
            
        }
    }
}
