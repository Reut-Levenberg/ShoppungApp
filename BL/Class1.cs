using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace BL
{
    public class Class1
    {
        AssociationRules a;
        LocalDBDAL dBDAL = new LocalDBDAL();

        public void dddd()
        {
            try { 

            a = new AssociationRules();
            double minSupportPct = 0.30;
            int minItemSetLength = 2;
            int maxItemSetLength = 2;
            List<int[]> transactions = new List<int[]>();

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
            int l = 0;
            
            foreach(List<int> p in ProductList)
                {
                    int[] temp=new int[p.Count()];
                    foreach (int pp in p)
                    { 
                        temp[l] = pp;
                    }
                    transactions.Add(temp);
                    l++;
                }
            

            int N = dBDAL.allShoppingList().Count();
            List<ItemSet> frequentItemSets =
                AssociationRules.GetFrequentItemSets(N, transactions, minSupportPct,
                minItemSetLength, maxItemSetLength);
            Console.WriteLine("\nFrequent item-sets in numeric form are:");
            for (int i = 0; i < frequentItemSets.Count; ++i)
                Console.WriteLine(frequentItemSets[i].ToString());
            Console.WriteLine("\nFrequent item-sets in string form are:");
            for (int i = 0; i < frequentItemSets.Count; ++i)
            {
                for (int j = 0; j < frequentItemSets[i].data.Length; ++j)
                {
                    int v = frequentItemSets[i].data[j];
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\nEnd frequent item-set extraction demo\n");
            Console.ReadLine();
                    }
                    catch (Exception ex)
            {
                Console.WriteLine(ex.Message); Console.ReadLine();
            }
        }
    }
}
