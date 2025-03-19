namespace WinFormsApp.Views
{
    partial class UserRegistration
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
            panel4 = new Panel();
            label4 = new Label();
            inputEmail = new TextBox();
            buttonSend = new Button();
            panel3 = new Panel();
            label3 = new Label();
            inputGroups = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            inputPassword = new TextBox();
            InputContainer = new Panel();
            text = new Label();
            inputFIO = new TextBox();
            title = new Label();
            plane.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            InputContainer.SuspendLayout();
            SuspendLayout();
            // 
            // plane
            // 
            plane.BackColor = Color.White;
            plane.BackgroundImageLayout = ImageLayout.Stretch;
            plane.Controls.Add(checkBox1);
            plane.Controls.Add(buttonExit);
            plane.Controls.Add(panel4);
            plane.Controls.Add(buttonSend);
            plane.Controls.Add(panel3);
            plane.Controls.Add(panel1);
            plane.Controls.Add(InputContainer);
            plane.Controls.Add(title);
            plane.Location = new Point(0, 1);
            plane.Name = "plane";
            plane.Size = new Size(408, 383);
            plane.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(330, 270);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 14;
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
            buttonExit.TabIndex = 13;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(239, 239, 239);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(inputEmail);
            panel4.Location = new Point(78, 200);
            panel4.Name = "panel4";
            panel4.Size = new Size(246, 36);
            panel4.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 14.2499981F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(0, 2);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 3;
            label4.Text = "Логин";
            // 
            // inputEmail
            // 
            inputEmail.Font = new Font("Sitka Text", 12F);
            inputEmail.Location = new Point(89, 3);
            inputEmail.Multiline = true;
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(154, 30);
            inputEmail.TabIndex = 2;
            // 
            // buttonSend
            // 
            buttonSend.BackColor = Color.Transparent;
            buttonSend.FlatStyle = FlatStyle.Flat;
            buttonSend.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSend.Location = new Point(104, 322);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(197, 33);
            buttonSend.TabIndex = 10;
            buttonSend.Text = "Зарегистрироваться";
            buttonSend.UseVisualStyleBackColor = false;
            buttonSend.Click += buttonSend_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(239, 239, 239);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(inputGroups);
            panel3.ImeMode = ImeMode.NoControl;
            panel3.Location = new Point(78, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(246, 36);
            panel3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 14.2499981F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(0, 2);
            label3.Name = "label3";
            label3.Size = new Size(78, 28);
            label3.TabIndex = 3;
            label3.Text = "Группа";
            // 
            // inputGroups
            // 
            inputGroups.Font = new Font("Sitka Text", 12F);
            inputGroups.Location = new Point(89, 3);
            inputGroups.Multiline = true;
            inputGroups.Name = "inputGroups";
            inputGroups.Size = new Size(154, 30);
            inputGroups.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(239, 239, 239);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(inputPassword);
            panel1.Location = new Point(78, 256);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 36);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 14.2499981F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 3);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 3;
            label1.Text = "Пароль";
            // 
            // inputPassword
            // 
            inputPassword.Font = new Font("Sitka Text", 12F);
            inputPassword.Location = new Point(89, 3);
            inputPassword.Multiline = true;
            inputPassword.Name = "inputPassword";
            inputPassword.PasswordChar = '*';
            inputPassword.Size = new Size(154, 30);
            inputPassword.TabIndex = 2;
            // 
            // InputContainer
            // 
            InputContainer.BackColor = Color.FromArgb(239, 239, 239);
            InputContainer.Controls.Add(text);
            InputContainer.Controls.Add(inputFIO);
            InputContainer.Location = new Point(78, 88);
            InputContainer.Name = "InputContainer";
            InputContainer.Size = new Size(246, 36);
            InputContainer.TabIndex = 3;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Font = new Font("Sitka Text", 14.2499981F);
            text.ForeColor = Color.Black;
            text.Location = new Point(0, 2);
            text.Name = "text";
            text.Size = new Size(54, 28);
            text.TabIndex = 3;
            text.Text = "ФИО";
            // 
            // inputFIO
            // 
            inputFIO.Font = new Font("Sitka Text", 12F);
            inputFIO.Location = new Point(87, 3);
            inputFIO.Multiline = true;
            inputFIO.Name = "inputFIO";
            inputFIO.Size = new Size(156, 30);
            inputFIO.TabIndex = 2;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title.ForeColor = Color.Black;
            title.Location = new Point(126, 31);
            title.Name = "title";
            title.Size = new Size(152, 30);
            title.TabIndex = 1;
            title.Text = "Регистрация";
            // 
            // UserRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 377);
            Controls.Add(plane);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UserRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserRegistration";
            plane.ResumeLayout(false);
            plane.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            InputContainer.ResumeLayout(false);
            InputContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plane;
        private Label title;
        private Panel InputContainer;
        private Label text;
        private TextBox inputFIO;
        private Panel panel1;
        private Label label1;
        private TextBox inputPassword;
        private Panel panel3;
        private Label label3;
        private TextBox inputGroups;
        private Button buttonSend;
        private Panel panel4;
        private Label label4;
        private TextBox inputEmail;
        private Button buttonExit;
        private CheckBox checkBox1;
    }
}