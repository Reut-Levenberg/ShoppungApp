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
                Product milk = new Product() { category = Enums.categories.Food, name = "Milk", Id = 1, price = 5.90 };
                SoppingList sp1 = new SoppingList() { Id = 1, products = new List<Product>() { milk } };
               // User user1 = new User() { name = "Yair Cohen", soppingLists = new List<SoppingList>() { sp1 }, Id = 1 };

               // soppingContext.Users.Add(user1);
                soppingContext.Products.Add(milk);
                soppingContext.SoppingLists.Add(sp1);
                soppingContext.SaveChanges();


            }
        }

        public SoppingContext SoppingContext { get => soppingContext; set => soppingContext = value; }
    }
}
