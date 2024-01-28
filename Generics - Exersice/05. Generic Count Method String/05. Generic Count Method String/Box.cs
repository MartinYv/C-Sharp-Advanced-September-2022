using System;

namespace GenericCountMethodString
{
    public class Box<T> : IComparable<T> where T : IComparable<T>
    {
        public Box(T value)
        {
            Value = value;
        }

        public T Value { get; private set; }

        public int CompareTo(T comparator)
        {
            return Value.CompareTo(comparator);
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {Value}";
        }
    }
}