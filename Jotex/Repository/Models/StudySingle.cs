using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class StudySingle : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }

        [Required]
        [MaxLength(300)]
        public string StudyName { get; set; }

        [Required]
        [MaxLength(300)]
        public string Title { get; set; }
        [Required]
        [MaxLength(300)]
        public string Subtitle { get; set; }

        [Required]
        [MaxLength(500)]
        public string Text1 { get; set; }

        [Required]
        [MaxLength(500)]
        public string Text2 { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text3 { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text4 { get; set; }

        public ICollection<StudyDetail> StudyDetails { get; set; }
        public ICollection<NavText> NavTexts { get; set; }
    }
}
