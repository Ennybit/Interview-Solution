using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class Task
        {
            public void Task1()
            {
                string name = "John Doe";
                int age = 25;
                bool isAdmin = true;
                Console.WriteLine(name);
                Console.WriteLine(age);
                Console.WriteLine(isAdmin);
            }
            public string Task2(int num)
            {
                if (num % 2 == 0)
                {
                    return "odd";
                }
                else
                {
                    return "even";
                }

            }
            public void Task3()
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
            }

            public void Task4()
            {
                int[] array1 = { 2, 4, 6, 8, 10 };
                Console.WriteLine("Array sum is = " + array1.Sum());

                foreach (var item in array1)
                {
                    Console.WriteLine(item);
                }
            }

            public string Greet(string name)
            {
                return $"Hello, {name}!";
            }
        }

        static void Main(string[] args)
        {
            Task trt = new Task();
            trt.Task1();
            Console.WriteLine(trt.Task2(4));
            trt.Task3();
            trt.Task4();
            Console.WriteLine(trt.Greet("alice"));
        }
    }
}
