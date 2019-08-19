using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle versatileTriangle = new versatileTriangle();
            Triangle equilateralTriangle = new equilateralTriangle();
            Triangle isoscelesTriangle = new isoscelesTriangle();
            versatileTriangle.handler = equilateralTriangle;
            equilateralTriangle.handler = isoscelesTriangle;
            versatileTriangle.sortTriangle(0, 0, 0);
        }
    }
}
