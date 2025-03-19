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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Views
{
    public partial class ReviewsForm : Form
    {
        private IUserManager _UserManager { get; set; }
        private string _Email { get; set; }
        public ReviewsForm(string email, Point? location = null)
        {
            InitializeComponent();

            var database = DataBaseInit.GetAppDbContext();

            _UserManager = new UserManager(database);

            _Email = email;

            this.Location = location ?? new Point(0, 0);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            var user = _UserManager.Get(_Email);
            Review review = new Review()
            {
                Text = textReview.Text,
            };
            if (user is null) return;


            user.Reviews.Add(review);
            _UserManager.Update(_Email, user);
            Hide();
            var form = new AccountForm(UserRegistration.MapToUserView(user), _Email);
            form.ShowDialog();
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
