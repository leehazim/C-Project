using System;

namespace exam4 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("넓이로 평수 구하기");

            Console.Write("넓이를 입력해주세요 : ");
            float m2Area = float.Parse(Console.ReadLine());
            float pyungArea = m2Area / 3.305f;

            Console.WriteLine("제곱미터 : " + m2Area + "평수 : " + pyungArea);
        }
    }
}
