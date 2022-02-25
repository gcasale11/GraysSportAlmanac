using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
    public class CommentDetail
    {
        public int CommentId { get; set; }

        [Display(Name = "Comment")]
        public string ContentComment { get; set; }

        public int PostId { get; set; }


      //  public int GroupPostId { get; set; }

        public Guid AuthorId { get; set; }


        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
