using BuisnesLogic.Interfaces;
using BuisnesLogic.Service.Clients;
using BuisnesLogic.ServicesInterface;
using BuisnessLogic.Models;
using BuisnessLogic.Services.Managers;
using Data.DataBase;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Views
{
    public partial class DataBaseForm : Form
    {
        private AppDbContext _Database;
        private IModulesManager<TestModule> _teManager { get; set; }
        private IModulesManager<TheoreticalModule> _thManager { get; set; }
        private IYandexClient _YandexClient { get; set; }
        private string _Email { get; set; }
        public DataBaseForm(string email, Point? location = null)
        {
            InitializeComponent();
            _Email = email;
            _Database = DataBaseInit.GetAppDbContext();

            _Database.TestModules.Load();
            _Database.TheoreticalModules.Load();
            _Database.Users.Load();
            dataGridViewTest.DataSource = _Database.TestModules.Local.ToBindingList();
            dataGridViewTheoretical.DataSource = _Database.TheoreticalModules.Local.ToBindingList();
            dataGridUser.DataSource = _Database.Users.Local.ToBindingList();
            dataGridViewTheoretical.Columns["Id"].ReadOnly = true;
            dataGridViewTest.Columns["Id"].ReadOnly = true;
            dataGridUser.Columns["Id"].ReadOnly = true;
            using (var file = new StreamReader(ConstStorage.ConfigPath))
            {
                var json = file.ReadToEnd();

                var config = JsonSerializer.Deserialize<YandexCloudConfig>(json) ?? throw new NullReferenceException();

                _YandexClient = new YandexCloudClient(config.Id, config.Key, config.BucketName);
            }
            _teManager = new ModulesManager<TestModule>(_Database, _YandexClient);

            _thManager = new ModulesManager<TheoreticalModule>(_Database, _YandexClient);

            this.Location = location ?? new Point(0, 0);
        }

        private void DataBaseForm_Load(object sender, EventArgs e)
        {
            radioButtonTestActive.Checked = true;
            radioButtonTheoreticalActive.Checked = false;
            radioButtonUser.Checked = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            buttonDelete.Enabled = false;
            if (radioButtonTestActive.Checked)
            {
                var form = new AddModuleForm(_YandexClient, TypeModule.Test);
                var dialogres = form.ShowDialog();
                if (dialogres == DialogResult.Cancel)
                {
                    return;
                }
                var testmodule = new TestModule()
                {
                    Assignments = form.Module.Assignments!,
                    Name = form.Module.Name,
                    IsActive = form.Module.IsActive,
                    Users = form.Module.Users,
                    Exists = form.Module.Exists,
                };
                try
                {
                    _teManager.CreateModule(new ModuleLinkInfo(nameof(_Database.TestModules)), testmodule);
                }
                catch (Exception ex) when (ex.Message.Contains("Module"))
                {
                    MessageBox.Show("Модуль с таким именем уже есть");
                }
            }
            if (radioButtonTheoreticalActive.Checked)
            {
                var form = new AddModuleForm(_YandexClient, TypeModule.Ther);
                var dialogres = form.ShowDialog();
                if (dialogres == DialogResult.Cancel) return;
                var thmodule = new TheoreticalModule()
                {
                    Assignments = form.Module.Assignments,
                    Name = form.Module.Name,
                    IsActive = form.Module.IsActive,
                    Users = form.Module.Users,
                    Exists = form.Module.Exists,
                };
                try
                {
                    _thManager.CreateModule(new ModuleLinkInfo(nameof(_Database.TheoreticalModules)), thmodule);
                }
                catch (Exception ex) when (ex.Message.Contains("Module"))
                {
                    MessageBox.Show("Модуль с таким именем уже есть");
                }
            }
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            buttonAdd.Enabled = false;
            if (radioButtonTestActive.Checked)
            Delete(new ModuleLinkInfo(nameof(_Database.TestModules)),
            dataGridViewTest.SelectedCells[0].Value as int?);
            
            if (radioButtonTheoreticalActive.Checked) 
            Delete(new ModuleLinkInfo(nameof(_Database.TheoreticalModules)), 
            dataGridViewTheoretical.SelectedCells[0].Value as int?);
        }
        private void Delete(ModuleLinkInfo moduleLinkInfo,int? index)
        {
            try
            {
                if (index is null) return;
                if (moduleLinkInfo.tablename == nameof(_Database.TestModules)) _teManager.DeleteModule(moduleLinkInfo, index.Value);
                if(moduleLinkInfo.tablename == nameof(_Database.TheoreticalModules)) _thManager.DeleteModule(moduleLinkInfo, index.Value);
            }
            catch
            {
                return;
            }
        }
        private void radioButtonTestActive_CheckedChanged(object sender, EventArgs e)
        {
            SwitchTrueFalse([buttonAdd, buttonDelete, dataGridViewTest], [dataGridUser, dataGridViewTheoretical]);
        }

        private void radioButtonTheoreticalActive_CheckedChanged(object sender, EventArgs e)
        {
            SwitchTrueFalse([buttonAdd, buttonDelete,dataGridViewTheoretical],[dataGridUser,dataGridViewTest]);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var form = new ModuleForm(_Email);
            Hide();
            form.ShowDialog();
            Close();
        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e) => SwitchTrueFalse([dataGridUser], [dataGridViewTest, dataGridViewTheoretical, buttonAdd, buttonDelete]);
        private void SwitchTrueFalse(List<Control> controlsForTrue, List<Control> controlsForFalse)
        {
            foreach(var c in controlsForFalse)
            {
                c.Visible = false;
            }
            foreach(var c in controlsForTrue)
            {
                c.Visible = true;
            }
        }
    }
}
