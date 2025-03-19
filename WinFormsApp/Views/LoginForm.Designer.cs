namespace WinFormsApp.Views
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            plane = new Panel();
            checkBox1 = new CheckBox();
            buttonExit = new Button();
            buttonSend = new Button();
            title = new Label();
            panel2 = new Panel();
            label2 = new Label();
            inputEmail = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            inputPassword = new TextBox();
            plane.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // plane
            // 
            plane.BackColor = Color.White;
            plane.BackgroundImageLayout = ImageLayout.Zoom;
            plane.Controls.Add(checkBox1);
            plane.Controls.Add(buttonExit);
            plane.Controls.Add(buttonSend);
            plane.Controls.Add(title);
            plane.Controls.Add(panel2);
            plane.Controls.Add(panel1);
            plane.Location = new Point(0, 1);
            plane.Name = "plane";
            plane.Size = new Size(410, 378);
            plane.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(330, 213);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 1;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Transparent;
            buttonExit.BackgroundImage = Properties.Resources.back;
            buttonExit.BackgroundImageLayout = ImageLayout.Stretch;
            buttonExit.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonExit.Location = new Point(12, 11);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(33, 33);
            buttonExit.TabIndex = 12;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonSend
            // 
            buttonSend.FlatStyle = FlatStyle.Flat;
            buttonSend.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSend.Location = new Point(144, 322);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(118, 33);
            buttonSend.TabIndex = 11;
            buttonSend.Text = "Вход";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title.ForeColor = Color.Black;
            title.Location = new Point(119, 31);
            title.Name = "title";
            title.Size = new Size(175, 30);
            title.TabIndex = 4;
            title.Text = "Вход в аккаунт";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(239, 239, 239);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(inputEmail);
            panel2.Location = new Point(78, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 36);
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 4);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 3;
            label2.Text = "Логин";
            // 
            // inputEmail
            // 
            inputEmail.Font = new Font("Sitka Text", 12F);
            inputEmail.Location = new Point(87, 2);
            inputEmail.Multiline = true;
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(156, 30);
            inputEmail.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(239, 239, 239);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(inputPassword);
            panel1.Location = new Point(78, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 36);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 14.2499981F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 3;
            label1.Text = "Пароль";
            // 
            // inputPassword
            // 
            inputPassword.Font = new Font("Sitka Text", 12F);
            inputPassword.Location = new Point(87, 3);
            inputPassword.Multiline = true;
            inputPassword.Name = "inputPassword";
            inputPassword.PasswordChar = '*';
            inputPassword.Size = new Size(156, 30);
            inputPassword.TabIndex = 2;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 377);
            Controls.Add(plane);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            plane.ResumeLayout(false);
            plane.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plane;
        private Panel panel2;
        private Label label2;
        private TextBox inputEmail;
        private Panel panel1;
        private Label label1;
        private TextBox inputPassword;
        private Label title;
        private Button buttonSend;
        private Button buttonExit;
        private CheckBox checkBox1;
    }
}