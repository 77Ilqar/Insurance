using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Jotex.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;

namespace Jotex.Controllers
{
    public class BlogController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBlogRepository _blogRepository;

        public BlogController(IMapper mapper,
                              IBlogRepository blogRepository)
        {
            _mapper = mapper;
            _blogRepository = blogRepository;
        }
        public IActionResult Index(BlogItemSearchViewModel searchViewModel)
        {

            var item = _blogRepository.GetBlogItems(searchViewModel.Limit,
                                                           (searchViewModel.Page - 1) * searchViewModel.Limit);

            //var blogItemCount = _blogRepository.GetBlogItemsCount();

            var model = new BlogItemListViewModel
            {

                BlogItemViewModels = _mapper.Map<IEnumerable<BlogItem>, IEnumerable<BlogItemViewModel>>(item),

                Page = searchViewModel.Page,

                Limit = searchViewModel.Limit,

                Count = searchViewModel.Count
            };



            return View(model);
        }
        public IActionResult BlogSingle()
        {
            return View();
        }
    }
}
