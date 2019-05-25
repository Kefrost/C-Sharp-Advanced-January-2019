using System;
using System.Collections.Generic;
using System.Text;

namespace rectangle
{
    public class Rectangle
    {
        public Rectangle(string id, double width, double height, double x, double y)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.TopLeftX = x;
            this.TopLeftY = y;
        }
        public string Id { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double TopLeftX { get; set; }
        public double TopLeftY { get; set; }

        public bool Intersect(Rectangle secondRectangle)
        {
            if (this.TopLeftX + this.Width < secondRectangle.TopLeftX
                || secondRectangle.TopLeftX + secondRectangle.Width < this.TopLeftX
                || this.TopLeftY + this.Height < secondRectangle.TopLeftY
                || secondRectangle.TopLeftY + secondRectangle.Height < this.TopLeftY)
            {
                return false;
            }

            return true;
        }
    }
}
