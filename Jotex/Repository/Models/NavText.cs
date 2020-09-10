using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class NavText : BaseEntity
    {
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }

        [ForeignKey("StudySingle")]
        public int SingleId { get; set; }

        public StudySingle StudySingle { get; set; }
    }
}
