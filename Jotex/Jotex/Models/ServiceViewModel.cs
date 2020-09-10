using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repository.Models;

namespace Jotex.Models
{
    public class ServiceViewModel
    {
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<CategoryDetail> CategoryDetails { get; set; }
        public IEnumerable<TestimonialItem> TestimonialItems { get; set; }

    }
}
