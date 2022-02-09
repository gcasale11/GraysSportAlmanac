using System;
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
        public string ContentComment { get; set; }

        //public int PostId {get; set;}

        //public string UserName {get; set;}
        //public DateTime BetDate {get; set;}
        //public string Bet {get; set;}
        //public decimal Risked {get; set;}
        //public int Odds {get; set;}
        //public string Result {get; set;}
        //public decimal PayOut {get; set;}
    }
}
