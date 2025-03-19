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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Hide();
            loginForm.ShowDialog();
            Close();

        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration();
            Hide();
            userRegistration.ShowDialog();
            Close();
        }
    }
}
