using Data.DataBase;
using Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Reflection.Metadata;
using Data.interfaces;

namespace BuisnessLogic.Services.Managers
{
    public class UserManager(AppDbContext database) : IUserManager
    {
        public void Create(User model)
        {
            var table = database.Users.Where(x => x.Email == model.Email);

            var isEmailExists = table.AsQueryable().Where(u => u.Email == model.Email).SingleOrDefault() is not null;

            if (isEmailExists) throw new Exception($"user {model.Email} exists");
            database.Users.Add(model);
            database.SaveChanges();
        }
        public void Delete(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) throw new ArgumentNullException(nameof(email));

            var table = database.Users.Where(x => x.Email == email);

            var user = table.AsQueryable().Where(u => u.Email == email).SingleOrDefault();

            if (user is null) throw new NullReferenceException();

            database.Remove(user);

            database.SaveChanges();
        }
        public User? Get(string email)
        {

            var table = database.Users.Where(x => x.Email == email);

            var userFromDb = table.AsQueryable().Where(u => u.Email == email).SingleOrDefault();

            return userFromDb;
        }

        public IQueryable<User> GetAll()
        {
            var table = database.Users;

            return table.AsQueryable();
        }

        public User? Update(string email, User newmodel)
        {
            if (string.IsNullOrWhiteSpace(email)) throw new ArgumentNullException(nameof(email));

            var userInData = database.Users.AsNoTracking().Where(x => x.Email == email).SingleOrDefault(u => u.Email == email);

            if (userInData is null) return null;

            var newuser = new User()
            {
                Email = newmodel.Email,
                Name = newmodel.Name,
                Salt = newmodel.Salt,
                PasswordHash = newmodel.PasswordHash,
                IsAdmin = newmodel.IsAdmin,
                Groups = newmodel.Groups,
                Patronymic = newmodel.Patronymic,
                Surname = newmodel.Surname,
                Reviews = newmodel.Reviews,
                TestModules = newmodel.TestModules,
                TheoriesModules = newmodel.TheoriesModules,
            };

            database.Entry(userInData).CurrentValues.SetValues(newuser);

            database.Users.Update(userInData);

            database.Remove(userInData);

            database.SaveChanges();

            return newmodel;
        }
    }
}
