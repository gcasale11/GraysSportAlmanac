using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Data
{
    public class FAQ
    {
        [Key]
        public int FaqId { get; set; }

        [Required]
        public Guid AuthorId { get; set; }
        

        /*[ForeignKey(nameof(Post))]
        public int PostId { get; set; }
        public string Question { get; set; }

        [ForeignKey(nameof(Comment))]
        public int CommentId { get; set; }
        public string Response { get; set; }*/
        



    }
}
