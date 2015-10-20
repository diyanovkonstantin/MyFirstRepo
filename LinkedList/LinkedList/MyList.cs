using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class MyList : IList
    {
        private Node head;

        public void PrintAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public void AddFirst(Object data)
        {
            Node toAdd = new Node();
            toAdd.Data = data;
            toAdd.Next = head;
            head = toAdd;
        }

        public void AddLast(Object data)
        {
            if (head == null)
            {
                head = new Node();
                head.Data = data;
                head.Next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.Data = data;

                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = toAdd;
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
                if (Object.Equals(current.Data, value))
                {
                    return true;
                }

                current = current.Next;
            }
            return false;
        }

        public int IndexOf(object value)
        {
            int i = 0;
            Node current = head;
            while (current != null)
            {
                if (Object.Equals(current.Data, value))
                {
                    return i;
                }
                i++;
                current = current.Next;
            }
            return -1;
        }

        public void Insert(int index, object value)
        {
            Node temp = new Node { Data = value };
            int i = 0;
            Node current = head;
            while (current != null)
            {
                if (i == index)
                {
                    temp.Next = current.Next;
                    current.Data = temp.Data;

                }
                i++;
                current = current.Next;
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
            while (current.Next != null)
            {
                if (Object.Equals(current.Next.Data, value))
                {
                    current.Next = current.Next.Next;
                }
                current = current.Next;
            }
        }

        public void RemoveAt(int index)
        {
            int i = 0;
            Node current = head;
            while (current.Next != null)
            {
                if (i == index)
                {
                    current.Next = current.Next.Next;
                    break;
                }
                i++;
                current = current.Next;
            }
        }

        public object this[int index]
        {
            get
            {
                int i = 0;
                Node temp = new Node();
                Node current = head;
                while (current.Next != null)
                {
                    if (i == index)
                    {
                        temp = current;
                        break;
                    }
                    i++;
                    current = current.Next;
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
                        current.Data = value;
                        break;
                    }
                    i++;
                    current = current.Next;
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
                    current = current.Next;
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
}
