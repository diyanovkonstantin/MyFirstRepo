using LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            bool b;
            MyList mylist = new MyList();
            mylist.AddFirst(1);
            mylist.AddFirst(2);
            mylist.AddFirst(3);
            mylist.AddLast(4);
            mylist.AddLast(5);
            mylist.AddLast(6);
            mylist.Add(7);
            mylist.Insert(6, 3);
            mylist.Remove(2);
            mylist.RemoveAt(2);
            mylist.PrintAllNodes();
            i = mylist.IndexOf(0);
            b = mylist.Contains(7);
            Console.WriteLine(b + "," + i + "  ," + mylist.Count);
            Console.ReadKey();
        }
    }
}
