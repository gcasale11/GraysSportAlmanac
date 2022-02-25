using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
   public class AnswerEdit
    {
        public int AnswerId { get; set; }

        [Display(Name = "Anwser")]
        public string AnswerContent { get; set; }

    }
}
