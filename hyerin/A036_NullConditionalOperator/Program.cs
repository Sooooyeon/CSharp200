using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A036_NullConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = null;

            Console.WriteLine("4글자 이상인 동물의 이름만 출력합니다.");
            do
            {
                LongNameAnimal(animal);
                Console.Write("동물 이름: ");

            }while((animal = Console.ReadLine()) != ""); //공복이 나올 때까지 입력받기 
        }
        private static void LongNameAnimal(string animal)
        { //null 조건 연산자 '?' -> animal?.Length 에서 null일 경우 예외 발생대신 그냥 찾지 않고 넘어감 
            if (animal?.Length >= 4) //길이가 4이상인 경우에만 출력
                Console.WriteLine(animal + " : " + animal.Length);
        }
    }
}
