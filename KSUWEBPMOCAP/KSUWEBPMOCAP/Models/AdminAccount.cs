using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSUWEBPMOCAP.Models
{
    [Table("Faculty")]
    public class AdminAccount
    {
        [Key]
        public string Net_Id { get; set; }
        public string Faculty_Email { get; set; }
        public string Faculty_Name { get; set; }
        public string Faculty_Password { get; set; }
    }
}
