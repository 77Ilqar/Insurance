using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly CompanyDbContext _context;
        public BlogRepository(CompanyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<BlogItem> GetBlogItems(int take, int skip)
        {
            return _context.BlogItems.Include("Tags")
                                    .OrderByDescending(bi => bi.AddedDate)
                                    .Take(take)
                                    .Skip(skip)
                                    .ToList();
        }

        //public IEnumerable<BlogItem> GetBlogItemsById(int take, int skip)
        //{
        //    return _context.BlogItems.Include("Tags")
        //                             .Where(bi => bi.Status)
        //                             .OrderByDescending(bi => bi.AddedDate)
        //                             .Take(take)
        //                             .Skip(skip)
        //                             .ToList();
        //}

        public int GetBlogItemsCount()
        {
            return _context.BlogItems.Where(bi => bi.Status)
                                     .Count();
        }
    }
}
