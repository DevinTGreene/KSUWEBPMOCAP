using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KSUWEBPMOCAP.Data
{
    public class Assignment
    {
        
            [Key]
            public int Assign_ID { get; set; }

            public int Project_Num{ get; set; }
            public string Net_ID { get; set; }
            public string Student_Net_ID { get; set; }
            public string Faculty_LastName { get; set; }
            public string Student_LastName { get; set; }
            public ICollection<Department> Departments { get; set; }
            //public ICollection<Faculty> Faculty { get; set; }
            //public ICollection<Student> Students { get; set; }
        }
    }


