using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
   public class FAQListItem
    {
        public int FaqId { get; set; }
        public string Question { get; set; }

        public int ProfileId { get; set; }
        public string UserName { get; set; }

        public int AnswerId { get; set; }

        public string AnswerContent { get; set; }



    }
}
