        using System;

    namespace Figures
    {
        class Circle : Figure, IPrint
        {
            private double radius;
            public double Radius
            {
                get { return this.radius; }
                set { this.radius = value; }

            }
            public Circle(double pr)
            {
                this.radius = pr;
            }

            public override double Area()
            {
                double Result = Math.PI * this.radius * this.radius;
                return Result;
            }
            public override string ToString()
            {
                return ("Круг =" + this.Area().ToString());
            }
            public void Print()
            {
                Console.WriteLine(this.ToString());
            }
        }
    }
