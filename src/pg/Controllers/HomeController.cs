using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pg.Models;

namespace pg.Controllers
{
    public class HomeController : Controller
    {
       [HttpGet]  
        public ActionResult Index() {  
                return View();  
            }  
            [HttpPost]  
        public ActionResult Index(AdditionViewModel model, string command) {  
            if (command == "add") {  
                model.Result = model.A + model.B;  
            }  
            if (command == "sub") {  
                model.Result = model.A - model.B;  
            }  
            if (command == "mul") {  
                model.Result = model.A * model.B;  
            }  
            if (command == "div") {  
                model.Result = model.A / model.B;  
            }  
            return View(model);  
        }  
    }  
}
