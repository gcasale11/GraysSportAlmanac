using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Data
{
  public class Group
    {
        [Key]
        public Guid GroupId { get; set; }

        [ForeignKey(nameof(Profile))]
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }

        public string GroupName { get; set; }
        //List of Users property
        public int RankingWL { get; set; }
        public int RankingTA { get; set; }
        public string GroupPost { get; set; }



    }
}
