using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace A037_Deafult
{
    internal class Program
    {
        enum E { Red, Green, Blue };
        static void Main(string[] args)
        {
            int a = default;
            string s = default;

            Console.WriteLine("a = " + a); // a = 0
            Console.WriteLine("s = " + s); // s =

            Console.WriteLine("E = " + default(E)); // E = Red
            Console.WriteLine("E = " + (E)0); // E = Red

            MyList<int> iList = new MyList<int>();
            Console.WriteLine("iList : " + iList.GetLast()); // iList : 0

            MyList<string> sList = new MyList<string>();
            Console.WriteLine("sList : " + sList.GetLast()); // sList :

        }
    }

    public class MyList<T>
    {
        private class Node
        {
            public T data;
            public Node next;

        }

        private Node head = default;
    

         public void AddNode(T t)
        {
            Node newNode = new Node();
            newNode.next = head;
            newNode.data = t;
            head = newNode;
        }
    
        public T GetLast()
        {
            T temp = default(T);

            Node current = head;
            while (current != null)
            {
                temp = current.data;
                current = current.next;
            }
            return temp;
        }
    }
}
