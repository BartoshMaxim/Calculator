using Calculate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();

        }

        public ActionResult Calculate(string value, string number, string command)
        {
            CalculatorHandler calcHandler = new CalculatorHandler();
            CommandHandler comHandler = new CommandHandler();
            string result = value ?? "0";
            if (result.Length >= 15)
            {
                result = value;
                number = null;
                command = null;
            }

            if (number != null)
            {
                result = calcHandler.Assemble(value, number);
            }
            else if (command != null)
            {
                if (comHandler.IsAssembleCommand(command))
                    result = comHandler.NumberHandler(value, command);
            }

            return PartialView((object)result);
        }
    }
}