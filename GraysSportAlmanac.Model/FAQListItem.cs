﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
   public class FAQListItem
    {
        public int FaqId { get; set; }

        public int PostId { get; set; }
        public string Question { get; set; }

        public int CommentId { get; set; }
        public string Response { get; set; }
    }
}
