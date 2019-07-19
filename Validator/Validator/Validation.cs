using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    class Validation
    {
        const string prefixMTC = "+37533";
        const string prefixVEL = "+37529";
        const string prefixLIFE = "+37525";
        const string prefixVelcome = "+37544";

        public void PhoneNumberCheck(string line)
        {
            bool check = false;
            int counterNumber = 0;
            for (int i = 0; i < prefixMTC.Length; i++)
            {
                if (prefixMTC[i] == line[i] || prefixLIFE[i] == line[i] || prefixVEL[i] == line[i] || prefixVelcome[i] == line[i])
                    check = true;
                else
                    check = false;
                if (check == false)
                    break;
            }
            for (int i = 1; i < line.Length; i++)
            {   
                if (Char.IsDigit(line[i]))
                    counterNumber++;
                else
                    break;
            }
            if (check == true && counterNumber == 12)
            {
                Console.WriteLine("Phone number validary!");
            }
            else
                Console.WriteLine("Phone number not validary!");
        }
    }
}
