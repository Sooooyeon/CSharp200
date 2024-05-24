using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A035_PassingArrayAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30 }; //배열 초기화 
            Console.WriteLine("Main() before: arr[0] = {0}", arr[0]);
            Change(arr); //Change메소드 호출 _ 배열의 이름은 참조형이므로 main에서도 반영
            Console.WriteLine("Main() after: arr[0] = {0}", arr[0]);

            Student s1 = new Student();// Student 클래스 객체 생성 
            s1.name = "Alpha";//이름설정 
            Console.WriteLine("Main() before: " + s1.name);
            Change(s1); //Change메소드 호출_클래스 객체도 참조형이므로 main에도 반영 
            Console.WriteLine("Main() after: " + s1.name);
        }
        private static void Change(int[] arr)
        {
            arr[0] = -10;
        }
        private static void Change(Student s1)
        {
            s1.name = "Beta";
        }
    }
    class Student
    {
        public string name; //멤버변수 
    }
}
