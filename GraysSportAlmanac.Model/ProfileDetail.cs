using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
    public class ProfileDetail
    {
        [Display(Name = "Profile ID")]
        public int ProfileId { get; set; }
        public Guid OwnerId { get; set; }
        
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Display(Name = "Bio")]
        public string Bio { get; set; }


        [Display(Name = "Record")]
        public string Record { get; set; }

        [Display(Name = "Total Risked")]
        public decimal TotalRisked { get; set; }

        [Display(Name = "Total Account")]
        public decimal TotalAccount { get; set; }

        [Display(Name = "Unit Size")]
        public decimal UnitSize { get; set; }

        [Display(Name = "Units")]
        public int Units { get; set; }

    }
}
