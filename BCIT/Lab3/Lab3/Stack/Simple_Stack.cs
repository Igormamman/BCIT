using System;

namespace Lab3
{
    class Simple_Stack<T> : SimpleList<T> where T : IComparable
    {
        public void Push(T elem )
        {
            this.Add(elem);
        }
        public T Pop()
        {
            T a;
            if (this.Count == 0)
                return default;
            else if (this.Count == 1)
            {
                a = this.first.data;
                this.first = null;
                this.last = null;
            }
            else
            {
                SimpleListItem<T> temp = this.GetItem(this.Count - 2);
                a = temp.next.data;
                this.last = temp;
                temp.next = null;
            }
            this.Count--;
            return (a);
        }
    }
}
