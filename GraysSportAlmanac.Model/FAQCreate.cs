﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
    public class FAQCreate
    {
        public string Question { get; set; }
        public int ProfileId { get; set; }

        public int CommentId { get; set; }
        public string ContentComment { get; set; }



    }
}
