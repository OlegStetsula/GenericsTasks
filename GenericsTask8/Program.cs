using System;
using System.Collections.Generic;

namespace GenericsTask8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of array's elements");
            int n = Int32.Parse(Console.ReadLine());
            List<int> mylist = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter value of element[{0}]", i);
                int a = Int32.Parse(Console.ReadLine());
                mylist.Add(a);
            }
            int avgIndex = mylist.Count / 2;
            int avgValue = mylist[avgIndex];
            //List<int> less = new List<int>();
            //List<int> more = new List<int>();
            //List<int> equil = new List<int>();
            //for (int i = 0; i < mylist.Count; i++)
            //{
            //    if (mylist[i] < avgValue)
            //        less.Add(mylist[i]);
            //    if (mylist[i] > avgValue)
            //        more.Add(mylist[i]);
            //    if (mylist[i] == avgValue)
            //        equil.Add(mylist[i]);
            //}
            //mylist.Clear();
            //mylist.AddRange(less);
            //mylist.AddRange(equil);
            //mylist.AddRange(more);
            List<int> NewList = new List<int>();
            NewList.Add(avgValue);
            int index = 0;
            for (int i = 0; i < mylist.Count; i++)
            {
                if (mylist[i] > avgValue)
                    NewList.Add(mylist[i]);
                if (mylist[i] < avgValue)
                {
                    NewList.Insert(0, mylist[i]);
                    index++;
                }
                if (mylist[i] < avgValue)
                    NewList.Insert(index+1, mylist[i]);
            }
            mylist.Clear();
            mylist.AddRange(NewList);
            Console.WriteLine("AvgValue = {0}", avgValue);
            mylist.ForEach(Console.WriteLine);
            Console.ReadLine();

        }
    }
}
