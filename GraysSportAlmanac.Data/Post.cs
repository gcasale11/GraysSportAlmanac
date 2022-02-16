﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Data
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public Guid AuthorId { get; set; }

        [ForeignKey(nameof(Profile))]
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }

        //property for User Name?

        public string BetDate { get; set; }
        public string Bet { get; set; }
        public decimal Risked { get; set; }
        public int Odds { get; set; }
        public string Result { get; set; }
        public decimal Payout { get; set; }

        public virtual ICollection<Comment> CollectionComment { get; set; }
    }
}
