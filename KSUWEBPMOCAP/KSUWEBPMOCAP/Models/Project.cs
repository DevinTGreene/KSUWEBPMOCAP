using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KSUWEBPMOCAP.Data
{
    public class Project
    {
        [Key]
        public int Project_ID { get; set; }
        public string Project_Num { get; set; }
        public string Proj_Type { get; set; }
        public string Num_Teams_Sponsored { get; set; }
        public string Project_Description { get; set; }
        public string Proj_Sponsor_Benefit { get; set; }
        public string Proj_Student_Benefit { get; set; }
        public bool Proj_hasNDA { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public string Sponsor_Name { get; set; }
        public string Faculty_LastName { get; set; }
        public string Dept_Name { get; set; }

        public List<Project> Projects { get; set; }


        public ICollection<Department> Departments { get; set; }
        //public ICollection<Sponsor> Sponsors { get; set; }
        public ICollection<Proposal> Proposals { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}
