using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
    public class ProfileListItem
    {
        [Display(Name = "Profile ID")]
        public int ProfileId { get; set; }

        [Display(Name ="UserName")]
        public string UserName { get; set; }

        [Display(Name = "Bio")]
        public string Bio { get; set; }

        
    }
}
