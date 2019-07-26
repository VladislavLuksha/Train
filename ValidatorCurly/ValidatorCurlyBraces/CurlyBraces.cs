using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorCurlyBraces
{
    class CurlyBraces
    {
        Stack<char> StackSymbols=new Stack<char>();
        Dictionary<char, char> DictionarySymbols = new Dictionary<char, char> { { ')', '(' }, { ']', '[' }, { '}', '{' } };

        public bool Check (string line)
        {
            bool checkSymbols=true;
            for(int i=0;i<line.Length;i++)
            {
                if(DictionarySymbols.ContainsValue(line[i]))
                {
                    StackSymbols.Push(line[i]);
                }
                /*
                foreach(char element in DictionarySymbols.Values)
                {
                    if (line[i] == element)
                    {
                        StackSymbols.Push(element);
                        checkSymbols = true;
                        break;
                    }
                }
                */
                if (StackSymbols.Count != 0)
                {
                    if(DictionarySymbols.ContainsKey(line[i]))
                    {
                        if (DictionarySymbols[line[i]] == StackSymbols.Peek())
                        {
                            StackSymbols.Pop();
                        }
                        else
                        {
                            checkSymbols = false;
                            break;
                        }
                    }
                    /*
                    foreach (char element in DictionarySymbols.Keys)
                    {
                        if (element == line[i])
                        {
                            if (DictionarySymbols[element] == StackSymbols.Peek())
                            {
                                StackSymbols.Pop();
                            }
                            else
                            {
                                checkSymbols = false;
                            }
                        }
                    }
                    */
                }
                else
                {
                    checkSymbols = false;
                }
            }
            if(StackSymbols.Count!=0)
            {
                checkSymbols = false;
            }
            return checkSymbols;
        }
            
    }
}
