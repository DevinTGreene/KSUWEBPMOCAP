using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KSUWEBPMOCAP.Data
{
    public class Sponsor
    {
        [Key]
        public int Sponsor_ID { get; set; }
        public string Sponsor_Name { get; set; }
        public string Sponsor_Title { get; set; }
        public string Sponsor_Org { get; set; }
        public string Sponsor_Email { get; set; }
        public string Sponsor_Phone { get; set; }
        public string Sponsor_Address { get; set; }
        public string Sponsor_Website { get; set; }


        public ICollection<Proposal> Proposals { get; set; }
        public ICollection<Project> Projects { get; set; }

    }
}
