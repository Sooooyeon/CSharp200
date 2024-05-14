using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A032_Enum
{
    class Program
    {
    enum Size { Short, Tall, Grande, Venti }; //열거형 size를 정의, namespace나 class에 위치
    static int[] price = { 3300, 3800, 4300, 4800 };
    enum Colors { Red= 1, Green= 2, blue = 4, Yellow = 8 };
    enum Coffee {  Short = 3300, Tall = 3800, Grande = 4300, Venti = 4800 };
        //size를 기호상수로, 가격을 값으로 지정 
        static void Main(string[] args)
        {
        Console.WriteLine("커피 가격표");
        for(int i = 0; i<4; i++)
        {
            if (i == (int)Size.Short) //size를 int로 캐스팅하면 기호 상수에 해당하는 숫자 사용
                Console.WriteLine("{0,10}:{1:C}", Size.Short, price[i]);
            else if (i == (int)Size.Tall)
                Console.WriteLine("{0,10}:{1:C}", Size.Tall, price[i]);
            else if (i == (int)Size.Grande)
                Console.WriteLine("{0,10}:{1:C}", Size.Grande, price[i]);
            else if (i == (int)Size.Venti)
                Console.WriteLine("{0,10}:{1:C}", Size.Venti, price[i]);
        }
            Console.WriteLine("\n커피 가격표(Enum iteration)");
            foreach(var size in Enum.GetValues(typeof(Size)))
            { //열거형의 각 요소를 반복문에서 사용할 수 있다. 크기와 가격 출력 
                Console.WriteLine("{0,10}:{1:C}", size, price[(int)size]);
            }
            Console.WriteLine("\nColors Enum iteration");
            foreach (var color in Enum.GetValues(typeof(Colors)))
            {//컬러 출력 
                Console.WriteLine("{0,10}:{1}", color, Convert.ToInt32(color));
            }
            Console.WriteLine("\n커피 가격표(Enum iteration with value)");
            foreach (var coffee in Enum.GetValues(typeof(Coffee)))
            {
                Console.WriteLine("{0,10}:{1:C}", coffee, Convert.ToInt32(coffee));
            }
        }
    }
}
