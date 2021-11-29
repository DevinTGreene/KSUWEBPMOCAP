using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSUWEBPMOCAP.Models
{
    [Table("Student")]
    public class UserAccount
    {
        [Key]
        public string Student_Net_Id { get; set; }
        public string Student_Email { get; set; }
        public string Student_Name { get; set; }
        public string Student_Password { get; set; }
    }
}
