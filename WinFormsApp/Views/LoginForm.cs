using BuisnesLogic.Service;
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

namespace WinFormsApp.Views
{
    public partial class LoginForm : Form
    {
        private PasswordManager _PasswordManager { get; set; }
        private IUserManager _UserManager { get; set; }
        public LoginForm(Point? location = null)
        {
            InitializeComponent();
            _PasswordManager = new PasswordManager();
            var database = DataBaseInit.GetAppDbContext();
            _UserManager = new UserManager(database);
            this.Location = location ?? new Point(0, 0);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputEmail.Text) |
                string.IsNullOrWhiteSpace(inputPassword.Text))
            {
                MessageBox.Show("Ошибка вы не ввели значение");
                return;
            }
            var user = _UserManager.Get(inputEmail.Text);
            if (user is null)
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }
            var res = _PasswordManager.Compare(inputPassword.Text, user.Salt!, user.PasswordHash!);
            if (!res)
            {
                MessageBox.Show("Неверный пароль");
                return;
            }
            AccountForm accountForm = new AccountForm(UserRegistration.MapToUserView(user), inputEmail.Text);
            Hide();
            accountForm.ShowDialog();
            Close();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var form = new StartForm();
            Hide();
            form.ShowDialog();
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            inputPassword.UseSystemPasswordChar = checkBox1.Checked;
        }
    }
}
