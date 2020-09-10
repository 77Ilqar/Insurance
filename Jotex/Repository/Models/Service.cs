using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Service : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        public string Subtitle { get; set; }





        [Required]
        [MaxLength(500)]
        public string Text { get; set; }

        [Required]
        [MaxLength(300)]
        public string Key { get; set; }

        [Required]
        [MaxLength(300)]
        public string Value { get; set; }

        public ICollection<Category> Categories { get; set; }

        public ICollection<CategoryDetail> CategoryDetails { get; set; }
    }
}
