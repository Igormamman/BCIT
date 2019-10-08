using System;
namespace Lab3
{ 
    class Square : Rectangle, IPrint
    {
        public Square(double size)
            : base(size, size) { }
        public override string ToString()
        {
            return ("Квадрат =" + this.Area().ToString());
        }
    }
}
