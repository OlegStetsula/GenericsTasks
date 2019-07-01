using System;
using System.Collections.Generic;

namespace GenericsTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of chars");
            int n = Int32.Parse(Console.ReadLine());
            List<char> Charlist = new List<char>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter char {0}", i);
                char a = Convert.ToChar(Console.ReadLine());
                Charlist.Add(a);
            }
            List<char> TempList = new List<char>();
            foreach (var i in Charlist)
            {
                if (TempList.Contains(i))
                    continue;
                else
                    TempList.Add(i);
            }
            Console.WriteLine("Sequence of chars has {0} different chars", TempList.Count);


            for (int i = 0; i < Charlist.Count; i++)
            {
                if (Charlist[i] == '!')
                    Charlist[i] = '.';
            }
            Charlist.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
