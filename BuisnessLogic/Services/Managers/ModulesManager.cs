using AutoMapper;
using BuisnesLogic.Interfaces;
using BuisnesLogic.Service.Clients;
using BuisnesLogic.ServicesInterface;
using BuisnessLogic.Models;
using Data.DataBase;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BuisnessLogic.Services.Managers
{
    public class ModulesManager<T>(AppDbContext database, IYandexClient client) : IModulesManager<T> where T : ModuleBase, new()
    {
        // 1
        public T? GetModule(ModuleLinkInfo model, string name)
        {
            var table = GetTable(model);
            var module = table.Where(x => x.Name == name & x.Exists != null).SingleOrDefault();
            if (module is null) return null;
            module.Assignments = GetAssignmentModule(model,module);
            return module;
        }
        private List<Assignment>? GetAssignmentModule(ModuleLinkInfo model, T? module)
        {
            List<Assignment>? assignements = null;
            if (model.tablename is nameof(database.TestModules))
            {
                assignements = database.Assignments.Where(x => x.TestModuleId == module.Id).ToList();
            }
            if (model.tablename is nameof(database.TheoreticalModules))
            {
                assignements = database.Assignments.Where(x => x.TheoretiesModuleId == module.Id).ToList();
            }
            if (assignements is null) return assignements;
            foreach(var task in assignements)
            {
                var content = database.Contents.Where(x => x.AssigmentId == task.Id).FirstOrDefault();
                if(content is not null)
                {
                    content.BinaryDatas = GetLinksOnBinaryData(content);
                    content.ConfusingAnswers = GetConfusingAnswers(content);
                    task.Content = content;
                }
            }
            return assignements;
           
        }
        private List<BinaryData> GetLinksOnBinaryData(Content content)
        {
            var datas = database.BinaryDatas.Where(c => c.ContentId == content.Id).ToList();
            return datas;
        }
        private List<ConfusingAnswers> GetConfusingAnswers(Content content)
        {
            var confs = database.ConfusingAnswers.Where(c => c.ContentId == content.Id).ToList();
            return confs;
        }
        public void DeleteModule(ModuleLinkInfo model, int id, string? name = null)
        {
            var table = GetTable(model).ToList();
            if (table is null || table.Count == 0) return;
            var entity = table.Where(x => (name is not null ? x.Name == name : true) & x.Id == id).SingleOrDefault();
            if (entity is null) return;
            if (model.tablename is nameof(database.TestModules))
            {
                var ent = (entity as TestModule)!;
                database.TestModules.Remove(ent);
            }
            if (model.tablename is nameof(database.TheoreticalModules))
            {
                var ent = (entity as TheoreticalModule)!;
                database.TheoreticalModules.Remove(ent);
            }
            database.SaveChanges();
        }
        public void CreateModule(ModuleLinkInfo model,T newmodule)
        {
            var table = GetTable(model);

            if (model.tablename is nameof(database.TestModules))
            {
                var module = database.TestModules.Where(x => x.Name == newmodule.Name).SingleOrDefault();
                if (module is not null) throw new Exception("Module is exists");
                var tm = (newmodule as TestModule)!;
                database.TestModules.Add(tm);
            }

            if (model.tablename is nameof(database.TheoreticalModules))
            {
                var module = database.TheoreticalModules.Where(x => x.Name == newmodule.Name).SingleOrDefault();
                if (module is not null) throw new Exception("Module is exists");
                var tm = (newmodule as TheoreticalModule)!;
                database.TheoreticalModules.Add(tm);
            }

            database.SaveChanges();

        }
        public void UpdateModule(ModuleLinkInfo model, T newmodule, int idoldmoduel, string? nameoldmodule = null)
        {

            var entity = GetTable(model).Where(x => x.Id == idoldmoduel && x.Name == nameoldmodule).SingleOrDefault();

            if (entity is null) return;

            database.Entry(entity).CurrentValues.SetValues(newmodule);

            if (newmodule as TestModule is not null) database.TestModules.Update((newmodule as TestModule)!);

            if (newmodule as TheoreticalModule is not null) database.TheoreticalModules.Update((newmodule as TheoreticalModule)!);

            database.SaveChanges();
        }
      
        private IQueryable<T> GetTable(ModuleLinkInfo model)
        {
            IList<T> table = new List<T>();
            if (model.tablename is nameof(database.TestModules))
            {
                foreach (var module in database.TestModules)
                {
                    
                    table.Add((module as T)!);
                }
            }

            if (model.tablename is nameof(database.TheoreticalModules))
            {
                foreach (var module in database.TheoreticalModules)
                {
                    table.Add((module as T)!);
                }
            }
            //var table = database.GetType().GetProperty(model.tablename)!.GetValue(database) as DbSet<T>;

            //if (table is null) throw new Exception($"Table with name {model.tablename} isn`t exists");
          
            
            return table.AsQueryable();           

        }

        public IQueryable<T> GetModules(ModuleLinkInfo model, string? nameWhenImclude = null)
        {
            var table = GetTable(model);
            if (nameWhenImclude is not null) return table.AsQueryable().Where(x => x.Name!.Contains(nameWhenImclude));
            foreach(var t in table)
            {
               t.Assignments = GetAssignmentModule(model, t);
            }
            return table.AsQueryable();
        }
    }
}
