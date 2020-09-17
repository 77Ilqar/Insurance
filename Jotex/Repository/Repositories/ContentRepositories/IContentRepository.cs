using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public interface IContentRepository
    {
        

        IEnumerable<SliderItem> GetSliderItems();
        IEnumerable<SliderItem> GetSliderItemsForAdmin();
        SliderItem CreateSliderItem(SliderItem model);



        IEnumerable<Brand> GetBrands();
        IEnumerable<TestimonialItem> GetTestimonialItems();
        IEnumerable<Agent> GetAgents();
        IEnumerable<AgentPicture> GetAgentPictures();


        IEnumerable<About> GetAbouts();
        IEnumerable<FunFact> GetFunFacts();


        IEnumerable<Service> GetServiceWithCategories();

        IEnumerable<Cta> GetCtas();

        IEnumerable<Plan> GetPlansWithItems();

        IEnumerable<FAQ> GetFAQs();

        IEnumerable<CategoryDetail> GetCategoryDetails();

        IEnumerable<Study> GetStudies();

        IEnumerable<StudySingle> GetStudySingles();

        IEnumerable<StudyDetail> GetStudyDetails();


        IEnumerable<Query> GetQueries();
        void AddPhoto(SliderItem slidePhoto);
        IEnumerable<Slider> GetSlidersForAdmin();
        void AddPhoto(Slider slidePhoto);
    }
}
