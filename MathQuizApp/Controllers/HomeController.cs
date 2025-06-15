using MathQuizApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MathQuizApp.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            var problem = new MathProblem();
            problem.Generate();
            return View(problem);
        }
        [HttpPost]
        public IActionResult Index(MathProblem mathproblem)
        {

            if (!int.TryParse(mathproblem.UserAnswer, out int userAnswer))
            {
                ModelState.AddModelError("UserAnswer", "¬ведите число.");
                return View(mathproblem);
            }
            mathproblem.IsCorrect = userAnswer == mathproblem.CorrectAnswer;

            TempData["RedirectDelay"] = true;
            return View(mathproblem);


        }



    }
}
