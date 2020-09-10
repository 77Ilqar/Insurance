using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Cta : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(200)]
        public string Subtitle { get; set; }

        [Required]
        [MaxLength(50)]
        public string Text { get; set; }

        [Required]

        public string Phone { get; set; }

        [Required]
        [MaxLength(50)]
        public string Image { get; set; }

        [Required]
        [MaxLength(50)]
        public string Detail { get; set; }

        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }

        [Required]
        [MaxLength(200)]
        public string EndPoint { get; set; }

    }
}
