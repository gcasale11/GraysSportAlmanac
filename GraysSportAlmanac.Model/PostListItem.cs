using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
  public class PostListItem
    {
        public int PostId { get; set; }

        public int ProfileId { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Display(Name = "Bet Date")]
        public string BetDate { get; set; }

        [Display(Name = "Bet Description")]
        public string Bet { get; set; }

        [Display(Name = "Amount Risked")]
        public decimal Risked { get; set; }

        [Display(Name = "Odds")]
        public int Odds { get; set; }

        [Display(Name = "Result")]
        public string Result { get; set; }

        [Display(Name = "Total Payout")]
        public decimal Payout { get; set; }
    }
}
