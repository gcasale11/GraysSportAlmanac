using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Data
{
   public class Answer
    {
        [Key]
        public int AnswerId { get; set; }
        public Guid AuthorId { get; set; }


        public string AnswerContent { get; set; }

        [ForeignKey(nameof(FAQ))]
        public int FaqId { get; set; }
        public virtual FAQ FAQ { get; set; }

        [ForeignKey(nameof(Profile))]
        public int ProfileId { get; set; }
        public string UserName { get; set; }
        public virtual Profile Profile { get; set; }


    }
}
