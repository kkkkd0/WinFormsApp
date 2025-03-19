using Amazon.S3.Model;
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
    public partial class CompleteForm : Form
    {
        private (int userResult, int correctResult) _Result;
        private string _Name;
        private string _Email;
        public CompleteForm(int ur, int cr, string name, string email, Point? location = null)
        {
            InitializeComponent();
            _Result.correctResult = cr;
            _Result.userResult = ur;
            _Name = name;
            _Email = email;
            this.Location = location ?? new Point(0,0);
        }
        private void CompleteForm_Load(object sender, EventArgs e)
        {
            textResult.Text += _Result.userResult + "/" + _Result.correctResult;
            textName.Text += _Name;
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
