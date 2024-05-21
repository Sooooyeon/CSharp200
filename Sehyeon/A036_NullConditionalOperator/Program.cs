using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A036_NullConditionalOperator
{
    internal class Program
    {
        private static void LongNameAnimal(string animal)
        {
            if (animal?.Length >= 4)
                Console.WriteLine(animal + ": " + animal.Length);
        }

        static void Main(string[] args)
        {
            // animal 변수 초기화
            string animal = null;
            Console.WriteLine("4글자 이상인 동물의 이름만 출력합니다.");
            
            // do루프 조건이 만족할 때까지 반복 
            do
            {
                LongNameAnimal(animal);
                Console.WriteLine("동물 이름: ");
                // 사용자가 입력한 동물 이름을 animal에 할당
                // animal이 빈문자열이 아닐 때까지 루프 반복
            } while ((animal = Console.ReadLine()) !="");


        }
    }
}
