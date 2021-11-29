using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KSUWEBPMOCAP.Data
{
    public class TblFile
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContenType { get; set; }
        public string Data { get; set; }
    }
}
