using BuisnesLogic.Interfaces;
using BuisnesLogic.Service.Clients;
using BuisnesLogic.ServicesInterface;
using BuisnessLogic.Models;
using BuisnessLogic.Services.Managers;
using Data.DataBase;
using Data.interfaces;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinFormsApp.Views
{
    public partial class ModuleForm : Form
    {
        private IModulesManager<TestModule> _teManager { get; set; }
        private IModulesManager<TheoreticalModule> _thManager { get; set; }
        private IUserManager _UserManager { get; set; }
        private ModuleBase DataForRedirect { get; set; }
        private AppDbContext _DataBase { get; set; }
        private string _Email {  get; set; }
        public ModuleForm(string email, Point? location = null)
        {
            InitializeComponent();
            using (var file = new StreamReader(ConstStorage.ConfigPath))
            {
                var json = file.ReadToEnd();

                var config = JsonSerializer.Deserialize<YandexCloudConfig>(json) ?? throw new NullReferenceException();

                IYandexClient yandexclient = new YandexCloudClient(config.Id, config.Key, config.BucketName);

                _DataBase = DataBaseInit.GetAppDbContext();
             

                _teManager = new ModulesManager<TestModule>(_DataBase, yandexclient);
                _thManager = new ModulesManager<TheoreticalModule>(_DataBase,yandexclient);
                _UserManager = new UserManager(_DataBase);
            }
            _Email = email;
            this.Location = location ?? new Point(0,0);
        }

        private void ModuleForm_Load(object sender, EventArgs e)
        {
            var l1 = _teManager.GetModules(new ModuleLinkInfo(nameof(_DataBase.TestModules))).Where(x => x.Exists == 1).ToList();
            var l2 = _thManager.GetModules(new ModuleLinkInfo(nameof(_DataBase.TheoreticalModules))).Where(x => x.Exists == 1).ToList();

            var buttons = MapToItemsControl([..l1, ..l2]);
            foreach (var button in buttons)
            {
                flowModulePanel.Controls.Add(button);
            }

        }
        private IList<Button> MapToItemsControl(IList<ModuleBase> allmodules)
        {
            var list = new List<Button>();
            int counter = 0;
            foreach (var module in allmodules)
            {
                if (string.IsNullOrWhiteSpace(module.Name))
                {
                    continue;
                }
                var button = new Button()
                {
                    Text = module.Name!.Length > 10 ? module.Name.Substring(0, 10) + "..." : module.Name,
                    BackColor = Color.White,
                    Font = new Font(new FontFamily("Sitka Text"), 12, FontStyle.Bold),
                    AutoSize = true,
                    FlatStyle = FlatStyle.Flat,
                };
                button.Click += Redirect;
                list.Add(button);
                counter++;
            }
            return list;
        }
        private void Redirect(object? sender, EventArgs e)
        {
            var button = sender as Button;
            if (button is null) return;
            var nameModule = button.Text;
            var chosemodule = new ChooseModule(nameModule, _Email);
            Hide();
            chosemodule.ShowDialog();
            Close();
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            var user = _UserManager.Get(_Email);
            if (user is null) return;
            var form = new AccountForm(UserRegistration.MapToUserView(user), _Email);
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
