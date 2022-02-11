using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
    public class FAQDetail
    {
        public int FaqId { get; set; }

        public Guid AuthorId { get; set; }

        [Display(Name = "Create")]
        public DateTimeOffset CreateUtc { get; set; }

        public int PostId { get; set; }
        public int CommentId { get; set; }
    }
}
