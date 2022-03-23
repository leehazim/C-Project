using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("태어난 년도를 입력하세요 : ");
            int BirthYear = int.Parse(Console.ReadLine());
            int Age = 2022 - BirthYear + 1;

            Console.WriteLine("당신의 나이는 " + Age + "입니다.");
        }
    }
}
