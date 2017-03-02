using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_6
{
    public  interface ISorter<T>: IPrintable<T>
    {
        void Sort(ref T[] massiv);
        void Swap(int from, int to, ref T[] massiv);
    }
}
