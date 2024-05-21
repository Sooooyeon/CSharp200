using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A037_Default
{
    // MyList<T> 제네릭 클래스 정의
    public class MyList<T>
    {
        // Node 클래스 정의
        private class Node
        {
            // T data, Node next 멤버
            public T data;
            public Node next;
        }
        private Node head = default;

        public void AddNode(T t)
        {
            Node newnode = new Node();
            newnode.next = head;
            newnode.data = t;
            head = newnode;
        }

        public T GetLast()
        {
            T temp = default(T);

            Node current = head;
            while (current !=null)
            {
                temp = current.data;
                current = current.next;
            }
            return temp;
        }
    }
    internal class Program
    {
        enum E { Red, Green, Blue };
        static void Main(string[] args)
        {
            int a = default;
            string s = default;
            Console.WriteLine("a = " + a);
            Console.WriteLine("s = " + s);

            // 열거형 E의 default 출력
            Console.WriteLine("E = " + default(E));
            Console.WriteLine("E = " + (E)0);

            // 연결 리스트 생성
            MyList<int> iList = new MyList<int>();
            Console.WriteLine("iList : " + iList.GetLast());

            MyList<string> sList = new MyList<string>();
            Console.WriteLine("sList : " + sList.GetLast());
        }
    }
}
