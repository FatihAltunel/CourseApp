using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CourseApp.Models;

namespace CourseApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index(){
        return View();
    }
    public IActionResult Contact(){
        return View();
    }
}
