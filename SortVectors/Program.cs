﻿using System;

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
                vett[i] = r.Next(-10, 11);
            }
            Ordina(vett);
            for (int i = 0; i < vett.Length; i++)
            {
                Console.Write(vett[i] + " ");
            }
            Console.ReadKey();
        }

        static void Ordina(int[] v)
        {
            Array.Sort(v);
        }
    }
}
