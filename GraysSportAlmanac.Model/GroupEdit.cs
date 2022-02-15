using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
  public class GroupEdit
    {
        [Key]
        public int GroupId { get; set; }

        [ForeignKey(nameof(ProfileDetail))]
        public ProfileDetail ProfileId { get; set; }

        public string GroupName { get; set; }
        //List of Users property

        public int RankingWL { get; set; }
        public int RankingTA { get; set; }
        public string GroupPost { get; set; }

    }
}
