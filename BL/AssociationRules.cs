using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;


namespace BL
{
    public class AssociationRules
    {
        List<List<int>> transactions = new List<List<int>>();
        LocalDBDAL dBDAL = new LocalDBDAL();



        public static List<ItemSet> GetFrequentItemSets(int N, List<int[]> transactions, double minSupportPct, int minItemSetLength, int maxItemSetLength)
        {
            int minSupportCount = (int)(transactions.Count * minSupportPct);
            Dictionary<int, bool> frequentDict = new Dictionary<int, bool>();
            List<ItemSet> frequentList = new List<ItemSet>();
            List<int> validItems = new List<int>();
            List<ItemSet> result = new List<ItemSet>();
            int[] counts = new int[N];
            for (int i = 0; i < transactions.Count; ++i)
            {
                for (int j = 0; j < transactions[i].Count(); ++j)
                {
                    int v = transactions[i][j];
                    ++counts[v];
                }
            }
            for (int i = 0; i < counts.Length; ++i)
            {
                if (counts[i] >= minSupportCount)
                {
                    validItems.Add(i); // i is the item-value
                    int[] d = new int[1]; // ItemSet ctor wants an array
                    d[0] = i;
                    ItemSet ci = new ItemSet(N, d, 1); // size 1, ct 1
                    frequentList.Add(ci); // it's frequent
                    frequentDict.Add(ci.hashValue, true); // record
                } // else skip this item
            }
            bool done = false;
            for (int k = 2; k <= maxItemSetLength && done == false; ++k)
            {
                done = true;
                int numFreq = frequentList.Count;
                for (int i = 0; i < numFreq; ++i)
                {
                    if (frequentList[i].k != k - 1)
                        continue;
                    for (int j = 0; j < validItems.Count; ++j)
                    {
                        int[] newData = new int[k]; // data for a candidate item-set
                        for (int p = 0; p < k - 1; ++p)
                            newData[p] = frequentList[i].data[p];
                        if (validItems[j] <= newData[k - 2])
                            continue;
                        newData[k - 1] = validItems[j];
                        ItemSet ci = new ItemSet(N, newData, -1);
                        if (frequentDict.ContainsKey(ci.hashValue) == true)
                            continue;
                        int ct = CountTimesInTransactions(ci, transactions);
                        if (ct >= minSupportCount)
                        {
                            ci.ct = ct;
                            frequentList.Add(ci);
                            frequentDict.Add(ci.hashValue, true);
                            done = false;
                        }
                    } // j
                } // i
                validItems.Clear();
                Dictionary<int, bool> validDict = new Dictionary<int, bool>();
                for (int idx = 0; idx < frequentList.Count; ++idx)
                {
                    if (frequentList[idx].k != k)
                        continue;
                    for (int j = 0; j < frequentList[idx].data.Length; ++j)
                    {
                        int v = frequentList[idx].data[j]; // item
                        if (validDict.ContainsKey(v) == false)
                        {
                            validItems.Add(v);
                            validDict.Add(v, true);
                        }
                    }
                }
                validItems.Sort();
            } // next k

            if (frequentList.Count != 0)
            {
                for (int i = 0; i < frequentList.Count; ++i)
                {
                    if (frequentList[i].k >= minItemSetLength)
                        result.Add(new ItemSet(frequentList[i].N,
                          frequentList[i].data, frequentList[i].ct));
                }
                return result;
            }

            else
                return null;

        }


        public static int CountTimesInTransactions(ItemSet itemSet, List<int[]> transactions)
        {
            int ct = 0;
            for (int i = 0; i < transactions.Count; ++i)
            {
                if (itemSet.IsSubsetOf(transactions[i]) == true)
                    ++ct;
            }
            return ct;
        }
    }
}
