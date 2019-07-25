﻿using System;
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
        int startIndex;
        int endIndex;
        
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

        public bool CheckPrefix(string line)
        {
            bool check = false;
            foreach (string elem in arrayPrefixWithAPlus)
            {
                if(line.StartsWith(elem))
                {
                    startIndex = 5;
                    endIndex = line.Length - 1;
                    if (endIndex == 12)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            if (Char.IsDigit(line[i]))
                            {
                                check = true;
                            }
                            else
                            {
                                check = false;
                                break;
                            }
                        }
                        break;
                    }
                    else
                    {
                        check = false;
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
                        startIndex = 3;
                        endIndex = line.Length - 1;
                        if (endIndex == 10)
                        {
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                if (Char.IsDigit(line[i]))
                                {
                                    check = true;
                                }
                                else
                                {
                                    check = false;
                                    break;
                                }
                            }
                            break;
                        }
                        else
                        {
                            check = false;
                        }
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            if (check == true)
                return true;
            else
                return false;
        }
    }

}
