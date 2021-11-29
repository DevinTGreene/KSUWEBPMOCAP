using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSUWEBPMOCAP.Models
{
    [Table("PMOAdmin")]
    public class PMOAdminAccount
    {
        [Key]
        public string Id { get; set; }
        public string Net_ID { get; set; }
        public string PMO_Name { get; set; }
        public string PMO_Password { get; set; }
    }
}
