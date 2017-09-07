using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    public class CommandHandler
    {
        public string NumberHandler(string number, string command)
        {
            string result = string.Empty;

            CalculatorHandler calcHandler = new CalculatorHandler();

            switch (command)
            {
                case "dot":
                    result = calcHandler.DotAssemble(number);
                    break;
                case "plus_minus":
                    result = calcHandler.Inversion(number);
                    break;
            }
            return result;
        }


        public bool IsAssembleCommand(string command)
        {
            if (command == "dot" || command == "plus_minus")
                return true;
            return false;
        }

        public bool IsFuncCommand(string command)
        {
            if (command == "clear" || command == "percent" || command == "division" || command == "multiply" || command == "minus"||command == "plus" || command == "equals")
                return true;
            return false;
        }
    }
}
