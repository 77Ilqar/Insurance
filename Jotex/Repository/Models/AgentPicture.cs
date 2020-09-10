using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class AgentPicture : BaseEntity
    {


        [Required]
        [MaxLength(50)]
        public string Fullname { get; set; }

        [Required]
        [MaxLength(50)]
        public string Duty { get; set; }

        [Required]
        [MaxLength(50)]
        public string Picture { get; set; }

    }
}
