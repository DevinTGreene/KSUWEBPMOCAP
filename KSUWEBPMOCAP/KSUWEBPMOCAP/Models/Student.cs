using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KSUWEBPMOCAP.Data
{
    public class Student
    {
        [Key]
        public int Student_ID { get; set; }
        public string Student_Net_ID { get; set; }
        public string Student_LastName { get; set; }
        public string Student_FirstdName { get; set; }
        public string Student_Email { get; set; }

        public ICollection<Assignment> Assignments { get; set; }
    }
}
