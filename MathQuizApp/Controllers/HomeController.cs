using MathQuizApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;



namespace MathQuizApp.Controllers
{
    public class HomeController : Controller
    {

        private const string problemKey = "CurrentProblem";

        [HttpGet]
        public IActionResult Index()
        {
            var currentProblem = new MathProblem();
            TempData[problemKey] = JsonSerializer.Serialize(currentProblem);
            return View(currentProblem);
        }
        [HttpPost]
        public IActionResult Index(string useranswer)
        {
            var problemJson = TempData[problemKey] as string;
            var problem = JsonSerializer.Deserialize<MathProblem>(problemJson);
            if (!int.TryParse(useranswer, out int userAnswer))
            {
                ModelState.AddModelError("UserAnswer", "Введите число.");
                return View(problem);
            }

            problem.UserAnswer = useranswer;
            return Json(new { isCorrect = problem.IsCorrect });

        }
    }
}
