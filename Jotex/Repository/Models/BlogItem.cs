using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class BlogItem : BaseEntity
    {
        

        [Required]
        [MaxLength(300)]
        public string Title { get; set; }
        [Required]
        [MaxLength(300)]
        public string ShortSubtitle { get; set; }

        [MaxLength(100)]
        public string Image { get; set; }

        [MaxLength(300)]
        public string Video { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Subtitle { get; set; }
        [Required]
        [MaxLength(300)]
        public string Quote { get; set; }
        [Required]
        [MaxLength(50)]
        public string WrittenBy { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Text { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Subtext { get; set; }

        [MaxLength(100)]
        public string ActionText { get; set; }

        [MaxLength(100)]
        public string EndPoint { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
