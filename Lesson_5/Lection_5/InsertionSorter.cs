﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_5
{
    public class InsertionSorter: Sorter
    {
        public InsertionSorter(int size)
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
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int j = i + 1;
                while (j > 0)
                {
                    if (arr[j - 1] > arr[j])
                        Swap(j - 1, j, ref arr);
                    j--;
                }
            }
        }
    }
}
