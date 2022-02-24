using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
    public class ProfileEdit
    {
        
        public int ProfileId { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Display(Name = "Bio")]
        public string Bio { get; set; }

        [Display(Name = "Record W-L-P")]
        public string Record { get; set; }

        [Display(Name = "Total Amount Risked")]
        public decimal TotalRisked { get; set; }

        [Display(Name = "Account Total")]
        public decimal TotalAccount { get; set; }

        [Display(Name = "Preferred Unit Size")]
        public decimal UnitSize { get; set; }

        [Display(Name = "Total Units Up/Down")]
        public int Units { get; set; }


    }
}
