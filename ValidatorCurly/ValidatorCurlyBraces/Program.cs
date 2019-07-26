using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorCurlyBraces
{
    class Program
    {
        static void Main(string[] args)
        {
            CurlyBraces line = new CurlyBraces();
            bool ResultCheck = line.Check("([(])");
            if(ResultCheck==true)
            {
                Console.WriteLine("Validation!");
            }
            else
            {
                Console.WriteLine("No Validation!");
            }
        }
    }
}
