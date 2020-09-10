using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
    public class PagesViewModel
    {
        public IEnumerable<FunFact> FunFacts { get; set; }
        public IEnumerable<About> Abouts { get; set; }

        public IEnumerable<FAQ> FAQs { get; set; }
    }
}
