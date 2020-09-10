using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Feature : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Icon { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string Subtitle { get; set; }

        public int AboutId { get; set; }

        public About About { get; set; }

    }
}
