using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericLinkedList;
using System.Collections;

namespace GenericLinkedList
{
    class MyList<T> : IList<Node<T>>
    {
        private Node<T> head;

        public void AddFirst(Node<T> add)
        {
            add.Next = head;
            head = add;
        }

        public void AddLast(Node<T> add)
        {
            if (head == null)
            {
                head = add;
            }
            else
            {
                Node<T> current = new Node<T>();
                current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = add;
            }
        }

        public int IndexOf(Node<T> item)
        {
            int i = 0;
            Node<T> current = head;
            while (current != null)
            {
                if (Object.Equals(current.Data, item.Data))
                {
                    return i;
                }
                i++;
                current = current.Next;
            }
            return -1;
        }

        public void Insert(int index, Node<T> item)
        {
            item.Next = this[index].Next;
            this[index] = item;
        }

        public void RemoveAt(int index)
        {
            int i = 0;
            Node<T> current = head;
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

        public Node<T> this[int index]
        {
            get
            {
                int i = 0;
                Node<T> temp = new Node<T>();
                Node<T> current = head;
                while (current != null)
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
                Node<T> current = head;
                while (current != null)
                {
                    if (i == index)
                    {
                        current = value;
                        break;
                    }
                    i++;
                    current = current.Next;
                }
            }
        }

        public void Add(Node<T> item)
        {
            this.AddFirst(item);
        }

        public void Clear()
        {
            head = null;
        }

        public bool Contains(Node<T> item)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (Object.Equals(current.Data, item.Data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(Node<T>[] array, int arrayIndex)
        {
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(this[i], arrayIndex);
            }

        }

        public int Count
        {
            get
            {
                int i = 0;
                Node<T> current = head;
                while (current != null)
                {
                    i++;
                }
                return i;
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(Node<T> item)
        {
            Node<T> current = head;
            while (current.Next != null)
            {
                if (Object.Equals(current.Next.Data, item.Data))
                {
                    current.Next = current.Next.Next;
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<Node<T>> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
