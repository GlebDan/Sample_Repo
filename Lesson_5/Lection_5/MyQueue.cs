using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_5
{
    public class MyQueue<T>: Buffer<T>
    {
        private int head, tail;
        public MyQueue(int sz)
        {
            head = tail = 0;
            length = sz;
            array = new T[sz];
            count = 0;
        }

        public void Enqueue(T item)
        {
            if (IsFull)
            {
                Console.WriteLine("Queue is full");
                return;
            }
            {
                array[head] = item;
                head = (head + 1) % length;
                count++;
            }

        }

        public T Dequeue()
        {
            T element;
            if (IsEmpty)
            {
                Console.WriteLine("Queue is empty");
            }
            {
                element = array[tail];
                array[tail] = default(T);
                tail = (tail + 1) % length;
                count--;
                return element;
            }
        }

        public override void Print()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    if (i == tail && i == head)
                    {
                        Console.WriteLine("Item [{0:00}] = {1}\t\t<----tail  <----head", i, array[i]);
                    }
                    else if (i == head)
                    {
                        Console.WriteLine("Item [{0:00}] = {1}\t\t<----head", i, array[i]);
                    }
                    else if (i == tail)
                    {
                        Console.WriteLine("Item [{0:00}] = {1}\t\t<----tail", i, array[i]);
                    }
                    else
                        Console.WriteLine("Item [{0:00}] = {1}", i, array[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
