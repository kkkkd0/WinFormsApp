using BuisnessLogic.Services.Managers;
using Data.DataBase;
using Data.interfaces;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class TestUserManager
    {
        private IUserManager _UserManager {  get; set; }
        private User testUser = new User()
        {
            Email = "@mail.com",
            Name = "Test",
            Surname = "Test",
            Salt = "iasdhgsdwudw",
            PasswordHash = "hsaishaisha",
            IsAdmin = true,
            Groups = new List<Group>
                {
                    new Group()
                    {
                         Course = "Test",
                          Way = "C#",
                    }
                },
            Reviews = new List<Review>()
                {
                    new Review()
                    {
                        Text = "Test",
                    }
                },
        };
        private AppDbContext _DataBase {  get; set; }
        
        public TestUserManager()
        {
            //Arrange
            _DataBase = new AppDbContext($"Data source={Environment.CurrentDirectory}\\dbmain.db");
            _UserManager = new UserManager(_DataBase);
        }
        [Fact]
        public void UpdateTest()
        {
            string log = "";
                testUser.Email = "Petr@gmail.com";
                try
                {
                    _UserManager.Create(testUser);
                }
                catch(Exception ex)
                {
                    log += ex.Message;
                }
                var model = new User()
                {
                    Name = "Tests",
                    Email = "Tester@mail.com",
                };
                _UserManager.Update(testUser.Email!, model);
                _UserManager.Delete(testUser.Email!);
                var newuser = _UserManager.Get(model.Email);            
                Assert.True(newuser is not null);
        }
        [Fact]
        public void DeleteTest()
        {
            try
            {
                testUser.Email = "Ann@gamil.com";
                _UserManager.Create(testUser);
            }
            finally
            { 
                _UserManager.Delete(testUser.Email!);
                var user = _UserManager.Get(testUser.Email!);
                Assert.Null(user);
            }          
        }
        [Fact]
        public void CreateTest()
        {
            //Act
            testUser.Email = "Doby@gmail.com";
            _UserManager.Create(testUser);
            var user = _UserManager.Get(testUser.Email);
            _UserManager.Delete(testUser.Email);
            //Assert
            Assert.NotNull(user);
        }
        [Fact]
        public void GetAllTest()
        {          
            try
            {
                //Act
                var all = _UserManager.GetAll();
                //Assert
                Assert.True(true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [Fact]
        public void PossibilitiesSortQuerableTest()
        {
            //Act
            var us = _UserManager.GetAll().Where(x => x.FullName == testUser.FullName).FirstOrDefault();
            //Assert
            Assert.NotNull(us);
        }
    }
}
