using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Comment : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Text { get; set; }

        [Required]
        [MaxLength(50)]
        public string Website { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public bool CommentReply { get; set; }



        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }

        [Required]
        [MaxLength(200)]
        public string EndPoint { get; set; }

    }
}
