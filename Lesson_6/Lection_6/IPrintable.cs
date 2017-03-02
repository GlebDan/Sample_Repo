using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_6
{
    public interface IPrintable<T>
    {
        void Print(ref T [] p);
    }
}
