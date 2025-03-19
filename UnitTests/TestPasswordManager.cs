using BuisnesLogic.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class TestPasswordManager
    {
        public PasswordManager _PasswordManager {  get; set; }
        public TestPasswordManager()
        {
            //Arrange
            _PasswordManager = new PasswordManager();
        }
        [Fact]
        public void SaltTest()
        {
            //Arrange
            string password = "test";
            uint saltlenght = 8;
            //Act
            var res1 = _PasswordManager.Salt(password,saltlenght);
            var res2 = _PasswordManager.Salt(password, saltlenght);
            //Assert
            Assert.True(((res2.salt != res1.salt) & (res2.hash != res1.hash)) ? true : false);
        }
        [Fact]
        public void CompareTest()
        {
            //Arrange
            string password = "test";
            uint saltlenght = 8;
            //Act
            var res = _PasswordManager.Salt(password, saltlenght);
            var compRes = _PasswordManager.Compare(password,res.salt, res.hash);
            //Assert
            Assert.True(compRes);
        }
    }
}
