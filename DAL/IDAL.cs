using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public interface IDAL
    {
        void addProduct(Product product);
        void updataProduct(int Id);
        void addShoppingList(SoppingList soppingList);
        void updataShoppingList(int Id);
        List<SoppingList> allShoppingList();
        void addUser(User user);
        void updataUser(int Id);
        void addStore(store store);
        void addPurchase(Purchase purchase);
        List<Purchase> allPurchase();
    }
}
