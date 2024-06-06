namespace A019_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // y = int.MaxValue + 10; // 이 문장은 컴파일할 때 에러가 나옵니다.
            int x = int.MaxValue, y = 0;

            checked
            {
                try
                {
                    y = x + 10;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("int.MaxVlaue + 10 = {0}", y);
        }
    }
}
