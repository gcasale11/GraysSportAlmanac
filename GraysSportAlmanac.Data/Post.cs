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
        /*[MinLength(3,ErrorMessage ="Please enter the amount wagered in 1.00 format")]*/
        public decimal Risked { get; set; }
        [Required]
        /*[MinLength(4, ErrorMessage ="Please enter the odds on the wager in the American style (+100, -100)")]*/
        public int Odds { get; set; }
       
        /*[MaxLength(1,ErrorMessage ="Please enter W for a win, L for a loss, and P for a push")]*/
        public string Result { get; set; }
       
        /*[MinLength(3,ErrorMessage ="Please enter the amount won or lost in 1.00 format")]*/
        public decimal Payout { get; set; }

        public virtual ICollection<Comment> CollectionComment { get; set; }
    }
}
