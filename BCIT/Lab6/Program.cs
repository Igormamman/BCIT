using System;

namespace Lab6
{
    class Program
    {
        delegate double MultiplyOrDivide(int p1, int p2);
        static double Multiply(int p1, int p2) { return p1 * p2; }
        static double Divide(int p1, int p2) { return p1 / p2; }   
        static void MultiplyOrDivideMethodFunc(string str, int i1, int i2, Func<int, int, double> MultiplyOrDivideParam)
        {
            double Result = MultiplyOrDivideParam(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }
        static void MultiplyOrDivideMethod(string str, int i1, int i2, MultiplyOrDivide MultiplyOrDivideParam)
        {
            double Result = MultiplyOrDivideParam(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }
        static void Main(string[] args)
        {
            int i1 = 3;
            int i2 = 2;
            MultiplyOrDivideMethod("Divide: ", i1, i2, Divide);
            MultiplyOrDivideMethod("Multiply: ", i1, i2, Multiply);

            MultiplyOrDivide pm1 = new MultiplyOrDivide(Multiply);
            MultiplyOrDivideMethod("Создание экземпляра делегата на основе метода: ", i1, i2, pm1);

            MultiplyOrDivide pm2 =Multiply;
            MultiplyOrDivideMethod("Создание экземпляра делегата на основе 'предположения' делегата: ", i1, i2, pm2);

            MultiplyOrDivide pm3 = delegate (int param1, int param2)
            {
                return param1 * param2;
            };
            MultiplyOrDivideMethod("Создание экземпляра делегата на основе анонимного метода: ", i1, i2, pm3);

            MultiplyOrDivide pm4 = (int x, int y) =>
            {
                int z = x * y;
                return z;
            };
            MultiplyOrDivideMethod("Создание экземпляра делегата на основе лямбда-выражения в виде переменной: ", i1, i2, pm4);

            int outer = 100;
            MultiplyOrDivide pm5 = (int x, int y) =>
            {
                int z = x + y + outer;
                return z;
            };
            MultiplyOrDivideMethod("Создание экземпляра делегата на основе лямбда-выражения : ", i1, i2, 
                (int x, int y) =>
            {
                int z = x * y;
                return z;
            }
                );
            Console.WriteLine("Использвоание обобщенного делегата Func <>");
            MultiplyOrDivideMethodFunc("Создание экземпляра делегата на основе метода: ", i1, i2, Multiply ) ;

            Console.WriteLine("Пример группового делегата");
            Action<int, int> a1 = (x, y) => { Console.WriteLine("{0} * {1} = {2}", x, y, x * y); };
            Action<int, int> a2 = (x, y) => { Console.WriteLine("{0} / {1} = {2}", x, y, x / y); };
            Action<int, int> group = a1 + a2;
            group(5, 3);

        }
    }
}
