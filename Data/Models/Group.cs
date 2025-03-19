using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Group
    {
        public int Id { get; set; }
        public int? User_id { get; set; }
        public User? User { get; set; }
        public string? Course { get; set; }
        public string? Way {  get; set; }
        

    }
}
