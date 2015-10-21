using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MyList<int> mylist = new MyList<int>();
            mylist.AddFirst(1);
            mylist.AddFirst(2);
        }
    }
}
