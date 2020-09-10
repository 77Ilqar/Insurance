using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class About : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(300)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        public string Subtitle { get; set; }

        [Required]
        [MaxLength(300)]
        public string PhoneText { get; set; }
        [Required]
        [MaxLength(300)]
        public string Email { get; set; }

        [Required]
        [MaxLength(300)]
        public string Text { get; set; }

        [Required]
        [MaxLength(500)]
        public string SubText { get; set; }


        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        [Required]
        [MaxLength(100)]
        public string Logo { get; set; }

        [Required]
        [MaxLength(50)]

        public string ActionText { get; set; }

        [Required]
        [MaxLength(200)]
        public string EndPoint { get; set; }

        public ICollection<Feature> Features { get; set; }
    }
}
