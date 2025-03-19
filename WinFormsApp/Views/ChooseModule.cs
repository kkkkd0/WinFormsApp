using BuisnesLogic.Interfaces;
using BuisnesLogic.Service.Clients;
using BuisnesLogic.ServicesInterface;
using BuisnessLogic.Models;
using BuisnessLogic.Services;
using BuisnessLogic.Services.Managers;
using Data.DataBase;
using Data.interfaces;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Views
{
    public partial class ChooseModule : Form
    {
        private string email;

        private TestModule? _TestModule { get; set; }
        private TheoreticalModule? _TherModule { get; set; }
        private AppDbContext _DataBase { get; set; }
        public string ModuleSimilarName { get; set; }
        private IModulesManager<TestModule> _testmanager { get; set; }
        private IModulesManager<TheoreticalModule> _thmanager { get; set; }
        private IUserModulesManager _UserModulesManager { get; set; }
        private string _Email { get; set; }
        public ChooseModule(string findingmodule, string email, Point? location = null)
        {
            InitializeComponent();
            _Email = email;
            ModuleSimilarName = findingmodule;
            using (var file = new StreamReader(ConstStorage.ConfigPath))
            {
                var json = file.ReadToEnd();

                var config = JsonSerializer.Deserialize<YandexCloudConfig>(json) ?? throw new NullReferenceException();

                IYandexClient yandexclient = new YandexCloudClient(config.Id, config.Key, config.BucketName);

                _DataBase = DataBaseInit.GetAppDbContext();

                _testmanager = new ModulesManager<TestModule>(_DataBase, yandexclient);

                _thmanager = new ModulesManager<TheoreticalModule>(_DataBase, yandexclient);

                IUserManager usermanager = new UserManager(_DataBase);

                _UserModulesManager = new UserModulesManager(usermanager, new HandlerInput(), _DataBase);

                _TestModule = _testmanager.GetModule(new ModuleLinkInfo(nameof(_DataBase.TestModules)), ModuleSimilarName);

                _TherModule = _thmanager.GetModule(new ModuleLinkInfo(nameof(_DataBase.TheoreticalModules)), ModuleSimilarName);

            }
            this.Location = location ?? new Point(0, 0);


            buttonTestModule.Visible = false;

            buttonTherModule.Visible = false;
        }

        public ChooseModule(string email)
        {
            this.email = email;
        }

        private void ChooseModule_Load(object sender, EventArgs e)
        {
            if (_TestModule is not null) buttonTestModule.Visible = true;

            if (_TherModule is not null) buttonTherModule.Visible = true;
        }

        private void buttonTherModule_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm(_TherModule!, _Email, 0);
            Hide();
            taskForm.ShowDialog();
            Close();
        }

        private void buttonTestModule_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm(_TestModule!, _Email, 0);
            Hide();
            taskForm.ShowDialog();
            Close();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var form = new ModuleForm(_Email);
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
