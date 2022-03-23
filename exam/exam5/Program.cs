using System;

namespace exam5 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("날수를 초로 바꾸기");

            Console.Write("날 수 가 어떤가요 : ");
            int Days = int.Parse(Console.ReadLine());
            int Sec = Days * 24 * 60 * 60;

            Console.WriteLine(Days + "일은 " + Sec + "초 입니다.");
        }
    }
}
