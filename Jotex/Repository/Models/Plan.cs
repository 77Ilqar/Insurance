using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Plan : BaseEntity
    {
        [Required]
        [MaxLength(300)]
        public string Title { get; set; }

        [Required]
        [MaxLength(300)]
        public string Subtitle { get; set; }



        public ICollection<PlanItem> PlanItems { get; set; }

    }
}
