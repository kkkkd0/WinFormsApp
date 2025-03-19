using Amazon.S3.Model.Internal.MarshallTransformations;
using BuisnesLogic.Interfaces;
using BuisnessLogic.Models;
using BuisnessLogic.Services.Interfaces;
using Data.DataBase;
using Data.interfaces;
using Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic.Services.Managers
{
    public class UserModulesManager(
        IUserManager usermanager,
        IHandlerInput handlerInput, 
        AppDbContext dbContext) : IUserModulesManager
    {
        public Assignment? GetAssigment(ModuleBase module, int numberoftask)
        {
            if(module.Assignments is null) throw new ArgumentNullException(nameof(module.Assignments));
            if((module as TestModule) is not null)
            {
                return module.Assignments.Where(x => x.TestModuleId == numberoftask).SingleOrDefault();
            }
            if ((module as TheoreticalModule) is not null)
            {
                return module.Assignments.Where(x => x.TheoretiesModuleId == numberoftask).SingleOrDefault();
            }
            return null;
        }
        public IEnumerable<TestModule>? TakeModuleTest(string email, string name)
        {
            var user = usermanager.Get(email);
            if (user is null) return null;
            return user.TestModules;
        }
        public IEnumerable<TheoreticalModule>? TakeModuleTher(string email,string name)
        {
            var user = usermanager.Get(email);
            if (user is null) return null;
            return user.TheoriesModules;
        }
      
        public void OpenModuleTest(string email, TestModule module)
        {
            var user = usermanager.Get(email);

            if (user is null) return;

            if (user.TestModules.Where(x => x.Name == module.Name).SingleOrDefault() is not null) return;

            module.IsActive = true;

            module.Exists = 1;

            user.TestModules!.Add(module);

            module.Users!.Add(user);

            dbContext.Users.Update(user);

            dbContext.TestModules.Update(module);

            dbContext.SaveChanges();
        }

        public void CloseModuleTest(string email, TestModule module)
        {
            var user = usermanager.Get(email);

            if (user is null) return;

            module.IsActive = false;

            module.Exists = 0;

            module.Users?.RemoveAll(x => x.Email == user.Email & x.Id == user.Id);

            user.TestModules!.RemoveAll(x => x.Name == module.Name);

            dbContext.Users.Update(user);

            dbContext.TestModules.Update(module);
        }
        public void ChangeUserModuleTest(string email, string name, TestModule model)
        {
            var user = usermanager.Get(email);

            if (user is null) return;

            var module = user.TestModules!.Where(x => x.Name == name).SingleOrDefault();

            module = new TestModule()
            {
                Assignments = model.Assignments,
                IsActive = model.IsActive,
                Name = name,
                TheoreticalModule = model.TheoreticalModule,
                ThId = model.ThId,
            };

            dbContext.TestModules!.Update(module);
            dbContext.Users?.Update(user);

            dbContext.SaveChanges();
        }
        public void OpenModuleTheoretical(string email, TheoreticalModule module)
        {
            var user = usermanager.Get(email);

            if (user is null) return;

            if (user.TheoriesModules.Where(x => x.Name == module.Name).SingleOrDefault() is not null) return;

            module.IsActive = true;

            module.Exists = 1;

            user.TheoriesModules!.Add(module);

            module.Users!.Add(user);

            dbContext.Users.Update(user);

            dbContext.TheoreticalModules.Update(module);

            dbContext.SaveChanges();
        }
        public void CloseModuleTheoretical(string email, TheoreticalModule module)
        {
            var user = usermanager.Get(email);

            if (user is null) return;

            module.IsActive = false;

            module.Exists = 0;

            module.Users?.RemoveAll(x => x.Email == user.Email & x.Id == user.Id);

            user.TestModules!.RemoveAll(x => x.Name == module.Name);

            dbContext.Users.Update(user);

            dbContext.TheoreticalModules.Update(module);
        }
        
        public bool GiveAnswer(UserAction action, string email)
        {
            var user = usermanager.Get(email);

            if (user is null) throw new NullReferenceException();

            return handlerInput.Initaction(action, user);
        }
    }
}
