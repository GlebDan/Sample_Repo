using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_6
{
    public class MyStack<T>: Buffer<T> // The stack of elements with <T> type
    {
        const int n = 15;    // The number of the elements in the stack by default


        public MyStack()
        {
            array = new T[n];
            length = n;
        }
        public MyStack(int length)
        {
            if (length <= 0)
                throw new InvalidOperationException("Stack can\'t be with negative size.");
            array = new T[length];
            this.length = length;
        }

        // Adding element to the top
        public void Push(T item)
        {
            // Generate the exception if stack is overflown
            if (IsFull)
                throw new InvalidOperationException("Stack overflow");
            array[count++] = item;
        }

        // Popping the element from the top
        public T Pop()
        {
            // Generate the exception if stack is empty
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");
            T item = array[--count];
            array[count] = default(T); // Resetting the reference
            return item;
        }

        // Returnuing the element from the top of the stack without deleting it
        public T Peek()
        {
            return array[count - 1];
        }

        public override void Print()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                for (int i = count - 1; i >= 0; i--)
                    Console.WriteLine("Item [{0:00}]\t=\t{1}", i, array[i]);
                Console.WriteLine();
            }
        }
    }
}
