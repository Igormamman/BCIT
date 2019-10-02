
using System;

using static System.Math;
namespace BCIT
{
    class BIEQ
    {

        static string[] ReadArgs()
        {

            string[] Coef;
            Coef = new string[3];
            int a;
            int i = 0;
            while (i < 3)
            {
                System.Console.WriteLine($"Введите  {i+1}  значение");
                Coef[i] = System.Console.ReadLine();
                if (Int32.TryParse(Coef[i], out a))
                {
                    i++;
                }
                else
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("Неверный формат ввода");
                    Console.ResetColor();
                }
            }
            return (Coef);
        }
        static double[] NumberOfRoots(int[] ICoef)
        {
            double D = (Pow(ICoef[1],2) - 4 * ICoef[0] * ICoef[2]);
            int Nroots = 0;
            double[] Roots;
            if (ICoef[0] == 0)
            {
                if (ICoef[1]==0)
                {
                    if (ICoef[2] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни любые");
                        Console.ResetColor();
                        return (null);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней нет");
                        Console.ResetColor();
                        return (null);
                    }
                }
                if (ICoef[2]/ICoef[1]<0)
                {
                    Console.WriteLine(ICoef[2] / ICoef[1]);
                    Nroots = 2;
                    Roots = new double[2];
                    Roots[0] = Sqrt(-ICoef[2] / ICoef[1]);
                    Roots[1] = -Sqrt(-ICoef[2] / ICoef[1]);
                    for (int i = 0; i < Nroots; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"x {i} = {Roots[i]}");
                        Console.ResetColor();
                    }
                    return (Roots);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Корней нет");
                    Console.ResetColor();
                    return (null);
                }
            }
            if (D > 0)
            {
                if (((-ICoef[1] - Sqrt(D)) / (2 * ICoef[0]) > 0) && ((-ICoef[1] + Sqrt(D)) / (2 * ICoef[0]) > 0))
                {
                   
                    Nroots = 4;
                    Roots = new double[4];
                    Roots[0] = Sqrt((-ICoef[1] - Sqrt(D)) / (2 * ICoef[0]));
                    Roots[1] = -Sqrt((-ICoef[1] - Sqrt(D)) / (2 * ICoef[0])) ;

                    Roots[2] = Sqrt((-ICoef[1] + Sqrt(D)) / (2 * ICoef[0]));
                    Roots[3] = -Sqrt((-ICoef[1] + Sqrt(D)) / (2 * ICoef[0]));
                    for (int i = 0; i < Nroots; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"x {i} = {Roots[i]}");
                        Console.ResetColor();
                    }
                    return (Roots);
                }
                else if (((-ICoef[1] - Sqrt(D)) / (2 * ICoef[0]) > 0) || ((-ICoef[1] + Sqrt(D)) / (2 * ICoef[0]) > 0))
                {
                   
                    Nroots = 2;
                    Roots = new double[2];
                    if (((-ICoef[0] - D) / (2 * ICoef[0])) > 0)
                    {
                        D = (-ICoef[1] - Sqrt(D)) / (2 * ICoef[0]);
                        Roots[0] = Sqrt(D);
                        Roots[1] = -Sqrt(D);
                        for (int i = 0; i < Nroots; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"x {i} = {Roots[i]}");
                            Console.ResetColor();
                        }
                        return (Roots);
                    }
                    else if (((-ICoef[1] + Sqrt(D)) / (2 * ICoef[0])) > 0)
                    {
                        
                        D = ((-ICoef[1] + Sqrt(D)) / (2 * ICoef[0]));
                        Roots[0] = Sqrt(D);
                        Roots[1] = -Sqrt(D);
                        for (int i = 0; i < Nroots; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"x {i} = {Roots[i]}");
                            Console.ResetColor();
                        }
                        return (Roots);
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Корней нет");
            Console.ResetColor();
            return null;
        }
        static int[] ConvertArgs(string[] Sroots)
        {
            int[] ICoef = new int[3];
            for (int i = 0; i < 3; i++)
            {
                ICoef[i] = Int32.Parse(Sroots[i]);
            }
            return (ICoef);
        }
        static void Main(string[] args)
        {
            Console.Title = "Шпак Игорь ИУ5-34Б";
            int[] ICoef = new int[3];
            try { ICoef = ConvertArgs(args); }
            catch (Exception)
            {
                System.Console.WriteLine("Ошибка чтения параметров командной строки");
                ICoef = ConvertArgs(ReadArgs());
            }
            double[] Nroots = NumberOfRoots(ICoef);
            Console.ReadKey();
        }
    }
}
