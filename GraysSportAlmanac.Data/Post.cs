using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Data
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public Guid AuthorId { get; set; }

        [ForeignKey(nameof(Profile))]
        public int ProfileId { get; set; }
        public string UserName { get; set; }
        public virtual Profile Profile { get; set; }

        [Required]
        public string BetDate { get; set; }
        [Required]
        public string Bet { get; set; }
        [Required]
        public decimal Risked { get; set; }
        [Required]
        public int Odds { get; set; }
        public string Result { get; set; }
        public decimal Payout { get; set; }

        public virtual ICollection<Comment> CollectionComment { get; set; }
    }
}
