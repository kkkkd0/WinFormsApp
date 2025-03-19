using BuisnessLogic.Models;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnesLogic.Interfaces
{
    public interface IModulesManager<T> where T: ModuleBase
    {
        public T? GetModule(ModuleLinkInfo model, string name);
        public IQueryable<T> GetModules(ModuleLinkInfo model, string? nameWhenImclude = null);
        public void CreateModule(ModuleLinkInfo model, T newmodule);
        public void UpdateModule(ModuleLinkInfo model, T newmodule, int idoldmoduel, string? nameoldmodule = null);
        public void DeleteModule(ModuleLinkInfo model, int id, string? name = null);
    }
}
