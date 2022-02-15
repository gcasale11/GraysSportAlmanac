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

    /*
        [ForeignKey(nameof(Group))]
        public Group GroupId { get; set; }

        [ForeignKey(nameof(Profile))]
        public Profile ProfileId { get; set; }
    */

        public DateTime BetDate { get; set; }
        public decimal Risked { get; set; }
        public int Odds { get; set; }
        public string Result { get; set; }
        public decimal Payout { get; set; }
    }
}
