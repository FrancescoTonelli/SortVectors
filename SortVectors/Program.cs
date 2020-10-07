using System;

namespace SortVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vett = new int[10];
            Random r = new Random();
            for(int i = 0; i < vett.Length; i++)
            {
                vett[i] = r.Next(0, 11);
                Console.Write(vett[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
