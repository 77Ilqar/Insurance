using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jotex.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.ContentRepositories;

namespace Jotex.Controllers
{
    public class StudiesController : Controller
    {
        private readonly IContentRepository _contentRepository;
        public StudiesController(IContentRepository contentRepository)
        {

            _contentRepository = contentRepository;
        }
        public IActionResult Index()
        {
            var model = new StudyViewModel
            {
                AgentPictures=_contentRepository.GetAgentPictures(),
                Studies=_contentRepository.GetStudies()
            };
            return View(model);
        }
        public IActionResult StudiesSingle()
        {
            var model = new StudyViewModel
            {
                AgentPictures = _contentRepository.GetAgentPictures(),
                StudySingles=_contentRepository.GetStudySingles(),
                StudyDetails=_contentRepository.GetStudyDetails()
            };
            return View(model);
        }
    }
}
