﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
   public class CommentEdit
    {
        public int CommentId { get; set; }

        public string ContentComment { get; set; }

        public int PostId { get; set; }

        public int FaqId { get; set; }

        public int GroupPostId { get; set; }

    }
}
