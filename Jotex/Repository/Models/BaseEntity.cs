using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public abstract class BaseEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public DateTime AddedDate { get; set; }
        [Required]
        public DateTime ModifiedDate { get; set; }

        [Required]
        public string AddedBy { get; set; }

        [Required]
        public string ModifiedBy { get; set; }
    }
}
