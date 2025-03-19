using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ModuleBase
    {
        public string? Name { get; set; } 
        public List<User>? Users { get; set; } = new List<User>();
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public virtual List<Assignment>? Assignments { get; set; }
        // null, 0, 1
        public int? Exists { get; set; }
    }
}
