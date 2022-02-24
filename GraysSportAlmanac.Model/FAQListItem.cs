using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
   public class FAQListItem
    {
        public int FaqId { get; set; }

        [Display(Name = "Question")]
        public string Question { get; set; }

        public int ProfileId { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }

        public int AnswerId { get; set; }

        [Display(Name = "Answer")]
        public string AnswerContent { get; set; }



    }
}
