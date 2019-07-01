using System;
using System.Collections.Generic;

namespace GenericsTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of array's elements");
            int n = Int32.Parse(Console.ReadLine());
            List<float> mylist = new List<float>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter value of element[{0}]", i);
                float a = Single.Parse(Console.ReadLine());
                mylist.Add(a);
            }
            Console.WriteLine("How many numbers b would you like to insert?");
            int m = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Enter value of number b");
                float b = Single.Parse(Console.ReadLine());
                for (int j = 0; j < mylist.Count; j++)
                {
                    if (b < mylist[j])
                    {
                        mylist.Insert(j, b);
                        break;
                    }
                    else
                    {
                        if (j == mylist.Count - 1)
                        {
                            mylist.Add(b);
                            break;
                        }
                    }
                }
            }
           
            foreach (float f in mylist)
                Console.WriteLine(f);
            Console.ReadLine();
        }
    }
}
