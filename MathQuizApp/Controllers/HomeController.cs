using MathQuizApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MathQuizApp.Controllers
{
    public class HomeController : Controller
    {
        MathProblem _problem;
        

        [HttpGet]
        public IActionResult Index()
        {
            _problem = new MathProblem();
            _problem.Generate();
            Console.Write($"{_problem.Num1}, {_problem.Num2}");
            return View(_problem);
        }
        [HttpPost]
        public bool Submit(string useranswer)
        {

            if (!int.TryParse(useranswer, out int userAnswer))
            {
                ModelState.AddModelError("UserAnswer", "¬ведите число.");
                return View(useranswer);
            }

            Console.Write($"{_problem.Num1} {_problem.Operator} {_problem.Num2}");
            return View($"{useranswer}");

        }



    }
}
