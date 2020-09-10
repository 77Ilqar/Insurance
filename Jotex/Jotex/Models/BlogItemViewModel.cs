using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repository.Models;

namespace Jotex.Models
{
    public class BlogItemViewModel:BaseEntity
    {

        public string Title { get; set; }

        public string ShortSubtitle { get; set; }
        public string ActionText { get; set; }

        public string EndPoint { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public string Subtitle { get; set; }

        public string Quote { get; set; }

        public string WrittenBy { get; set; }

        public string Text { get; set; }

        public string Subtext { get; set; }
        public ICollection<Tag> Tags { get; set; }

    }
}
