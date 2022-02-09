﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
    public class CommentListItem
    {
        public int CommentId { get; set; }

        public string ContentComment { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        //public int PostId {get; set;}
        //public string Title {get; set;}
        //public string Content {get; set;}

    }
}
