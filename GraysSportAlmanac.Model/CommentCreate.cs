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
        public int PostId { get; set; }
        [Required]
        public string ContentComment { get; set; }

        

        [Display(Name = "User Name")]
        public int ProfileId { get; set; }
        public string UserName { get; set; }
        
        
        /*DO WE NEED TO ADD A PLACE IN POST TO ADD WORDS THAT A COMMENT CLASS WOULD COMMENT ON?!?
         * 
         * public int PostId { get; set; }
        public string WordForFriends { get; set; }*/
    }
}
