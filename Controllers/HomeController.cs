using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AuthDemo1.Models;
using Microsoft.AspNetCore.Authorization;

namespace AuthDemo1.Controllers;


public class HomeController : Controller{

    [Authorize(Roles ="CTO,Project Manager,Employee")]
    public IActionResult Index()
    {
        return View();
    }

    [Authorize(Roles ="CTO")]
    public IActionResult Privacy()
    {
        return View();
    }
    [Authorize(Roles ="CTO,Project Manager")]
    public IActionResult AppSettings(){
        return View();
    }

}
