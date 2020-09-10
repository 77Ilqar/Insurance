using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
    public class HomeViewModel
    {
        public IEnumerable<FunFact> FunFacts { get; set; }
        public IEnumerable<About> Abouts { get; set; }

        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Cta> Ctas { get; set; }
        public IEnumerable<Plan> Plans { get; set; }

    }
}
