using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnesLogic.Models
{
    public class AwsActionResultModel
    {
        public bool isCorrect { get; set; }
        public string resultUrlFromModel { get; set; } = null!;
    }
}
