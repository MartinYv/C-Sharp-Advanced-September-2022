using System;
using System.Collections.Generic;
using System.Text;

namespace _3.GenericSwapMethodStrings
{
    public class Box<T>
    {
        private List<T> box;

        public Box()
        {
            box = new List<T>();
        }

        public void Add(T element)
        {
            box.Add(element);
        } 

        public List<T> ToList()
        {
            return box.ToList();
        }

        public List<T> Swap(List<T> list, int firstIndex, int secondIndex)
        {
            var temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;

            box = list;
            return box;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            foreach (var item in box)
            {
                stringBuilder.AppendLine($"{typeof(T)}: {item}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
