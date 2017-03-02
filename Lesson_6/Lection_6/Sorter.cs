using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_6
{
    public abstract class Sorter<T>: ISorter<T>
    {
        protected T[] massiv;

        public void Print(ref T[] massiv)
        {
            Console.Write('[');
            for (int i=0;i<massiv.Length; i++)
            {
                Console.Write(massiv[i]+", ");
            }
            Console.WriteLine(']');
            Console.WriteLine();
        }

        public void Swap(int from, int to, ref T[] massiv)
        {
            T temp = massiv[from];
            massiv[from] = massiv[to];
            massiv[to] = temp;
        }

        public abstract void Sort(ref T[] massiv);
    }
}
