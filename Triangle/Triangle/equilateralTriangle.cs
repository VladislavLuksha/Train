using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class equilateralTriangle : Triangle
    {

        public override void PrintTriangle()
        {
            Console.WriteLine("This triangle is equilateral!");
        }

        public override void sortTriangle(int a, int b, int c)
        {
            if(a==b && a==c && b==c)
            {
                PrintTriangle();
            }
            else if(handler!=null)
            {
                handler.sortTriangle(a, b, c);
            }
        }
    }
}
