using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Jotex.Models;
using Repository.Repositories.ContentRepositories;

namespace Jotex.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContentRepository _contentRepository;
        public HomeController( IContentRepository contentRepository)
        {

            _contentRepository = contentRepository;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Abouts = _contentRepository.GetAbouts(),
                Services = _contentRepository.GetServiceWithCategories(),
                FunFacts = _contentRepository.GetFunFacts(),
                Ctas = _contentRepository.GetCtas(),
                Plans = _contentRepository.GetPlansWithItems()
                
                
            };
            return View(model);
        }
    }
}
