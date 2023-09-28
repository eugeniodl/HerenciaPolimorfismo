using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIComparable
{
    internal class Rectangle : IComparable
    {
        private double length;
        private double width;
        private double area;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
            CalculateArea();
        }

        private void CalculateArea()
        {
            area = length * width;
        }

        public override string ToString()
        {
            return String.Format("[{0},{1}]={2}",
                length, width, area);
        }

        public int CompareTo(object? obj)
        {
            Rectangle temp = obj as Rectangle;

            if(area > temp.area)
                return 1;
            if(area < temp.area)
                return -1;

            return 0;

        }
    }
}
