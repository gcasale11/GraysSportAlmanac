using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
    public class PostCreate
    {
        public int ProfileId { get; set; }
        


        [Required]
        [Display(Name = "Bet Date")]
        public string BetDate { get; set; }

        [Required]
        [Display(Name = "Bet Description")]
        public string Bet { get; set; }

        [Required]
        [Display(Name = "Amount Risked")]
        public decimal Risked { get; set; }

        [Required]
        [Display(Name = "Odds")]
        public int Odds { get; set; }


        [Display(Name = "Result")]
        public string Result { get; set; }
      
        [Display(Name = "Total Payout")]
        public decimal Payout { get; set; }
    }
}
