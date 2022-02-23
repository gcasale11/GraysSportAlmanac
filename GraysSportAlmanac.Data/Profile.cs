using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Data
{
    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }

        public Guid  OwnerId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Bio { get; set; }

        public string Record { get; set; }

        public decimal TotalRisked { get; set; }
        public decimal TotalAccount { get; set; }
        public decimal UnitSize { get; set; }

        public int Units { get; set; }

        public virtual ICollection<Post> CollectionPost { get; set; }
       // public virtual ICollection<GroupPost> CollectionGroupPost { get; set; }

        public virtual ICollection<Comment> CollectionComment{ get; set; }

        public virtual ICollection<FAQ> CollectionFaq { get; set; }


    }
}
