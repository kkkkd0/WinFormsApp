using BuisnessLogic.Services.Managers;
using Data.DataBase;
using Data.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Models;

namespace WinFormsApp.Views
{
    public partial class AccountForm : Form
    {
        private UserViewModel _User { get; set; }
        private string _Email { get; set; }
        private IUserManager _UserManager { get; set; }
        public AccountForm(UserViewModel viewModel, string email, Point? loacation = null)
        {
             InitializeComponent();
            _User = viewModel;
            _Email = email;
            var database = DataBaseInit.GetAppDbContext();
            _UserManager = new UserManager(database);
            this.Location = loacation ?? new Point(0,0);
        }

        private void Account_Load(object sender, EventArgs e)
        {
            var user = _UserManager.Get(_Email);
            if (user is not null)
            {
                buttonAdminPanel.Visible = user.IsAdmin is true;
            }
            else
            {
                buttonAdminPanel.Visible = false;
            }
            Patronymic.Text += ValidValue(_User.Patronymic);
            Surname.Text += ValidValue(_User.Surname);
            Name.Text += ValidValue(_User.Name);
            Group.Text += ValidValue(_User.Group);
        }
        private string ValidValue(string str) => string.IsNullOrWhiteSpace(str) ? string.Empty : str.Length > 10 ? str.Substring(0, 10) + "..." : str;

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var form = new ModuleForm(_Email);
            Hide();
            form.ShowDialog();
            Close();
        }

        private void buttonReview_Click(object sender, EventArgs e)
        {
            var form = new ReviewsForm(_Email);
            Hide();
            form.ShowDialog();
            Close();
        }

        private void buttonAdminPanel_Click(object sender, EventArgs e)
        {
            var form = new DataBaseForm(_Email, this.Location);
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
