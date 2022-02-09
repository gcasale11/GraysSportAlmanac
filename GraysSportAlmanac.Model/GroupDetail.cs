using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
    public class GroupDetail
    {
        [Key]
        public Guid GroupId { get; set; }

        [ForeignKey(nameof(ProfileDetail))]
        public ProfileDetail ProfileId { get; set; }

        public string GroupName { get; set; }
        //List of Users Property
        public int RankingWL { get; set; }
        public int RankingTA { get; set; }
        public string GroupPost { get; set; }

    }
}
