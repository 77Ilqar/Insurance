using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Agent : BaseEntity
    {

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }


        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }

        [Required]
        [MaxLength(200)]
        public string EndPoint { get; set; }
    }
}
