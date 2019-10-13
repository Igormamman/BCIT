using System;
using System.Collections;
using System.Collections.Generic;
using static System.Math;
namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Шпак Игорь ИУ5-34";
            Rectangle rect = new Rectangle(100, 200);
            Square square = new Square(53);
            Circle circle = new Circle(PI);
            ArrayList alist = new ArrayList();
            alist.Add(rect);
            alist.Add(square);
            alist.Add(circle);
            Console.WriteLine("ArrayList");
            foreach (var x in alist) Console.WriteLine(x);
            alist.Sort();
            Console.WriteLine("ArrayList-Sorted");
            foreach (var x in alist) Console.WriteLine(x);

            List<Figure> list = new List<Figure>();
            list.Add(rect);
            list.Add(square);
            list.Add(circle);
            Console.WriteLine("List<>");
            foreach (var x in list) Console.WriteLine(x);
            list.Sort();
            Console.WriteLine("List<>-Sorted");
            foreach (var x in list) Console.WriteLine(x);
            Matrix<Figure> matrix = new Matrix<Figure>(3, 3, 3, null);
            matrix[0, 0, 0] = rect;
            matrix[1, 1, 1] = square;
            matrix[2, 2, 2] = circle;
            Console.WriteLine(matrix.ToString());
            Simple_Stack<Figure> stack = new Simple_Stack<Figure>();
            stack.Push(rect);
            stack.Push(square);
            stack.Push(circle);
            foreach (var x in stack) Console.WriteLine(x);

            Console.WriteLine("\n"+stack.Pop() + "\n");
            Console.WriteLine(stack.Pop() + "\n");
            Console.WriteLine(stack.Pop() + "\n");

            foreach (var x in stack) Console.WriteLine(x);
        }
    }
}