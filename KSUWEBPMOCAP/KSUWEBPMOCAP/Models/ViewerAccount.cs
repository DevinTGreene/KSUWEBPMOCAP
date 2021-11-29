using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSUWEBPMOCAP.Models
{
    [Table("Sponsor")]
    public class ViewerAccount
    {
        [Key]
        public string Sponsor_ID { get; set; }
        public string Sponsor_Name { get; set; }
        public string Sponsor_Title { get; set; }
        public string Sponsor_Email { get; set; }
        public string Sponsor_Phone { get; set; }
        public string Sponsor_Org { get; set; }
        public string Sponsor_Address { get; set; }
        public string Sponsor_Website { get; set; }
        public string Sponsor_Password { get; set; }

    }
}
