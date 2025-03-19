using EntityFrameworkCore.Projectables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class TestModule : ModuleBase
    {
        public TheoreticalModule? TheoreticalModule { get; set; }
        public int? ThId { get; set; }
        [Projectable]
        public int TestResult => (Assignments ?? new List<Assignment>()).Sum(x => x.Content!.CorrectAnswer! == (x.Content.UserAnswer) ? 0 : 1);
    }
}
