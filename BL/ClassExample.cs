using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL;
using BE;

namespace BL
{
    public class ClassExample
    {
        SoppingContext soppingContext;

        public ClassExample() 
        {
            soppingContext = new SoppingContext();
            using (soppingContext)
            {
                Product milk = new Product() { Category = Enums.categories.Food, Name = "Milk", Id = 1, Price = 5.90 };
                SoppingList sp1 = new SoppingList() { Id = 1, Products = new List<Product>() { milk } };
                User user1 = new User() { Name = "Yair Cohen", SoppingLists = new List<SoppingList>() { sp1 }, Id = 1 };

                soppingContext.Users.Add(user1);
                soppingContext.Products.Add(milk);
                soppingContext.SoppingLists.Add(sp1);
                soppingContext.SaveChanges();


            }
        }

        public SoppingContext SoppingContext { get => soppingContext; set => soppingContext = value; }
    }
}
