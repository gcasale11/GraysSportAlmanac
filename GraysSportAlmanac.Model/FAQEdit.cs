﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
    public class FAQEdit
    {
        public int FaqId { get; set; }

        [Display(Name = "Question")]
        public string Question { get; set; }


    }
}
