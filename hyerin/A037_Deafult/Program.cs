using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A037_Deafult
{//default는 제네릭에 유용하다. _ 문제 발생 시 형식T에 기본값 할당 
    internal class Program
    { //참조형식 기본값은 null이다. 
        enum E { Red, Green, Blue };//enum은 메소드 밖에 선언 
        static void Main(string[] args)
        {
            int a = default; //a = 0, s = null로 초기화 
            string s = default; //string은 참조형식이므로 default값이 null이다. 
            Console.WriteLine("a = " + a);
            Console.WriteLine("s = " + s);

            Console.WriteLine("E = " + default(E));//열거형 e의 default = 0인 red 출력 
            Console.WriteLine("E = " + (E)0);

            MyList<int> iList = new MyList<int>(); // 연결 리스트인 제네릭 클래스 MyList의 객체로 연결 리스트 iList생성
            Console.WriteLine("iList : " + iList.GetLast()); //.GetLast()메소드로 마지막 노드의 data값을 가져오고 비어있다면 default값인 0출력 

            MyList<string> sList = new MyList<string>();
            Console.WriteLine("sList : " + sList.GetLast());//위와 동일하며 비어있다면 data의 디폴트 값인 null을 받아 출력  
        }
    }

    public class MyList<T> //클래스 정의 
    {
        public class Node //클래스 정의 
        {
            public T data; //멤버 정의 
            public Node next;
        }
        private Node head = default; //head객체초기화 _ Node가 클래스이므로 null초기화 

        public void AddNode(T t) //data를 t로 하는 node를 만들기 
        {
            Node newNode = new Node(); 
            newNode.next = head;
            newNode.data = t;
            head = newNode; 
        }
        public T GetLast()
        {
            T temp = default(T); //초기화, 리스트에 요소가 없다면 이 값이 리턴되며, T형에 따라 디폴트 값이 달라지므로 default(T)형으로 사용 

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
