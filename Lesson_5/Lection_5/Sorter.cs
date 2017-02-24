using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_5
{
    public class Sorter
    {
        protected int[] arr;

        public void Print()
        {
            Console.Write('[');
            foreach (int item in arr)
            {
                Console.Write("{0}, ", item);
            }
            Console.WriteLine(']');
            Console.WriteLine();
        }

        protected void Swap(int from, int to, ref int[] massiv)
        {
            int temp = massiv[from];
            massiv[from] = massiv[to];
            massiv[to] = temp;
        }

        public virtual void Sort()
        {

        }
    }
}
