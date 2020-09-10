using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class FunFact : BaseEntity
    {
        [Required]
        public bool IsInIndex { get; set; }
        [Required]
        [MaxLength(100)]
        public string Number { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Subtitle { get; set; }
        [Required]
        [MaxLength(100)]
        public string Icon { get; set; }
        [Required]
        [MaxLength(100)]
        public string ActionText { get; set; }
        [Required]
        [MaxLength(100)]
        public string EndPoint { get; set; }
    }
}
