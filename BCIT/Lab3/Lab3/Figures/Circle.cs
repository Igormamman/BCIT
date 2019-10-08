using System;

namespace Lab3
{
    class Circle : Figure, IPrint
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }

        }
        public Circle(double pr)
        {
            radius = pr;
        }

        public override double Area()
        {
            double Result = Math.PI * radius * radius;
            return Result;
        }
        public override string ToString()
        {
            return "Круг =" + Area().ToString();
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
