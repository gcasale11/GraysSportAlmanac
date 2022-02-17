using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
    public class FAQCreate
    {
        public int ProfileId { get; set; }
        public string Question { get; set; }
    }
}
