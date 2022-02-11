using System;
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
        public Guid PostId { get; set; }

        [ForeignKey(nameof(Profile))]
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }

        //property for User Name?

        public DateTime BetDate { get; set; }
        public string Bet { get; set; }
        public decimal Risked { get; set; }
        public int Odds { get; set; }
        public char Result { get; set; }
        public decimal Payout { get; set; }
    }
}
