using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    abstract class Triangle
    {
        public Triangle handler { get; set; }
        public abstract void PrintTriangle();
        public abstract void sortTriangle(int a, int b, int c);
    }
}
