using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
    public class PostEdit
    {
        public int PostId { get; set; }
        public string BetDate { get; set; }
        public string Bet { get; set; }
        public decimal Risked { get; set; }
        public int Odds { get; set; }
        public string Result { get; set; }
        public decimal Payout { get; set; }
    }
}
