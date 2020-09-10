using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
    public class BlogItemListViewModel
    {
        
        public IEnumerable<BlogItemViewModel> BlogItemViewModels { get; set; }

        public int Page { get; set; }
        public int Limit { get; set; }

        public int Count { get; set; }
    }
    public class BlogItemSearchViewModel
    {
        public BlogItemSearchViewModel()
        {
            Page = 1;
            Limit = 7;
            Count = 20;
        }

        public int Id { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public int Count { get; set; }
    }
}
