using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jotex.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Repository.Data;
using Repository.Models;
using Repository.Repositories.ContentRepositories;

namespace Jotex.Controllers
{
    public class ContactController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }

    }
}
