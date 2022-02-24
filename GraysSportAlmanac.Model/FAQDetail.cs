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
        public string Question { get; set; }

        public int ProfileId { get; set; }
        public string UserName { get; set; }

        public int AnswerId { get; set; }
        public string AnswerContent { get; set; }

        [Display(Name = "Create")]
        public DateTimeOffset CreateUtc { get; set; }

    }
}
