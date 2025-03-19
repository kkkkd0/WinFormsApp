using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.interfaces
{
    public interface IUserManager
    {
        public void Create(User model);
        public User? Get(string email);
        public IQueryable<User> GetAll();
        public User? Update(string email,User user);
        public void Delete(string email);
    }
}
