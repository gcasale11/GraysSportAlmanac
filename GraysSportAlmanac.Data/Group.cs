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
        public int GroupId { get; set; }
        public Guid AuthorId { get; set; }

        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }

        public string GroupName { get; set; }

       // public List<Group> ListofMembers { get; set; }
        public int RankingWL { get; set; }
        public int RankingTA { get; set; }
        public List<GroupPost> ListofPosts { get; set; }


        public virtual ICollection<GroupPost> CollectionGroupPost { get; set; }
    }
}
