using System;
using Microsoft.AspNetCore.Mvc;
using NetChelt.Models;

namespace Namespace
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string UserName, string Password)
        {
           if(UserModel.verificausernameparola(UserName,Password)==true){
               //return Content($"Hello {UserName}");
               return RedirectToAction("Cheltuieli");
           }else{
               return View();
               //return Content($"login incorect");
           }
            
        }
        public IActionResult Cheltuieli()
        {
            return View();
        }
    }
}