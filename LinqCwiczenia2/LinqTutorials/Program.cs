﻿using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            var t = LinqTasks.Task1();
            foreach(var i in t)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Task 2:");
            var t2 = LinqTasks.Task2();
            foreach (var i in t2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Task 3:");
            var t3 = LinqTasks.Task3();
            Console.WriteLine(t3);

            Console.WriteLine("Task 4:");
            var t4 = LinqTasks.Task4();
            foreach (var i in t4)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Task 5:");
            var t5 = LinqTasks.Task5();
            foreach (var i in t5)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Task 6:");
            var t6 = LinqTasks.Task6();
            foreach (var i in t6)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Task 7:");
            var t7 = LinqTasks.Task7();
            foreach (var i in t7)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Task 8:");
            var t8 = LinqTasks.Task8();
            Console.WriteLine(t8);


            Console.WriteLine("Task 9:");
            var t9 = LinqTasks.Task9();
            Console.WriteLine(t9);


            Console.WriteLine("Task 10:");
            var t10 = LinqTasks.Task10();
            foreach (var i in t10)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Task 11:");
            var t11 = LinqTasks.Task11();
            foreach (var i in t11)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Task 12:");
            var t12 = LinqTasks.Task12();
            foreach (var i in t12)
            {
                Console.WriteLine(i);
            }

            int[] x = new int[] { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 };
            Console.WriteLine("Task 13:");
            var t13 = LinqTasks.Task13(x);
            Console.WriteLine(t13);

            Console.WriteLine("Task 14:");
            var t14 = LinqTasks.Task14();
            foreach (var i in t14)
            {
                Console.WriteLine(i);
            }
        }
    }
}
