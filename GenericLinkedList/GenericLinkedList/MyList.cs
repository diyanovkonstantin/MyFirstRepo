using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericLinkedList;
using System.Collections;

namespace GenericLinkedList
{
    class MyList<T> : IList<T>
    {
        private Node<T> head;

        public void AddFirst(T add)
        {
            Node<T> temp = new Node<T>();
            temp.Data = add;
            temp.Next = head;
            head = temp;
        }

        public void AddLast(T add)
        {
            Node<T> temp=new Node<T>();
            temp.Data = add;
            
            if (head == null)
            {
                head = temp;
            }
            else
            {
                Node<T> current = new Node<T>();
                current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = temp;
            }
        }

        public int IndexOf(T item)
        {
            int i = 0;
            Node<T> current = head;
            while (current != null)
            {
                if (Object.Equals(current.Data, item))
                {
                    return i;
                }
                i++;
                current = current.Next;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
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

        public T this[int index]
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
                return temp.Data;
            }
            set
            {
                int i = 0;
                Node<T> current = head;
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

        public void Add(T item)
        {
            this.AddFirst(item);
        }

        public void Clear()
        {
            head = null;
        }

        public bool Contains(T item)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (Object.Equals(current.Data, item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
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

        public bool Remove(T item)
        {
            Node<T> current = head;
            while (current.Next != null)
            {
                if (Object.Equals(current.Next.Data, item))
                {
                    current.Next = current.Next.Next;
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
