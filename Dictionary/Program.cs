using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dictionarys = new Dictionary<int, string>();
            dictionarys.Add(36,"Ahmet");
            dictionarys.Add(21,"Mehmet");
            dictionarys.Add(30,"Nuri");
            dictionarys.Add(34,"Murat");
            dictionarys.Add(28,"Funda");

            foreach (var dictionary in dictionarys)
            {
                Console.WriteLine("Yaşı " + dictionary.Key + " Adı = " + dictionary.Value);
            }
        }


    }
}
