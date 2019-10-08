using System;

namespace Figures
{
    class Rectangle : Figure, IPrint
    {
        private double height;
        public double Height
        {
            get{ return this.height; }
            protected set{ this.height = value; }
        }
        private double width;
       public double Width
        {
            get { return this.height; }
            protected set { this.width = value; }
        }
        public Rectangle(double ph, double pw)
        {
            this.height = ph;
            this.width = pw;
        }
       public override double Area()
        {
            double Result = this.width * this.height;
            return Result;
        }
        public override string ToString()
        {
            return ("Прямоугольник =" + this.Area().ToString());
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
