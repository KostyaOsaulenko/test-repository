using System;

namespace App4
{
    /// <summary>
    /// Start point of general app.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Start  of general app.
        /// </summary>
        /// <param name="args">args added via console.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] randomarray = new int[n];
            randomarray = GetRandomeArray(n, 1, 26);
            foreach (int i in randomarray)
            {
                Console.Write($"{i} ");
            }

            static int[] GetRandomeArray(int size, int min, int max)
            {
                var r = new Random();
                int[] arr = new int[size];
                for (int i = 0; i < size; i++)
                {
                    arr[i] = r.Next(min, max + 1);
                }

                return arr;
            }
        }
    }
}
