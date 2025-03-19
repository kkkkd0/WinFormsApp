using Amazon.Runtime.Internal.Util;
using BuisnesLogic.Interfaces;
using BuisnesLogic.Models;
using BuisnesLogic.Service.Clients;
using BuisnesLogic.ServicesInterface;
using BuisnessLogic.Models;
using BuisnessLogic.Services;
using BuisnessLogic.Services.Interfaces;
using BuisnessLogic.Services.Managers;
using Data.DataBase;
using Data.interfaces;
using Data.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class TestModules
    {
        private IModulesManager<TheoreticalModule> _ThManager {  get; set; }
        private IModulesManager<TestModule> _TeManager { get; set; }
        
        private IUserModulesManager _UserModulesManager { get; set; }
        private Mock<IHandlerInput> _MockInputHandler { get; set; }

        private Mock<IYandexClient> _MockYandexCloud { get; set; }

        private Mock<IUserManager> _MockUserManager { get; set; }

        private IUserManager _UserManager { get; set; }
        private AppDbContext _DataBase {  get; set; }
       
        public TestModules()
        {
            _MockInputHandler = new Mock<IHandlerInput>();

            User testUser = new User()
            {
                Email = "@mail.com",
                Name = "Test",
                Surname = "Test",
                Salt = "iasdhgsdwudw",
                PasswordHash = "hsaishaisha",
                Patronymic = "Tester",
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
                TestModules = new List<TestModule>() { new TestModule()
                {
                    Assignments = new List<Assignment>()
                    {
                        new Assignment()
                        {
                            Content = new Content()
                            {
                                Text = "test",
                                TypeInput = TypeInput.Text.ToString()
                            }
                        }
                    }
                }}
                ,TheoriesModules = new List<TheoreticalModule>()
            };
            bool res = true;
            _MockInputHandler.Setup(x => x.Initaction(It.IsAny<UserAction>(), It.IsAny<User>())).Returns(res);

            _DataBase = new AppDbContext($"Data source={Environment.CurrentDirectory}\\dbmain.db");
            _UserManager = new UserManager(_DataBase);
            _MockYandexCloud = new Mock<IYandexClient>();
            _MockYandexCloud.Setup(x => x.AddModel(It.IsAny<Stream>(), It.IsAny<string>() ,It.IsAny<string>())).ReturnsAsync(new AwsActionResultModel()
            {
                isCorrect = true,
                resultUrlFromModel = string.Empty,
            });
            _ThManager = new ModulesManager<TheoreticalModule>(_DataBase, _MockYandexCloud.Object);
            
            _TeManager = new ModulesManager<TestModule>(_DataBase, _MockYandexCloud.Object);
            
            _MockUserManager = new Mock<IUserManager>();

            _MockUserManager.Setup(x => x.Get(It.IsAny<string>())).Returns(testUser);

            _UserModulesManager = new UserModulesManager(_MockUserManager.Object, _MockInputHandler.Object, _ThManager, _TeManager);
        }
        [Fact]
        public void TestGetTestModule()
        {
            
            var table = nameof(_DataBase.TestModules);
            var module = new TestModule()
            {
                User = new User()
                {
                    Name = "Test"
                },
                Name = "Test",
                TheoreticalModule = new TheoreticalModule()
                {
                    User = new User()
                    {
                        Name = "Test"
                    },
                    Text = "Test"
                    
                }
               
            };

            _TeManager.CreateModule(new ModuleLinkInfo(table), module);

            var test = _UserModulesManager.TakeModuleTest("Test").ToList();

            Assert.Single(test);
        }
    }
}
