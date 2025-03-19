using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class BinaryData
    {
        public int Id { get; set; }
        public string? LinkOnData { get; set; }
        public Content? Content { get; set; }
        public int? ContentId { get; set; }
        public int PositionInText { get; set; }
    }
}
