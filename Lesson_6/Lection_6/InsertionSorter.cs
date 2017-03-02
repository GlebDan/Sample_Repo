using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_6
{
    public class InsertionSorter<T>: Sorter<T> where T: IComparable
    {

        private int size;
        public InsertionSorter(ref T[] massiv, int sz)
        {
            size = sz;
        }
    

    public override void Sort(ref T[] massiv)
        {
            for (int i = 0; i < massiv.Length - 1; i++)
            {
                int j = i + 1;
                while (j > 0)
                {
                    if (massiv[j-1].CompareTo(massiv[j])==1)
                        Swap(j - 1, j, ref massiv);
                    j--;
                }
            }
        }
    }
}
