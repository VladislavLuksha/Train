using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    class Validation
    {
         string[] arrayPrefix = {"+37529","+37533","+37525","+37544","8033","8044","8025","8029"};
        /*
        public Validation()
        {
            
            arrayPrefix = new string[8];
            arrayPrefix[0]= "+37533";
            arrayPrefix[1]= "+37529";
            arrayPrefix[2] = "+37525";
            arrayPrefix[3] = "+37544";
            arrayPrefix[4] = "8029";
            arrayPrefix[5] = "8033";
            arrayPrefix[6] = "8025";
            arrayPrefix[7] = "8044";
        }
        */
        public bool PhoneNumberCheck(string line)
        {
            bool check = false;
            int counterNumber = 0;
            foreach(string elem in arrayPrefix)
            {
                if(line.StartsWith(elem))
                {
                    check = true;
                    break;
                }
                else
                    check = false;
            }
             /*
            for (int i = 0; i < arrayPrefix.Length; i++)
            {  
                for(int j=0;j<arrayPrefix[i].Length;j++)
                {
                    if (arrayPrefix[i][j] == line[j])
                        check = true;
                    else
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                    break;
            }
            */
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '+')
                    i++;
                if (Char.IsDigit(line[i]))
                    counterNumber++;
                else
                    break;
            }
            if (check == true && (counterNumber == 12 || counterNumber == 11))
                return true;
            else
                return false;
        }
    }
}
