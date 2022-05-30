using System;

namespace MnozenieMacierzy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę wierszy macierzy A: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę kolumn macierzy B: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę kolumn macierzy A oraz wierszy macierzy B: ");
            int k = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[n, k];

            int m1 = 0;
            int k1 = 0;
            int n1 = 0;

            Console.WriteLine("Podaj elementy macierzy A.");

            while (n1 < n)
            {
                while (k1 < k)
                {
                    Console.Write("A[" + (n1 + 1) + "," + (k1 + 1) + "] = ");
                    A[n1, k1] = Convert.ToInt32(Console.ReadLine());
                    k1++;
                }

                n1++;
                k1 = 0;

            }

            int[,] B = new int[k, m];

            Console.WriteLine("Podaj elementy macierzy B.");

            while (k1 < k)
            {
                while (m1 < m)
                {
                    Console.Write("B[" + (k1 + 1) + "," + (m1 + 1) + "] = ");
                    B[k1, m1] = Convert.ToInt32(Console.ReadLine());
                    m1++;
                }

                k1++;
                m1 = 0;

            }

            int[,] C = new int[n, m];




            Console.ReadLine();
        }
    }
}
