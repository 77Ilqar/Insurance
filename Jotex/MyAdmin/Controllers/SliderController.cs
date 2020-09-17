using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAdmin.Filters;
using MyAdmin.Libs;
using MyAdmin.Models;
using Repository.Models;
using Repository.Repositories.ContentRepositories;
using Repository.Services;

namespace MyAdmin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class SliderController : Controller
    {
        private Repository.Models.MyAdmin _admin => RouteData.Values["Admin"] as Repository.Models.MyAdmin;
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;
        private readonly ICloudinaryService _cloudinaryService;
        private readonly IFileManager _fileManager;

        public SliderController(IMapper mapper,
                                IContentRepository contentRepository,
                                ICloudinaryService cloudinaryService,
                                IFileManager fileManager)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
            _cloudinaryService = cloudinaryService;
            _fileManager = fileManager;
        }

        public IActionResult Index()
        {
            var slider = _contentRepository.GetSlidersForAdmin();
            var model = _mapper.Map<IEnumerable<Slider>, IEnumerable<SliderViewModel>>(slider);
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SliderViewModel slider)
        {

            if (ModelState.IsValid)
            {
                Slider model = _mapper.Map<SliderViewModel, Slider>(slider);

                model.AddedBy = _admin.Fullname;
                _contentRepository.CreateSlider(model);
                return RedirectToAction("index");
            }
            return View(slider);

        }

        //public IActionResult Edit(int id)
        //{
        //    SliderItem slider = _contentRepository.GetSliderItemById(id);
        //    if (slider == null) return NotFound();
        //    var model = _mapper.Map<SliderItem, SliderViewModel>(slider);
        //    return View(model);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(SliderViewModel slider)
        //{
        //    if (slider == null) return NotFound();

        //    if (ModelState.IsValid)
        //    {
        //        SliderItem model = _mapper.Map<SliderViewModel, SliderItem>(slider);
        //        model.ModifiedBy = _admin.Fullname;
        //        model.ModifiedDate = DateTime.Now;

        //        SliderItem sliderToUpdate = _homeRepository.GetSliderById(slider.Id);
        //        if (sliderToUpdate == null) return NotFound();
        //        _homeRepository.UpdateSlider(sliderToUpdate, model);
        //        return RedirectToAction("index");
        //    }
        //    return View(slider);
        //}


        //public IActionResult Delete(int id)
        //{
        //    SliderItem slider = _homeRepository.GetSliderById(id);
        //    if (slider == null) return NotFound();
        //    _homeRepository.DeleteSlider(slider);
        //    return RedirectToAction("index");
        //}
        [HttpPost]
        public IActionResult Upload(IFormFile file, int? sliderId)
        {

            var filename = _fileManager.Upload(file);
            var publicId = _cloudinaryService.Store(filename);
            _fileManager.Delete(filename);


            if (sliderId != null)
            {
                Slider slidePhoto = new Slider
                {
                    AddedBy = _admin.Fullname,
                    AddedDate = DateTime.Now,
                    Image = publicId,


                };
                _contentRepository.AddPhoto(slidePhoto);
            }

            return Ok(new
            {
                filename = publicId,
                src = _cloudinaryService.BuildUrl(publicId)
            });
        }

        //[HttpPost]
        //public IActionResult Remove(string name, int? id)
        //{
        //    if (id != null)
        //    {
        //        _homeRepository.RemovePhotoById((int)id);
        //    }

        //    _cloudinaryService.Delete(name);

        //    return Ok(new { status = 200 });
        //}
    }
}
