using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace root_n_degree
{
    class Calculater
    {
        public double RootExtraction(double number,int power,double accuracy)
        {
            double tempEarlyNumber=number/2;
            double tempEarlyPower= Math.Pow(tempEarlyNumber, power);
            double summNumber=0;
            double tempSecondNumber = number;
            double summPower = 0;
            while (Math.Abs(number-summPower)>=accuracy)
            { 
                if (tempEarlyPower > number)
                {
                    tempSecondNumber = tempEarlyNumber;
                    tempEarlyNumber = tempSecondNumber / 2;
                    tempEarlyPower = Math.Pow(tempEarlyNumber, power);
                    summNumber = (tempEarlyNumber + tempSecondNumber) / 2;
                    summPower = Math.Pow(summNumber, power);
                }
                if (summPower > number)
                {
                    tempSecondNumber = summNumber;
                    summNumber = (tempEarlyNumber + tempSecondNumber) / 2;
                    summPower = Math.Pow(summNumber, power);
                }
                else
                {
                    tempEarlyNumber = summNumber;
                    summNumber = (tempEarlyNumber + tempSecondNumber) / 2;
                    summPower = Math.Pow(summNumber, power);
                }
            } 
            return summNumber;
        }
    }
}
