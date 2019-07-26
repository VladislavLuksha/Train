using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    class Validation
    {
        string[] arrayPrefix = { "+37529", "+37533", "+37525", "+37544", "8033", "8044", "8025", "8029" };
        string[] arrayPrefixWithAPlus = {"+37529","+37533","+37525","+37544"};
        string[] arrayPrefixNoPlus = {"8033", "8044", "8025", "8029"};
        const int startIndexPlus=5;
        const int endIndexPlus=12;
        const int startIndexNoPlus = 3;
        const int endIndexNoPlus = 10;
        const int numberNoPlus = 11;
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
                if (line[0] == '8')
                    i++;
                if (Char.IsDigit(line[i]))
                    counterNumber++;
                else
                    break;
            }
            if (check == true && (counterNumber == endIndexPlus || counterNumber == numberNoPlus))
                return true;
            else
                return false;
        }

        public bool CheckPrefix(string line)
        {
            bool check = true;
            foreach (string elem in arrayPrefixWithAPlus)
            {
                if(line.StartsWith(elem))
                {
                    check = true;
                    int endIndex = line.Length - 1;
                    if (endIndex == endIndexPlus)
                    {
                        for (int i = startIndexPlus; i <= endIndex; i++)
                        {
                            if (!Char.IsDigit(line[i]))
                            {
                                check = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
                else
                {
                    check=false;
                }
            }
            if(check==false)
            {
                foreach (string elem in arrayPrefixNoPlus)
                {
                    if (line.StartsWith(elem))
                    {
                        check = true;
                        int endIndex = line.Length - 1;
                        if (endIndex == endIndexNoPlus)
                        {
                            for (int i = startIndexNoPlus; i <= endIndex; i++)
                            {
                                if (!Char.IsDigit(line[i]))
                                {
                                    check = false;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            check = false;
                            break;
                        }
                    }
                }
            }
            return check;
        }
    }

}
