using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class FAQ : BaseEntity
    {

        [Required]
        [MaxLength(300)]
        public string Key { get; set; }

        [Required]
        [MaxLength(500)]
        public string Value { get; set; }



    }
}
