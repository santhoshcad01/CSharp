using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OBOOKS.Controllers
{
    [Route("[controller]")]
    public class TraineeController : Controller
    {
        private readonly ILogger<TraineeController> _logger;

        public TraineeController(ILogger<TraineeController> logger)
        {
            _logger = logger;
        }
         [Route("Trainee/Dashboard")]

        public IActionResult Dashboard()
        {
            return View("Dashboard","_LayoutTrainee");
        }
        public IActionResult MyCourses()
        {
            return View("MyCourses","_LayoutTrainee");
        }
        public IActionResult ScheduleSessions()
        {
            return View("ScheduleSessions","_LayoutTrainee");
        }
          public IActionResult ManageTrainee()
        {
            return View("ManageTrainee","_LayoutTrainee");
        }
        public IActionResult Grades()
        {
            return View("Grades","_LayoutTrainee");
        }
        public IActionResult Resources()
        {
            return View("Resources","_LayoutTrainee");
        }
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}