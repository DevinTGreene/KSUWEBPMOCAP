using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KSUWEBPMOCAP.Data
{
    public class Faculty
    {
        [Key]
        public int Faculty_ID { get; set; }
        public string Net_ID { get; set; }
        public string Faculty_LastName { get; set; }
        public string Faculty_FirstName { get; set; }
        public string Faculty_Email { get; set; }
        public string Dept_Name { get; set; }

        public ICollection<Project> Projects { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
        //[ForeignKey("Project_ID")]
        // public int Project_ID { get; set; }

    }
}
