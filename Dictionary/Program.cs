using System;
using System.Collections.Generic;

namespace GenericIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, string> authors = new MyDictionary<string, string>();
            authors.Add("Balzac", "Vadideki Zambak");
            authors.Add("Lev Tolstoy", "Savaş ve Barış");
            authors.Add("Fyodor Dostoyevski", "Suç ve Ceza");
            authors.Add("Stefan Zweig", "Satranç");
            authors.Add("Victor Hugo", "Sefiller");


            for (int i = 0; i < authors.Keys.Length; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}", authors.Keys[i], authors.Values[i]);

            }
           





        }
    }
}