using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_5
{
    public class Buffer<T>
    {
        protected T[] array;   // The elements of the stack
        protected int count, length;   // The number of the elements in the stack

        public int Size
        {
            get { return length; }
        }

        public int Count
        {
            get { return count; }
        }


        protected bool IsEmpty
        {
            get { return count == 0; }
        }

        protected bool IsFull
        {
            get { return count == array.Length; }
        }

        public virtual void Print()
        {

        }

    }
}
