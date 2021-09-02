using System;
using System.Text;

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

            int[] m1 = new int[n];
            int[] m2 = new int[n];
            string[] cm1 = new string[n];
            string[] cm2 = new string[n];
            for (int i = 0; i < n; i++)
            {
                if (randomarray[i] % 2 == 0)
                {
                    m1[i] = randomarray[i];
                }
                else
                {
                    m2[i] = randomarray[i];
                }
            }

            Console.WriteLine();
            foreach (int i in m1)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            foreach (int i in m2)
            {
                Console.Write($"{i} ");
            }

            string[] alph = { " ", "A", "b", "c", "D", "E", "f", "g", "H", "I", "J", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            for (int i = 0; i < n; i++)
            {
                cm1[i] = (string)alph[m1[i]];
            }

            StringBuilder line1 = new StringBuilder();
            for (int i = 0; i < cm1.Length; i++)
            {
                if (cm1[i] == " ")
                {
                    continue;
                }

                line1.Append(cm1[i]);
                if (i != cm1.Length - 1)
                {
                    line1.Append(' ');
                }
            }

            Console.WriteLine();
            Console.WriteLine(line1.ToString());
            for (int i = 0; i < n; i++)
            {
                cm2[i] = (string)alph[m2[i]];
            }

            StringBuilder line2 = new StringBuilder();
            for (int i = 0; i < cm2.Length; i++)
            {
                if (cm2[i] == " ")
                {
                    continue;
                }

                line2.Append(cm2[i]);
                if (i != cm2.Length - 1)
                {
                    line2.Append(' ');
                }
            }

            Console.WriteLine(line2.ToString());
            Console.ReadKey();
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
