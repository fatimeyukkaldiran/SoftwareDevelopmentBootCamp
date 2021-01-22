using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "seren", "deniz", "barış"};
            Console.WriteLine(names[0]);
            names = new string[5]; //farklı adreste boş bir array oluştu, names arrayi farklı bir referansı gösteriyor

            List<string> names2 = new List<string> { "Sena", "Kaya", "lale", "melek" };
            
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);

            names2.Add("Fatime");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);








        }
    }
}
