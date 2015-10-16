using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class Node
    {
        public Node next;
        public Object data;
    }


    public class MyList : IList
    {
        private Node head;

        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void AddFirst(Object data)
        {
            Node toAdd = new Node();
            toAdd.data = data;
            toAdd.next = head;
            head = toAdd;
        }
        public void AddLast(Object data)
        {
            if (head == null)
            {
                head = new Node();
                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = toAdd;
            }
        }

        public int Add(object value)
        {
            this.AddFirst(value);
            return 1;
        }

        public void Clear()
        {
            head = null;
        }

        public bool Contains(object value)
        {
            Node current = new Node();
            current = head;
            while (current != null)
            {
                if (Object.Equals(current.data, value))
                {
                    return true;
                }

                current = current.next;
            }
            return false;
        }

        public int IndexOf(object value)
        {
            int i = 0;
            Node current = head;
            while (current != null)
            {
                if (Object.Equals(current.data, value))
                {
                    return i;
                }
                i++;
                current = current.next;
            }
            return -1;
        }

        public void Insert(int index, object value)
        {
            Node temp = new Node { data = value };
            int i = 0;
            Node current = head;
            while (current != null)
            {
                if (i == index)
                {
                    temp.next = current.next;
                    current.data = temp.data;

                }
                i++;
                current = current.next;
            }
        }

        public bool IsFixedSize
        {
            get { return false; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Remove(object value)
        {
            Node current = head;
            while (current.next != null)
            {
                if (Object.Equals(current.next.data, value))
                {
                    current.next = current.next.next;
                }
                current = current.next;
            }
        }

        public void RemoveAt(int index)
        {
            int i = 0;
            Node current = head;
            while (current.next != null)
            {
                if (i == index)
                {
                    current.next = current.next.next;
                    break;
                }
                i++;
                current = current.next;
            }
        }

        public object this[int index]
        {
            get
            {
                int i = 0;
                Node temp = new Node();
                Node current = head;
                while (current.next != null)
                {
                    if (i == index)
                    {
                        temp = current;
                        break;
                    }
                    i++;
                    current = current.next;
                }
                return temp;
            }
            set
            {
                int i = 0;
                Node current = head;
                while (current != null)
                {
                    if (i == index)
                    {
                        current.data = value;
                        break;
                    }
                    i++;
                    current = current.next;
                }
            }
        }

        public void CopyTo(Array array, int index)
        {
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(this[i], index);
            }
        }

        public int Count
        {
            get
            {
                int i = 0;
                Node current = head;
                while (current != null)
                {
                    i++;
                    current = current.next;
                }
                return i;
            }
        }

        public bool IsSynchronized
        {
            get
            { 
                return false; 
            }
        }

        public object SyncRoot
        {
            get 
            { 
                return this;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
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
            mylist.printAllNodes();
            int i = mylist.IndexOf(0);
            bool b = mylist.Contains(7);
            Console.WriteLine(b + "," + i + "  ," + mylist.Count);
            Console.ReadKey();
        }
    }
}
