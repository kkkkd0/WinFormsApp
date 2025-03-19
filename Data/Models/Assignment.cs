using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public virtual TestModule? TestModel { get; set; }
        public int? TestModuleId { get; set; }
        public virtual TheoreticalModule? TheoreticalModel { get; set; }
        public int? TheoretiesModuleId { get; set; }
        public Content? Content { get; set; } 

    }
}
