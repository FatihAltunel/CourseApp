using Microsoft.AspNetCore.Mvc;
using CourseApp.Models;
namespace CourseApp.Controllers;

public class CourseController : Controller{

    public IActionResult Index(){
        return View();
    }
     public IActionResult Details(int id){

        var courses = Repository.Courses;
        foreach (var item in courses){
            if(item.Id == id){
                return View(item); 
            }
        }
        var e = "error";
        return View(e);
    }
     public IActionResult List(){
        
        return View(Repository.Courses);
    }
}