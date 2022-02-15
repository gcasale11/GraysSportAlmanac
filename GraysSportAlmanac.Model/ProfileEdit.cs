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

        [Display(Name = "Bio")]
        public string Bio { get; set; }
        

    }
}
