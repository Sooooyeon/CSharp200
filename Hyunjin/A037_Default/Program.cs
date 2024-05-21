using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace A037_Default
{
    internal class Program
    {  
        enum E { Red, Green, Blue };
        static void Main(string[] args)
        {
            int a = default; 
            string s = default; 
            Console.WriteLine("a = " + a);
            Console.WriteLine("s = " + s);

            Console.WriteLine("E = " + default(E));
            Console.WriteLine("E = " + (E)0);

            MyList<int> iList = new MyList<int>(); 
            Console.WriteLine("iList : " + iList.GetLast()); 

            MyList<string> sList = new MyList<string>();
            Console.WriteLine("sList : " + sList.GetLast());
        }
    }

        public class MyList<T>
        {
            public class Node 
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