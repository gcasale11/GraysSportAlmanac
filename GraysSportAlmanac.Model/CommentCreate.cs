using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
    public class CommentCreate
    {
        
        [Required]
        public string ContentComment { get; set; }

        public int ProfileId { get; set; }
        public string UserName { get; set; }
        
       
        public int PostId { get; set; }

        public int FaqId { get; set; }

        public int GroupId { get; set; }


    }
}
