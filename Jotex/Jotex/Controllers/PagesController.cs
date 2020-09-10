using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jotex.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.ContentRepositories;

namespace Jotex.Controllers
{
    public class PagesController : Controller
    {
        private readonly IContentRepository _contentRepository;
        public PagesController(IContentRepository contentRepository)
        {

            _contentRepository = contentRepository;
        }
        public IActionResult Aboutus()
        {
            var model = new PagesViewModel
            {
                Abouts = _contentRepository.GetAbouts(),
                FunFacts = _contentRepository.GetFunFacts()
            };
            return View(model);
        }

        public IActionResult FAQ()
        {
            var model = new PagesViewModel
            {
                FAQs = _contentRepository.GetFAQs()
            };
            return View(model);
        }
    }
}
