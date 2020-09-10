using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class StudyDetail:BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Key { get; set; }

        [Required]
        [MaxLength(200)]
        public string Value { get; set; }

        [ForeignKey("StudySingle")]
        public int StudySingleId { get; set; }





        public StudySingle StudySingle { get; set; }
    }
}
