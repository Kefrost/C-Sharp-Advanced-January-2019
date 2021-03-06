﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Swap
{
    public class Box<T>
    {
        private List<T> data;
        
        
        public Box()
        {
            this.data = new List<T>();

        }
        public void Add(T item)
        {
            this.data.Add(item);
            
        }
        public void Swap(int first, int second)
        {
            T temp = this.data[first];
            this.data[first] = this.data[second];
            this.data[second] = temp;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.data)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
