namespace WinFormsApp.Views
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            plane = new Panel();
            title = new Label();
            buttonLogin = new Button();
            buttonRegistration = new Button();
            pictureBox1 = new PictureBox();
            plane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // plane
            // 
            plane.BackColor = Color.White;
            plane.BackgroundImageLayout = ImageLayout.Stretch;
            plane.Controls.Add(title);
            plane.Controls.Add(buttonLogin);
            plane.Controls.Add(buttonRegistration);
            plane.Controls.Add(pictureBox1);
            plane.Location = new Point(-5, -3);
            plane.Name = "plane";
            plane.Size = new Size(523, 322);
            plane.TabIndex = 1;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title.ForeColor = SystemColors.ActiveCaptionText;
            title.Location = new Point(27, 112);
            title.Name = "title";
            title.Size = new Size(483, 90);
            title.TabIndex = 5;
            title.Text = "Добро пожаловать \r\nв обучающее приложение\r\nпо изучению языка программирования C#";
            title.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.White;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLogin.Location = new Point(294, 236);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(142, 35);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Вход";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonRegistration
            // 
            buttonRegistration.BackColor = Color.Transparent;
            buttonRegistration.FlatStyle = FlatStyle.Flat;
            buttonRegistration.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRegistration.Location = new Point(94, 236);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(142, 35);
            buttonRegistration.TabIndex = 1;
            buttonRegistration.Text = "Регистрация";
            buttonRegistration.UseVisualStyleBackColor = false;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(210, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 315);
            Controls.Add(plane);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartForm";
            plane.ResumeLayout(false);
            plane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel plane;
        private Button buttonRegistration;
        private Button buttonLogin;
        private Label title;
        private PictureBox pictureBox1;
    }
}