using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
    public class ProfileCreate
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Bio { get; set; }

        public string Record { get; set; }

        public decimal TotalRisked { get; set; }

        public decimal TotalAccount { get; set; }
        public decimal UnitSize { get; set; }

        public int Units { get; set; }

    }
}
