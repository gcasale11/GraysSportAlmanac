using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Data
{
    public class GroupPost
    {
        [Key]
        public Guid GroupPostId { get; set; }

        //I think this might need to be in the Group instead of here but not 100% sure
        /*[ForeignKey(nameof(Group))]
        public int GroupId { get; set; }*/

        [ForeignKey(nameof(Profile))]
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }

        public DateTime BetDate { get; set; }
        public decimal Risked { get; set; }
        public int Odds { get; set; }
        public string Result { get; set; }
        public decimal Payout { get; set; }
    }
}
