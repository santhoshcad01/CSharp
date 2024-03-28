using Microsoft.AspNetCore.Mvc;

namespace OBOOKS.Controllers
{
    [Route("[contorller]")]
  public class TraineeController : Controller
  {
    
    [Route("Trainee/Dashboard")]
  public IActionResult Dashboard(){
    return View("Dashboard","_LayoutTrainee");

  }
   public IActionResult EnrollinCourse(){
    return View("Dashboard","_LayoutTrainee");

  }
    public IActionResult MyCourses(){
    return View("Dashboard","_LayoutTrainee");

  }
    public IActionResult ViewSessionsSchedule(){
    return View("Dashboard","_LayoutTrainee");

  }
    public IActionResult Grades(){
    return View("Dashboard","_LayoutTrainee");

  }
    public IActionResult Resources(){
    return View("Dashboard","_LayoutTrainee");

  }
  


  }

}