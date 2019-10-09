using System;
using static System.Math;
namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Шпак Игорь ИУ5-34";
            Rectangle rect = new Rectangle(100, 200);
            Square square = new Square(53);
            Circle circle = new Circle(PI);

            rect.Print();
            square.Print();
            circle.Print();

            Console.ReadLine();
        }
    }
}
