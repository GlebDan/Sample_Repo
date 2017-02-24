using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_4
{
    public class MyQueue<T>
    {
        private int head, tail, size, count;
        private T[] array;
        public MyQueue(int sz)
        {
            head = tail = 0;
            size = sz;
            array = new T[sz];
            count = 0;
        }

        public int Size { get { return size; } }

        public void Enqueue(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
                return;
            }
            {
                array[head] = item;
                head = (head+1)%size;
                count++;
            }
            
        }

        public T Dequeue()
        {
            T element;
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
            }
            {
                element = array[tail];
                array[tail] = default(T);
                tail = (tail + 1) % size;
                count--;
                return element;
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                for (int i = 0; i < size; i++)
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

        public bool IsEmpty()
        {
            return (count == 0);
        }
        public bool IsFull()
        {
            return (count == size+1);
        }
    }





}
