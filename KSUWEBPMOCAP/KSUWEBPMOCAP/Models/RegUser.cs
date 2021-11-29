using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KSUWEBPMOCAP.Data
{
    public class RegUser
    {
        [Key]
        public int ID { get; set; }
        public string Net_ID { get; set; }
        public Byte Password { get; set; }
    } 
}
