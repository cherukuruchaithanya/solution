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
<<<<<<< HEAD
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
=======
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
         public IActionResult Html()
        {
            return Content("<!DOCTYPE html><html><body>Hello World</body></html>", "text/html");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
>>>>>>> 3938947c5b11c4c2f17b12874aca4864cf2b8fc3
}
