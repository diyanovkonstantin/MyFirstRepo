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
            Node<int> n1 = new Node<int> { Data = 10, Next = null };
            Node<int> n2 = new Node<int> { Data = 2, Next = null };
            MyList<int> mylist = new MyList<int>();
            mylist.AddFirst(n1);
            mylist.AddFirst(n2);
        }
    }
}
