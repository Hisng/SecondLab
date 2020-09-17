using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    class Figure
    {
        private Point figure1;
        private Point figure2;
        private Point figure3;
        private Point figure4;
        private Point figure5;


        public Figure(Point _1)
        {
            figure1 = _1;
        }
        public Figure(Point _1, Point _2, Point _3)
        {
            figure1 = _1;
            figure2 = _2;
            figure3 = _3;
        }

        public Figure(Point _1, Point _2, Point _3, Point _4)
        {
            figure1 = _1;
            figure2 = _2;
            figure3 = _3;
            figure4 = _4;
        }

        public Figure(Point _1, Point _2, Point _3, Point _4, Point _5)
        {
            figure1 = _1;
            figure2 = _2;
            figure3 = _3;
            figure4 = _4;
            figure5 = _5;
        }

        public double AreaCalculator(Point A)
        {
            double S = A.SideA * A.SideB;
            return S;
        }

        public double PerimeterCalculator(Point A)
        {
            double S = A.SideA + A.SideB;
            return S;
        }
    }
}
