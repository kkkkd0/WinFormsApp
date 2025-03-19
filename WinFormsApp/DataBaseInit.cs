using BuisnesLogic.Service;
using Data.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public static class DataBaseInit
    {
        private static PasswordManager passwordManager = new PasswordManager();
        private static AppDbContext AppDbContext = new AppDbContext(ConstStorage.ConnectionDb, passwordManager);
        public static AppDbContext GetAppDbContext()
        {
            return AppDbContext;
        }
    }
}
