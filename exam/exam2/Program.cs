using System;

namespace exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("섭씨에서 화씨로 바꾸자!");
            Console.Write("섭씨 온도를 입력해주세요 : ");

            float CDegree = float.Parse(Console.ReadLine());
            float FDegree = CDegree * 1.8f + 32;

            Console.WriteLine("C : " + CDegree + " F : " + FDegree);
        }
    }
}
