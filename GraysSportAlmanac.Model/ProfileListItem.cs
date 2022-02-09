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
        [Display]
        public int ProfileId { get; set; }

        [Display]
        public string UserName { get; set; }

        [Display]
        public string Record { get; set; }
    }
}
