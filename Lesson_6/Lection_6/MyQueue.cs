using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_6
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
                        Console.Write("Item [{0:00}] = {1}", i, array[i]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\t\t<----tail");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("  <----head");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    else if (i == head)
                    {
                        Console.Write("Item [{0:00}] = ", i);
                        Console.Write(array[i]);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\t<----head");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                    }
                    else if (i == tail)
                    {
                        Console.Write("Item [{0:00}] = ", i);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(array[i]);
                        Console.Write("\t\t<----tail");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                    }
                    else
                        Console.WriteLine("Item [{0:00}] = {1}", i, array[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
