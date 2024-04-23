using Microsoft.AspNetCore.Mvc;
using CourseApp.Models;
namespace CourseApp.Controllers;

public class CourseController : Controller{

    public IActionResult Index(){
        return View();
    }
     public IActionResult Details(int? id){
        if(id==null){
            return Redirect("/Course/List");
        }
        var course = Repository.getById((int)id);
        return View(course);
    }
     public IActionResult List(){
        
        return View(Repository.Courses);
    }
}