using GraysSportAlmanac.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraysSportAlmanac.Model
{
    public class GroupPostCreate
    {
        /*[Key]
        public Guid GroupPostId { get; set; }*/


       // public int GroupId { get; set; }


        public int ProfileId { get; set; }

        public string UserName { get; set; }
        [Required]
        
        public string BetDate { get; set; }

        [Required]
        public string Bet { get; set; }


        public decimal Risked { get; set; }

        [Required]
        public int Odds { get; set; }


    
        public string Result { get; set; }

            
        public decimal Payout { get; set; }



    }
}
