using GraysSportAlmanac.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
    public class GroupCreate
    {
        [Key]
        public Guid GroupId { get; set; }

       
       // public int ProfileId { get; set; }

        [Required]
        public string GroupName { get; set; }
        //List of Users property
        public int RankingWL { get; set; }
        public int RankingTA { get; set; }

    }
}
