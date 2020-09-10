using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class CategoryDetail : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Key { get; set; }

        [Required]
        [MaxLength(200)]
        public string Value { get; set; }

        [Required]
        public int ServiceId { get; set; }
        [Required]
        public int CategoryId { get; set; }




        public Category Category { get; set; }
        public Service Service { get; set; }
    }
}
