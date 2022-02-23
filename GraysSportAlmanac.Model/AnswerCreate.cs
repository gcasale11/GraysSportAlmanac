using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
    public class AnswerCreate
    {
        public int FAQId { get; set; }
        public int ProfileId { get; set; }
        public string UserName { get; set; }
        public string AnswerContent { get; set; }
    }
}
