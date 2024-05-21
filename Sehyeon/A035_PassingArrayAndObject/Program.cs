using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A035_PassingArrayAndObject
{

    // Student 클래스 생성
    class Student
    {
        public string name;
    }
    internal class Program
    {
        // Chage 메서드
        private static void Change(int[] arr)
        {
            arr[0] = -10;
        }

        private static void Change(Student s1)
        {
            s1.name = "Beta";
        }

        static void Main(string[] args)
        {
            // 배열 arr 초기화
            int[] arr = { 10, 20, 30 };
            Console.WriteLine("Main() before: arr[0] = {0}", arr[0]);

            Change(arr);
            Console.WriteLine("Main() after: arr[0] = {0}", arr[0]);

            Student s1 = new Student();
            s1.name = "Alpha";
            Console.WriteLine("Main before: " + s1.name);

            Student s2 = new Student();
            Change(s2);
            Console.WriteLine("Main after: " + s2.name);

            
        }
    }
}
