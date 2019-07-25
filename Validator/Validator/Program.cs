using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation phoneNumber = new Validation();
            bool result = phoneNumber.CheckPrefix("+37533421967");
            if( result == true)
                Console.WriteLine("Phone number validation");
            else
                Console.WriteLine("Phone number not validation");
        }
    }
}
