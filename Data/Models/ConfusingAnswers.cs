﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ConfusingAnswers
    {
        public int Id { get; set; }
        public int? ContentId { get; set; }
        public Content? Content { get; set; }
        public string? Text { get; set; }
    }
}
