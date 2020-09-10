using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class PlanItem : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public int PlanId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Icon { get; set; }
        [Required]
        [MaxLength(500)]
        public string Policy { get; set; }

        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }

        [Required]
        [MaxLength(200)]
        public string EndPoint { get; set; }

        public Plan Plan { get; set; }

    }
}
