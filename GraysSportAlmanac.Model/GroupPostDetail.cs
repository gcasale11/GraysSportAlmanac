using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
   public class GroupPostDetail
    {
        [Key]
        public int GroupPostId { get; set; }

        
        public int GroupId { get; set; }

        
        public int ProfileId { get; set; }
    

        public string BetDate { get; set; }
        public decimal Risked { get; set; }
        public int Odds { get; set; }
        public string Result { get; set; }
        public decimal Payout { get; set; }
    }
}
