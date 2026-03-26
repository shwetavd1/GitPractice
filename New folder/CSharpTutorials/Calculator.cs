using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    public class Calculator
    {
        public int addition(int number1, int number2)
        { 
            return number1 + number2;
        }
        public int subtraction(int number1, int number2)
        {
            return number1 - number2;
        }
        public int multiplication(int number1, int number2)
        {
            return number1 * number2;
        }
        public int divide(int number1, int number2)
        {
            if (number2 == 0)
                throw new DivideByZeroException("cannot divide by 0");
            return number1 / number2;
        }


    }
}
