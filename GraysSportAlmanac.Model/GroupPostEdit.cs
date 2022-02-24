using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
    public class GroupPostEdit
    {
        [Key]
        public int GroupPostId { get; set; }
        public string Result { get; set; }
        public decimal Payout { get; set; }
    }
}
