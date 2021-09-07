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
            int n = 0;
            do
            {
                Console.WriteLine("Please enter size of array");
                string input = Console.ReadLine();
                int digit;
                if (int.TryParse(input, out digit))
                {
                    n = Convert.ToInt32(input);
                }
                else
                {
                    Console.WriteLine("error input");
                }
            }
            while (n == 0);
            int[] randomarray = new int[n];
            randomarray = GetRandomeArray(n, 1, 26);
            foreach (int i in randomarray)
            {
                Console.Write($"{i} ");
            }

            int[] m1 = new int[n];
            int[] m2 = new int[n];
            string[] cm2 = new string[n];
            int m1_hei = 0;
            int m2_hei = 0;
            for (int i = 0; i < n; i++)
            {
                if (randomarray[i] % 2 == 0)
                {
                    m1[i] = randomarray[i];
                    m1_hei++;
                }
                else
                {
                    m2[i] = randomarray[i];
                    m2_hei++;
                }
            }

            Console.WriteLine();
            if (m1_hei > m2_hei)
            {
                Console.WriteLine("the first array will have more uppercase letters");
            }
            else if (m1_hei < m2_hei)
            {
                Console.WriteLine("the second array will have more uppercase letters");
            }
            else
            {
                Console.WriteLine("both arrays have equal number of uppercase letters");
            }

            StringBuilder line1 = Replacement(m1, n);
            StringBuilder line2 = Replacement(m2, n);
            Console.WriteLine(line1.ToString());
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

            static StringBuilder Replacement(int[] m,  int n)
            {
                string[] cm = new string[n];
                string[] alph = { " ", "A", "b", "c", "D", "E", "f", "g", "H", "I", "J", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
                for (int i = 0; i < n; i++)
                {
                    cm[i] = (string)alph[m[i]];
                }

                StringBuilder line = new StringBuilder();
                for (int i = 0; i < cm.Length; i++)
                {
                    if (cm[i] == " ")
                    {
                        continue;
                    }

                    line.Append(cm[i]);
                    if (i != cm.Length - 1)
                    {
                        line.Append(' ');
                    }
                }

                return line;
            }
        }
    }
}
