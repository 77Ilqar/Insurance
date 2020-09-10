using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class Tag:BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [ForeignKey("BlogItem")]
        public int BlogId { get; set; }

        public BlogItem BlogItem { get; set; }
    }
}
