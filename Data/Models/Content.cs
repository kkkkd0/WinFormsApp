using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string? UserAnswer { get; set; }
        public string? CorrectAnswer { get; set; }
        public Assignment? Assignment { get; set; }
        public int? AssigmentId { get; set; }
        /// <summary>
        /// Question or text in theory
        /// </summary>
        public string? Text { get; set; }
        public IList<BinaryData>? BinaryDatas { get; set; }
        // radio, check, text, None
        public string? TypeInput { get; set; }
        public IList<ConfusingAnswers>? ConfusingAnswers { get; set; }
    }
}
