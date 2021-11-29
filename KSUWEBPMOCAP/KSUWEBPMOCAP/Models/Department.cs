using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KSUWEBPMOCAP.Data
{
    public class Department
    {

        [Key]
        public int Dept_ID { get; set; }
        public int Dept_Num { get; set; }
        public string Dept_Name { get; set; }
        public string Faculty_LastName { get; set; }


        //public ICollection<Project> Projects { get; set; }
        public ICollection<Proposal> Proposals { get; set; }
        public ICollection<Faculty> Faculties { get; set; }
    }
}
