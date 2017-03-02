using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_6
{
    public class BubbleSorter<T>: Sorter<T> where T:IComparable
    {
        private int size;
        public BubbleSorter(ref T[] massiv, int sz)
        {
            size= sz;
        }


        public override void Sort(ref T[] massiv)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 1 - i; j++)
                {
                    if (massiv[j].CompareTo(massiv[j + 1])==-1)
                        Swap(j, j + 1, ref massiv);
                }
            }
        }
    }
}
