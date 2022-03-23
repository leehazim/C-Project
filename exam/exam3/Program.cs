using System;

namespace exam3 { 
    class Program{
        static void Main(string[] args) { 
            Console.WriteLine("직사각형 구하기 : ");

            Console.Write("가로길이를 입력하세요 : ");
            int Width = int.Parse(Console.ReadLine());
            Console.Write("세로길이를 입력하세요 : ");
            int Height = int.Parse(Console.ReadLine());

            int Area = Width * Height;
            Console.WriteLine("가로 : " + Width + " 세로 : " + Height + " 넓이 : " + Area);
        }
    }
}
