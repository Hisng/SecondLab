using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    class Rectangle
    {
        private double side1;
        private double side2;
        private double area;
        private double perimeter;
        public Rectangle(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;

        }

        public double AreaCalculator()
        {
            area = side1 * side2;
            return Area;
        }
        public double PerimeterCalculator()
        {
            perimeter = (2 * side1) + (2 * side2);
            return Perimeter;
        }
        public double Area
        {
            get
            {
                return area;
            }
        }
        public double Perimeter
        {
            get
            {
                return perimeter;
            }
        }
    }
}
