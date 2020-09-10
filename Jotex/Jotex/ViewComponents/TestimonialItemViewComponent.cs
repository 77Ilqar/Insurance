using AutoMapper;
using Jotex.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.ViewComponents
{
    public class TestimonialItemViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;

        public TestimonialItemViewComponent(IMapper mapper,
                                   IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }

        public IViewComponentResult Invoke()
        {
            var items = _contentRepository.GetTestimonialItems();

            var model = _mapper.Map<IEnumerable<TestimonialItem>, IEnumerable<TestimonialItemViewModel>>(items);

            return View(model);
        }
    }
}
