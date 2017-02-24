using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_5
{
    public class BubbleSorter: Sorter
    {
        public BubbleSorter(int size)
        {
            if (size <= 0)
                throw new InvalidOperationException("The array size can\'t be negative");
            arr = new int[size];
            //            Console.WriteLine("Please, enter each element of the array following by the Enter key");
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(1, 5000); //Convert.ToInt16(Console.ReadLine());
            }
        }

        public override void Sort()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                        Swap(j, j + 1, ref arr);
                }
            }
        }
    }
}
