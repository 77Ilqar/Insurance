using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public interface IBlogRepository
    {

        IEnumerable<BlogItem> GetBlogItems(int take, int skip);
        int GetBlogItemsCount();
    }
}
