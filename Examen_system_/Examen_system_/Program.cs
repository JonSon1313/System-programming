using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
namespace Examen_system_
{
    class Data
    {
        public static int[] AI;
        public static int count;
        public static int sum;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Write("n = ");
            int n = int.Parse(ReadLine());

            Write("min = ");
            int min = int.Parse(ReadLine());

            Write("max = ");
            int max = int.Parse(ReadLine());

            
            Data.AI = new int[n];

            Thread thread1 = new Thread(() => FormArray(n, min, max));
            Thread thread2 = new Thread(() => CountOdd());
            Thread thread3 = new Thread(() => Sum());
            Thread thread4 = new Thread(() => ReverseArray());
            Thread thread5 = new Thread(() => PrintArray());

            WriteLine("---- Main thread started. -----");

            
            thread1.Start();
            thread1.Join();

            thread2.Start();
            thread2.Join();

            thread3.Start();
            thread3.Join();

            thread4.Start();
            thread4.Join();

            thread5.Start();
            thread5.Join();

            WriteLine("--- Main thread finished ----");
            ReadKey();
        }

        static void FormArray(int n, int min, int max)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                Data.AI[i] = rand.Next(min, max + 1);
            }
            WriteLine("FormArray.Method => .......... Ok!");
            PrintArray();
        }

        static void CountOdd()
        {
            Data.count = 0;
            foreach (var num in Data.AI)
            {
                if (num % 2 == 0)
                {
                    Data.count++;
                }
            }
            WriteLine("CountOdd.Id = " + Thread.CurrentThread.ManagedThreadId + " =>  Ok!");
            PrintArray();
        }

        static void Sum()
        {
            Data.sum = 0;
            foreach (var num in Data.AI)
            {
                Data.sum += num;
            }
            WriteLine("Sum.Id = " + Thread.CurrentThread.ManagedThreadId + " =>  Ok!");
            PrintArray();
        }

        static void ReverseArray()
        {
            Array.Reverse(Data.AI);
            WriteLine("Array reversing => .......... Ok!");
            PrintArray();
        }

        static void PrintArray()
        {
            Write("Data.AI => ");
            foreach (var num in Data.AI)
            {
                Write(num + " ");
            }
            WriteLine();
        }
     
    }
}

