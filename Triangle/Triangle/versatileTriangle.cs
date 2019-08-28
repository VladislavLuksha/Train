using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class versatileTriangle : Triangles
    {
        public override void PrintTriangle()
        {
            Console.WriteLine("This triangle is versatile"); ;
        }

        public override void sortTriangle(int a, int b, int c)
        {
            if(a!=b &&  b!=c && a!=c)
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
