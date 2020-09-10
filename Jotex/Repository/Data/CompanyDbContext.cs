using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class CompanyDbContext:DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options) { }


        public DbSet<About> Abouts { get; set; }
        public DbSet<FunFact> FunFacts { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<AgentPicture> AgentPictures { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryDetail> CategoryDetails { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Cta> Ctas { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<NavText> NavTexts { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<PlanItem> PlanItems { get; set; }
        public DbSet<Query> Queries { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SliderItem> SliderItems { get; set; }
        public DbSet<Study> Studies { get; set; }
        public DbSet<StudyDetail> StudyDetails { get; set; }
        public DbSet<StudySingle> StudySingles { get; set; }
        public DbSet<TestimonialItem> TestimonialItems { get; set; }


        public DbSet<BlogItem> BlogItems { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}
