using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.Entity;

namespace DAL
{
    public class LocalDBDAL:IDAL
    {
        SoppingContext context;

        public LocalDBDAL()
        {
            context = new SoppingContext();
        }

        public void addProduct(Product product) 
        {
            using (context)
            {
                context.Products.Add(product);
                context.SaveChanges();
            }

        }
        public void updataProduct(int Id) { }
        public void addShoppingList(SoppingList soppingList) 
        {
            using (context)
            {
                context.SoppingLists.Add(soppingList);
                context.SaveChanges();
            }
        }
        public void updataShoppingList(int Id) { }
        public List<SoppingList> allShoppingList() 
        {
            List<SoppingList> soppingLists = new List<SoppingList>();
            using (context)
            {
                var query = from s in context.SoppingLists
                            select s;

                foreach (var s in query)
                    soppingLists.Add(s);
            }

            return soppingLists;
            
        }

        public void addUser(User user) 
        {
            using (context)
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
        public void updataUser(int Id) { }
        public void addStore(store store) 
        {
            using (context)
            {
                context.stores.Add(store);
                context.SaveChanges();
            }
        }
        public void addPurchase(Purchase purchase ) 
        {
            using (context)
            {
                context.Purchases.Add(purchase);
                context.SaveChanges();
            }
        }

        public List<Purchase> allPurchase()
        {
            List<Purchase> Purchases = new List<Purchase>();
            using (context)
            {
                var query = from s in context.Purchases
                            select s;

                foreach (var s in query)
                    Purchases.Add(s);
            }

            return Purchases;

        }
    }
}
