using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> list;

        public Box()
        {
            list = new List<T>();
        }

        public int Count { get { return list.Count; } }


        public void Add(T element) //– adds an element on the top of the list.
        {
            list.Insert(0, element);

        }

        public T Remove() //– removes the topmost element.
        {
            T firstElement = list[0];
            list.RemoveAt(0);
            return firstElement;
        }
    }
}

