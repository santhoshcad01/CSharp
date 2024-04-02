using Microsoft.AspNetCore.Mvc;

namespace OBOOKS.Controllers
{
    [Route("[contorller]")]
  public class TraineeController : Controller
  {
     private readonly ILogger<TraineeController> _logger;

        public TraineeController(ILogger<TraineeController> logger)
        {
            _logger = logger;
        }
    [Route("Trainee/Dashboard")]
  public IActionResult Dashboard(){
    return View("Dashboard","_LayoutTrainee");

  }
   public IActionResult EnrollinCourse(){
    return View("EnrollinCourse","_LayoutTrainee");

  }
    public IActionResult MyCourses(){
    return View("MyCourses","_LayoutTrainee");

  }
    public IActionResult ViewSessionsSchedule(){
    return View("ViewSessionsSchedule","_LayoutTrainee");

  }
    public IActionResult Grades(){
    return View("Grades","_LayoutTrainee");

  }
    public IActionResult Resources(){
    return View("Resources","_LayoutTrainee");

  }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View("Error!");
    }
  
  }
}

