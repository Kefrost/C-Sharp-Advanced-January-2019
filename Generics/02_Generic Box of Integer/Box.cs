using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxofString
{
    public class Box<T>
    {
        private T value;
        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public override string ToString()
        {
            return $"{this.value.GetType()}: {value}";
        }
    }
}
