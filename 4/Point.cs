using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    class Point
    {
        private int sideA;
        private int sideB;
        private string name;
        public int SideA
        {
            get
            {
                return sideA;
            }
        }
        public int SideB
        {
            get
            {
                return sideB;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Point(int A, int B, string C)
        {
           sideA = A;
           sideB = B;
            name = C;
        }
    }
}
