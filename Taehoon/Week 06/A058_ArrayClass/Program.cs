namespace A058_ArrayClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 25, 75, 35, 15 }; // 배열을 선언하고 초기화
            PrintArray(a);

            int[] b;
            b = (int[])a.Clone();            // 배열 복사 방법 1
            PrintArray(b);

            int[] c = new int[10];
            Array.Copy(a, 0, c, 1, 3);       // 배열 복사 방법 2
            PrintArray(c);                   // a 배열 0번부터 3개 요소를 c배열 1번 인덱스 위치에 복사

            a.CopyTo(c, 3);                  // 배열 복사 방법 3
            PrintArray(c);                   // a 배열의 내용을 c배열의 3번 인덱스에 복사하고 출력

            Array.Sort(a);                   // 오름차순으로 정렬
            PrintArray(a);

            Array.Reverse(a);                // 순서 뒤집기 (+ 오름차순 정렬 = 내림차 순 정렬)
            PrintArray(a);

            Array.Clear(a, 0, a.Length);     // a 배열을 0으로 초기화
            PrintArray(a);
        }

        private static void PrintArray(int[] a)
        {
            foreach (var i in a)
                Console.Write("{0,5}", i);
            Console.WriteLine();
        }
    }
}
