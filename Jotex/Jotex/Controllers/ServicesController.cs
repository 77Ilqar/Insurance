using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jotex.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.ContentRepositories;

namespace Jotex.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IContentRepository _contentRepository;
        public ServicesController(IContentRepository contentRepository)
        {

            _contentRepository = contentRepository;
        }

        public IActionResult Index()
        {
            var model = new ServiceViewModel
            {
                Services=_contentRepository.GetServiceWithCategories(),
                
                TestimonialItems=_contentRepository.GetTestimonialItems(),

                CategoryDetails=_contentRepository.GetCategoryDetails()
                
            };
            return View(model);
        }
    }
}
