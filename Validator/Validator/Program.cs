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
            phoneNumber.PhoneNumberCheck("375204219487");
        }
    }
}
