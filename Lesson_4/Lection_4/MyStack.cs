using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_4
{
    public class MyStack<T>  // The stack of elements with <T> type
    {
        private T[] items;   // The elements of the stack
        private int count;   // The number of the elements in the stack
        const int n = 15;    // The number of the elements in the stack by default
        public MyStack()
        {
            items = new T[n];
        }
        public MyStack(int length)
        {
            if (length <= 0)
                throw new InvalidOperationException("Stack can\'t be with negative size.");
            items = new T[length];
        }


        // Is stack empty
        public bool IsEmpty
        {
            get { return count == 0; }
        }

        // Is stack full
        public bool IsFull
        {
            get { return count == items.Length; }
        }

        // Stack size
        public int Count
        {
            get { return count; }
        }

        // Adding element to the top
        public void Push(T item)
        {
            // Generate the exception if stack is overflown
            if (count == items.Length)
                throw new InvalidOperationException("Stack overflow");
            items[count++] = item;
        }

        // Popping the element from the top
        public T Pop()
        {
            // Generate the exception if stack is empty
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");
            T item = items[--count];
            items[count] = default(T); // Resetting the reference
            return item;
        }
        
        // Returnuing the element from the top of the stack without deleting it
        public T Peek()
        {
            return items[count - 1];
        }

        public void Print()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                for (int i = count-1; i >= 0; i--)
                    Console.WriteLine("Item [{0:00}]\t=\t{1}" ,i, items[i]);
                Console.WriteLine();
            }
        }
    }
}
