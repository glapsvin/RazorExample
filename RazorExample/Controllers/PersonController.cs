using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RazorExample.Controllers
{
    
    public class PersonController : Controller
    {
        
        public IActionResult NewPerson()
        {
            return View();
        }

        public IActionResult NewPersonTag()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewPerson(Models.Person personModel)
        {
            if (ModelState.IsValid)
            {
                /*
                 * Since the state is valid here we would do normal processing of the form (saving data in DB etc) 
                 */

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(personModel);
            }
        }

        [HttpPost]
        public IActionResult NewPersonTag(Models.Person personModel)
        {
            if (ModelState.IsValid)
            {
                /*
                 * Since the state is valid here we would do normal processing of the form (saving data in DB etc) 
                 */

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(personModel);
            }
        }

        public IActionResult VerifyEmail(string email)
        {
            var emailList = new List<string>()
            {
                "x@y.com"              
            };

            if (emailList.Contains(email))
            {
                return Json("Email is already taken");
            }

            return Json(true);
        }
    }
}