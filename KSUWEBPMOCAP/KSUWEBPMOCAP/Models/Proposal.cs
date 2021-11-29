using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KSUWEBPMOCAP.Data
{
    public class Proposal
    {
        [Key]
        public int Propasal_ID { get; set; }
        public int Sponsor_ID { get; set; }
        public string Sponsor_Name { get; set; }
        public string Project_Type { get; set; }
        public int Project_Num { get; set; }
        public string Dept_Name { get; set; }

        // public ICollection<Department> Departments { get; set; }
        // public ICollection<Project> Projects { get; set; }
        //  public ICollection<Sponsor> Sponors{ get; set; }
    }
}
