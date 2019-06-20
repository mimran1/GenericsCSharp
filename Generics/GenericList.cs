using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    /// <summary>
    /// Generics allow to implement a concept like sorting. It leaves the data out of it by providing generic parameter (in our case T).
    /// So we can write a simple stack program, that can stack anything. The idea (stacking) is implemented. Data is left for user to provide
    /// Following code was adopted from: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/index
    /// </summary>
    /// <typeparam name="T"></typeparam>

    public class GenericList<T>
    {
        public class Node
        {
            private T data;
            private Node next;
            public Node(T t)
            {
                data = t;
            }

            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            public T Data
            {
                get { return data; }
                set { data = value; }
            }

        }

        private Node head;

        public GenericList()
        {
            head = null;
        }

        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node curr = head;
            while (curr != null)
            {
                yield return curr.Data;
                curr = curr.Next;
            }
        }
    }
}
