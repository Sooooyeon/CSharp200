namespace A061_RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            Console.Write("{0,-16}", "Random Bytes");
            Byte[] b = new byte[5];
            r.NextBytes(b);
            // 한번 호출로 b배열을 랜덤값(0~255)으로 채움

            foreach (var x in b)
            { 
                Console.Write("{0,12}", x); // 12글자로 출력
            }
            Console.WriteLine();

            Console.Write("{0,-16}", "Random Double");
            double[] d = new double[5];

            for (int i = 0; i < 5; i++)
            {
                d[i] = r.NextDouble();
            }
            // 0~1 사이의 double 랜덤값 5개 생성, 저장

            foreach (var x in d)
            {
                Console.Write("{0,12:F8}", x); // 12글자, 소수점 아래 8자리로 출력
            }
            Console.WriteLine();

            Console.Write("{0,-16}", "Random Int32");
            int[] a = new int[5];

            for (int i = 0; i < 5; i++)
            {
                a[i] = r.Next();
            }  
            PrintArray(a);
            // 5개 int 랜덤값 생성 저장

            Console.Write("{0,-16}", "Random 0~99");
            int[] v = new int[5];

            for (int i = 0; i < 5; i++)
            {
                v[i] = r.Next(100);
            }  
            PrintArray(v);
            // 5개 0~99의 랜덤값 생성 저장
        }

        private static void PrintArray(int[] v)
        {
            foreach (var value in v)
            {
                Console.Write("{0,12}", value); 
            }
            Console.WriteLine();
        }
    }
}
