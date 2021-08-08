using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ItemSet
    {
        public int N; // data items are [0..N-1]
        public int k; // number of items
        public int[] data; // ex: [0 2 5]
        public int hashValue; // "0 2 5" -> 520 (for hashing)
        public int ct; // num times this occurs in transactions
        public ItemSet(int N, int[] items, int ct) 
        {
            this.N = N;
            this.k = items.Length;
            this.data = new int[this.k];
            Array.Copy(items, this.data, items.Length);
            this.hashValue = ComputeHashValue(items);
            this.ct = ct;
        }
        private static int ComputeHashValue(int[] data) 
        {
            int value = 0;
            int multiplier = 1;
            for (int i = 0; i < data.Length; ++i)
            {
                value = value + (data[i] * multiplier);
                multiplier = multiplier * 10;
            }
            return value;
        }
        public override string ToString() 
        {
            string s = "{ ";
            for (int i = 0; i < data.Length; ++i)
                s += data[i] + " ";
            return s + "}" + "   ct = " + ct; ;
        }
        public bool IsSubsetOf(int[] trans)
        {
            int foundIdx = -1;
            for (int j = 0; j < this.data.Length; ++j)
            {
                foundIdx = IndexOf(trans, this.data[j], foundIdx + 1);
                if (foundIdx == -1) return false;
            }
            return true;
        }
        private static int IndexOf(int[] array, int item, int startIdx) 
        {
            for (int i = startIdx; i < array.Length; ++i)
            {
                if (i > item) return -1; // i is past target loc
                if (array[i] == item) return i;
            }
            return -1;
        }
    }
}
