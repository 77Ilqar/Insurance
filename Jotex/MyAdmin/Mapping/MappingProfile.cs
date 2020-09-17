using AutoMapper;
using MyAdmin.Models;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAdmin.Mapping
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<Slider, SliderViewModel>();
            CreateMap<SliderViewModel, Slider>();

            //CreateMap<TestimonialItem, TestimonialItemViewModel>();

            //CreateMap<Brand, BrandViewModel>();

            //CreateMap<AgentPicture, AgentPictureViewModel>();


            //CreateMap<About, HomeViewModel>();
            //CreateMap<Service, HomeViewModel>();
            //CreateMap<FunFact, HomeViewModel>();
            //CreateMap<Cta, HomeViewModel>();
            //CreateMap<Plan, HomeViewModel>();

            //CreateMap<About, PagesViewModel>();
            //CreateMap<FunFact, PagesViewModel>();
            //CreateMap<FAQ, PagesViewModel>();


            //CreateMap<Service, ServiceViewModel>();
            //CreateMap<CategoryDetail, ServiceViewModel>();
            //CreateMap<TestimonialItem, ServiceViewModel>();


            //CreateMap<Study, StudyViewModel>();
            //CreateMap<StudySingle, StudyViewModel>();
            //CreateMap<AgentPicture, StudyViewModel>();
            //CreateMap<StudyDetail, StudyViewModel>();

            //CreateMap<Query, ContactViewModel>();


            //CreateMap<BlogItem, BlogItemListViewModel>();


            //CreateMap<BlogItem, BlogItemViewModel>();
            //CreateMap<Comment, BlogItemViewModel>();
            //CreateMap<Comment, CommentViewModel>();
        }
    }
}
