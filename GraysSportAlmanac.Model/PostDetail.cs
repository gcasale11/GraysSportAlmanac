using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
   public class PostDetail
    {
        public int PostId { get; set; }

        [Display(Name = "Result")]
        public string Result { get; set; }

        [Display(Name = "Total Payout")]
        public decimal Payout { get; set; }
    }
}
