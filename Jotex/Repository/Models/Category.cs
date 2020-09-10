using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Category : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Subtitle { get; set; }

        [Required]
        [MaxLength(100)]
        public string Image { get; set; }

        [Required]
        [MaxLength(50)]
        public string Icon { get; set; }

        [Required]
        [MaxLength(50)]
        public string EndPoint { get; set; }

        [Required]
        public int ServiceId { get; set; }

        public Service Service { get; set; }

        public ICollection<CategoryDetail> CategoryDetails { get; set; }
    }
}
