using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
   public class AnswerDetail
    {
        public int AnswerID { get; set; }

        [Display(Name = "Answer")]
        public string AnswerContent { get; set; }
    }
}
