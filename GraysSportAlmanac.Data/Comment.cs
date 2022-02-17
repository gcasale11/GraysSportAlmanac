using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Data
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public Guid AuthorId { get; set; }

        public string UserName { get; set; }

        [Required]
        public string ContentComment { get; set; }

        [Required]
        public DateTimeOffset CreateUtc { get; set; }


        [ForeignKey(nameof(Profile))]
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }

        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }

        public virtual Post Post { get; set; }

        [ForeignKey(nameof(FAQ))]
        public int? FAQId { get; set; }
        public virtual FAQ FAQ { get; set; }

        
    }
}
