using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace BL
{
    class AssociationRules
    {
        List<List<int>> transactions = new List<List<int>>();
        LocalDBDAL dBDAL = new LocalDBDAL();
        double minSupportPct = 0.30;
        int minItemSetLength = 2;
        int maxItemSetLength = 4;


        public AssociationRules()
        {
            List<List<int>> ProductList = new List<List<int>>();
            List<SoppingList> allShoppingList = dBDAL.allShoppingList();
            foreach (SoppingList i in allShoppingList)
            {
                List<int> productID = new List<int>();
                foreach (Product p in i.products)
                {
                    productID.Add(p.Id);
                }

                ProductList.Add(productID);
            }

            transactions = ProductList;
        }


        static List<ItemSet> GetFrequentItemSets(int N, List<int[]> transactions,
  double minSupportPct, int minItemSetLength, int maxItemSetLength)
        {
        }
    
}
