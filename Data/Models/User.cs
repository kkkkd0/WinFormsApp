using EntityFrameworkCore.Projectables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Patronymic { get; set; }
        public IList<Review> Reviews { get; set; } = new List<Review>(); 
        public IList<Group> Groups { get; set; } = new List<Group>(); 
        public string? Name { get; set; }
        public string? Salt {  get; set; } 
        public string? PasswordHash { get; set; }
        public List<TestModule> TestModules { get; set; } = new List<TestModule>();
        public List<TheoreticalModule> TheoriesModules { get; set; } = new List<TheoreticalModule>(); 
        public bool? IsAdmin { get; set; }
        [Projectable]
        public string FullName => Name + Surname + Patronymic;
    }
}
