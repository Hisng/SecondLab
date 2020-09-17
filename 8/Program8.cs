using System;

namespace _8
{
    class Program8
    {
        static void Main(string[] args)
        {
            Invoice order = new Invoice(1, "Nikita", "Apple");
            order.Quantity = 2;
            order.OrderValue(1200);
        }
    }
}
