using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
   public class EqualityScale<T>
    {
        private T left;
        private T right;

        public EqualityScale(T Left, T Right)
        {
            Left = left;
           Right = right;
        }

        public bool AreEqual (T left, T right)
        {
            return left.Equals(right);
         
           

        }
    }
}
