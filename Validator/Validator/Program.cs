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
            bool resultOneMethod = phoneNumber.PhoneNumberCheck("+37533346859");
            Console.WriteLine(resultOneMethod);
            bool resultTwoMethod = phoneNumber.CheckPrefix("80293432193");
            if( resultTwoMethod == true)
                Console.WriteLine("Phone number validation");
            else
                Console.WriteLine("Phone number not validation");
        }
    }
}
