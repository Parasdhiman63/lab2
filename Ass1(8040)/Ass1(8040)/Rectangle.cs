using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass8040
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            length = 10;
            width = 20;
        }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public int GetLength()
        {
            return length;
        }

        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        public int GetPerimeter()
        {
            return (length * 2) + (width * 2);
        }
        public int GetArea()
        {
            return length * width;
        }
    }
}
