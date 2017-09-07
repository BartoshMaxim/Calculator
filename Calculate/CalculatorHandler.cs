using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    public class CalculatorHandler
    {
        public int Function(int firstNumber, int secondNumber, string operation)
        {
            return 0;
        }

        public string Assemble(string firstNumber, string secondNumber)
        {
            string result = firstNumber;
            if (result == "0")
            {
                return secondNumber;
            }
            result += secondNumber;
            return result;
        }

        internal string Inversion(string number)
        {
            string result = number;
            if (result.Contains("-"))
            {
                result = result.Replace("-", "");
            }
            else
            {
                result = result.Insert(0, "-");
            }
            return result;
        }

        public string DotAssemble(string firstNumber)
        {
            string result = firstNumber;
            if (!result.Contains("."))
                result += ".";
            return result;
        }
    }
}
