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
        [Required]
        [MinLength(10, ErrorMessage = "Please enter date in 00/00/0000 format")]
        public DateTime BetDate { get; set; }

        [Required]
        public string Bet { get; set; }

        [Required]
        [MinLength(4, ErrorMessage ="Please enter the amount risked in 1.00 format")]
        public decimal Risked { get; set; }

        [Required]
        public int Odds { get; set; }

        [Required]
        [MaxLength(1,ErrorMessage ="Please enter the result of the wager with W for a win, L for a loss, P for a push")]
        public char Result { get; set; }

        public decimal Payout { get; set; }
    }
}
