using System;
namespace Lab3
{     abstract class Figure : IComparable
    {
        public abstract double Area();
        public int CompareTo(Object obj)
        {
            if (obj == null) return 1;
            Figure com=(Figure)obj; 
            if (com != null)
                return Area().CompareTo(com.Area());
            else
            {
                Console.WriteLine("obj is not a Figure");
                return (1);
            }
        } 

    }
}
