using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A025_StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = " Hello, World! ";
            string t;

            Console.WriteLine(s.Length);
            Console.WriteLine(s[8]);
            Console.WriteLine(s.Insert(8,"C# ")); //특정 위치에 문자열삽입 Hello,C#World!
            Console.WriteLine(s.PadLeft(20,'.')); //문자열의 길이, 를 맞출 문자.....Hello
            Console.WriteLine(s.PadRight(20,'.')); //World!.....
            Console.WriteLine(s.Remove(6)); //지우기 시작할 인덱스 ~
            Console.WriteLine(s.Remove(6,7)); //지우기 시작할 인덱스~인덱스 개수 
            Console.WriteLine(s.Replace('l','m')); //Hemmo.Wromd 앞에 문자를 뒤에 문자로 치환
            Console.WriteLine(s.ToLower()); 
            Console.WriteLine(s.ToUpper());
            Console.WriteLine('/' + s.Trim() + '/');
            Console.WriteLine('/' + s.TrimStart() + '/'); //앞 공백
            Console.WriteLine('/' + s.TrimEnd() + '/'); // 뒷 공백
           

            string[] a = s.Split(','); //','로 구분하여 string 배열 만들기
            foreach(var i in a)
                Console.WriteLine('/' + i + '/'); // / Hello/
            Console.WriteLine(s + "RN");

            char[] destination = new char[10]; 
            s.CopyTo(8, destination, 0, 5); //8번째 인덱스부터 배열의 0번째 인덱스로 6개의 문자 복사
            Console.WriteLine(destination); // World!

            Console.WriteLine('/' + s.Substring(8) + '/'); //시작 인덱스~끝까지 문자열 리턴 /World! /
            Console.WriteLine('/' + s.Substring(8,5) + '/'); //시작 인덱스 5개의 문자열 리턴 /world/

            Console.WriteLine(s.Contains("ll")); //찾는 문자열이 있으면 true : false
            Console.WriteLine(s.IndexOf('o')); //첫'o'의 위치 
            Console.WriteLine(s.LastIndexOf('o')); //마지막'o'의 위치
            Console.WriteLine(s.CompareTo("abc")); //s가 비교값보다 앞이면 -1, 같으면 0, 뒤면 +1
            //" Hello, World!" 빈칸으로 시작하므로 abc보다 앞에 나와 -1이 리턴

            Console.WriteLine(String.Concat("Hi~", s)); //정적메소드라 s가 아닌 string. 두개의 메소드 합치기 
            Console.WriteLine("abc",s); //abc의 a가 빈칸보다 뒤에 나오므로 +1
            Console.WriteLine(t = String.Copy(s)); //정적메소드

            String[] val = { "apple", "orange", "grape", "pear" };
            String result = String.Join(",", val); //string 배열 val의 각 요소를 "."로 연결
            Console.WriteLine(result);

        }
    }
}
