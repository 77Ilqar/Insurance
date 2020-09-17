using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public class ContentRepository : IContentRepository
    {
        private readonly CompanyDbContext _context;

        public ContentRepository(CompanyDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Agent> GetAgents()
        {
            return _context.Agents.Where(a => a.Status)
                                  .ToList();
        }
        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.OrderByDescending(b => b.AddedDate)
                                  .ToList();
        }
        public IEnumerable<SliderItem> GetSliderItems()
        {
            return _context.SliderItems.Where(s => s.Status)
                                       .OrderBy(s => s.OrderBy)
                                       .ToList();
        }
        public IEnumerable<TestimonialItem> GetTestimonialItems()
        {
            return _context.TestimonialItems.Where(s => s.Status)
                                            .OrderBy(s => s.OrderBy)
                                            .ToList();
        }
        public IEnumerable<About> GetAbouts()
        {
            return _context.Abouts
                                  .Include("Features")
                                  .Where(a => a.Status)
                                  .ToList();
        }
        public IEnumerable<AgentPicture> GetAgentPictures()
        {
            return _context.AgentPictures.Where(a => a.Status)
                                         .Take(7)
                                         .ToList();
        }
        public IEnumerable<Service> GetServiceWithCategories()
        {
            return _context.Services.Include("Categories")
                                    .Include("CategoryDetails")
                                    .Where(a => a.Status)
                                    .ToList();
        }
        public IEnumerable<FunFact> GetFunFacts()
        {
            return _context.FunFacts.Where(a => a.Status)
                                    .ToList();
        }
        public IEnumerable<Cta> GetCtas()
        {
            return _context.Ctas.Where(c => c.Status)
                                .ToList();
        }
        public IEnumerable<Plan> GetPlansWithItems()
        {
            return _context.Plans.Include("PlanItems")
                                 .Where(p => p.Status)
                                 .ToList();
        }
        public IEnumerable<FAQ> GetFAQs()
        {
            return _context.FAQs.Where(f => f.Status).ToList();
        }
        public IEnumerable<CategoryDetail> GetCategoryDetails()
        {
            return _context.CategoryDetails.Where(c => c.Status).ToList();
        }
        public IEnumerable<Study> GetStudies()
        {
            return _context.Studies.Where(s => s.Status).ToList();
        }
        public IEnumerable<StudySingle> GetStudySingles()
        {
            return _context.StudySingles.Where(s => s.Status).ToList();
        }
        public IEnumerable<StudyDetail> GetStudyDetails()
        {
            return _context.StudyDetails.Where(s => s.Status).ToList();
        }
        public IEnumerable<Query> GetQueries()
        {
            return _context.Queries.Where(q => q.Status).ToList();
        }
        public SliderItem CreateSliderItem(SliderItem model)
        {
            model.AddedDate = DateTime.Now;
            _context.SliderItems.Add(model);
            _context.SaveChanges();
            return model;
        }

        public void AddPhoto(SliderItem slidePhoto)
        {
            _context.SliderItems.Add(slidePhoto);
            _context.SaveChanges();
        }

        public IEnumerable<SliderItem> GetSliderItemsForAdmin()
        {
            return _context.SliderItems.ToList();
        }

        public IEnumerable<Slider> GetSlidersForAdmin()
        {
            return _context.Sliders.ToList();
        }

        public void AddPhoto(Slider slidePhoto)
        {
            _context.Sliders.Add(slidePhoto);
            _context.SaveChanges();
        }
    }
}
