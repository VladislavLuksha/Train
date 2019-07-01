using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace root_n_degree
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculater number = new Calculater();
            double resultNumber = number.RootExtraction(81,4,1E-10);
            Console.WriteLine(resultNumber);
        }
    }
}
