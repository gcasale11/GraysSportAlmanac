using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Data
{
    public class FAQ
    {
        [Key]
        public int FaqId { get; set; }

        public Guid AuthorId { get; set; }

       
        public string Question { get; set; }



        [ForeignKey(nameof(Profile))]
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }


        public virtual ICollection<Comment> CollectionComment { get; set; }




    }
}
