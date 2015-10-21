using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    class Node<T>
    {
        public T Data;
        public Node<T> Next;
    }
}
