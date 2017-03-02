using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;


            string[] strings = { "String1", "String2", "String1", "String3", "String1", "String4", "String1", "String6", "String1" };

            Console.WriteLine("Enter, please the size of the bubble sorted array and press the \"Enter\" key.");
            Random rnd = new Random();
            int array_size = Convert.ToInt16(Console.ReadLine());
            Person[] pers_arr = new Person[array_size];
            for (int i = 0; i < array_size; i++)
            {
                pers_arr[i] = new Person(strings[rnd.Next(0, 8)], rnd.Next(5, 65));
            }
            Console.WriteLine("Enter, please the type of the elements for array you want to use.");
            Console.WriteLine("b - for array with bubble sorting; i - for array with insertion sorting");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "b":
                    {
                        BubbleSorter<Person> bubble_array = new BubbleSorter<Person>(ref pers_arr, array_size);
                        Console.WriteLine("The initial array is: ");
                        bubble_array.Print(ref pers_arr);
                        Console.WriteLine();
                        Console.WriteLine("The array sorted using the bubble sort is: ");
                        bubble_array.Sort(ref pers_arr);
                        bubble_array.Print(ref pers_arr);
                        Console.WriteLine();
                    }

                        break;
                case "i":
                    {
                        InsertionSorter<Person> insert_array = new InsertionSorter<Person>(ref pers_arr, array_size);
                        Console.WriteLine("The initial array is: ");
                        insert_array.Print(ref pers_arr);
                        Console.WriteLine();
                        Console.WriteLine("The array sorted using the bubble sort is: ");
                        insert_array.Sort(ref pers_arr);
                        insert_array.Print(ref pers_arr);
                        Console.WriteLine();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Not a valid choice.");
                        break;

                    }
            }

            Console.WriteLine("Here is the example of working with the stack.");
            Console.WriteLine("Enter, please the size of the stack and press the \"Enter\" key.");

            int stack_size = Convert.ToInt16(Console.ReadLine());
            try
            {
                MyStack<int> stack = new MyStack<int>(stack_size);
                int max_cycles = rnd.Next(1, stack_size - 1);
                for (int i = 1; i < (stack_size - max_cycles); i++)
                {
                    stack.Push(rnd.Next(1, 5000));

                }

                Console.WriteLine("The current statck condition is: ");
                stack.Print();
                var head = stack.Pop();
                Console.WriteLine("\nThe top of the stack is {0}\n", head);
                Console.WriteLine();

                head = stack.Peek();
                Console.WriteLine("Accessing the top element of the stack without deleting it: {0}\n", head);
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
            }

            int keyCode = 0, size = 0;

            Console.Write("Enter size of queue: ");
            size = Convert.ToInt16(Console.ReadLine());

            MyQueue<int> queue = new MyQueue<int>(size);
            bool semaphore = true;

            while (semaphore)
            {
                Console.WriteLine("Enter 1 for add, 2 for deletion, 3 for display, 4 for exit.");
                keyCode = Convert.ToInt16(Console.ReadLine());

                switch (keyCode)
                {
                    case 1:
                        Console.Write("Enter number: ");
                        queue.Enqueue(rnd.Next(1, 5000));
                        break;
                    case 2:
                        queue.Dequeue();
                        break;
                    case 3:
                        queue.Print();
                        break;
                    case 4:
                        semaphore = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
