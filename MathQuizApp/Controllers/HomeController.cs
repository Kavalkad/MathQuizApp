using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MathQuizApp.Models;

namespace MathQuizApp.Controllers
{
    public class HomeController : Controller
    {
        private static MathProblem _currentProblem;

        [HttpGet]
        public IActionResult Index()
        {
            _currentProblem = new MathProblem().Generate();
            return View(_currentProblem);
        }

        [HttpPost]
        public IActionResult Index(string useranswer)
        {
            if (!int.TryParse(useranswer, out int userAnswer))
            {

                ModelState.AddModelError("UserAnswer", "Введите число.");
                return View(_currentProblem);

            }

            _currentProblem.UserAnswer = useranswer;

            return Json(new { isCorrect = _currentProblem.IsCorrect });
        }
    }
}