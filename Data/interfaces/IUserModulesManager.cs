using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.interfaces
{
    public delegate bool UserAction(User user);
    public interface IUserModulesManager
    {
        public Assignment? GetAssigment(ModuleBase module, int numberoftask);
        public void CloseModuleTest(string email, TestModule module);
        public IEnumerable<TestModule>? TakeModuleTest(string email,string name);
        public IEnumerable<TheoreticalModule>? TakeModuleTher(string email, string name);
        public bool GiveAnswer(UserAction action, string email);
        public void OpenModuleTest(string email, TestModule testModule);
        public void ChangeUserModuleTest(string email, string name, TestModule model);
        public void OpenModuleTheoretical(string email, TheoreticalModule module);
        public void CloseModuleTheoretical(string email, TheoreticalModule module);
    }
}
