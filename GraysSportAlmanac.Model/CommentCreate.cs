﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
    public class CommentCreate
    {
        
        [Required]
        [Display(Name = "Comment")]
        public string ContentComment { get; set; }


        public int ProfileId { get; set; }
      
        public int PostId { get; set; }

        public int? FaqId { get; set; }

       // public int GroupPostId { get; set; }


    }
}
