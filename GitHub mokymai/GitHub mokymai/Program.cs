using System;
using System.Collections.Generic;

namespace GitHub_mokymai
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Sarasas = new List<string>() { "gele", "medis", "paukstis", "namas" };
            for (int i = 0; i < Sarasas.Count; i++)
            {
                Console.WriteLine(Sarasas[i]);
            }
            

        }
    }
}
