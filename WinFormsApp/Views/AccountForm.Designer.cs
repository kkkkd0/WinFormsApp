namespace WinFormsApp.Views
{
    partial class AccountForm
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
            buttonAdminPanel = new Button();
            buttonReview = new Button();
            buttonExit = new Button();
            panel1 = new Panel();
            Group = new Label();
            Patronymic = new Label();
            Surname = new Label();
            Name = new Label();
            title = new Label();
            plane.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // plane
            // 
            plane.BackColor = Color.White;
            plane.BackgroundImageLayout = ImageLayout.Stretch;
            plane.Controls.Add(buttonAdminPanel);
            plane.Controls.Add(buttonReview);
            plane.Controls.Add(buttonExit);
            plane.Controls.Add(panel1);
            plane.Controls.Add(title);
            plane.Location = new Point(0, 1);
            plane.Name = "plane";
            plane.Size = new Size(525, 324);
            plane.TabIndex = 0;
            // 
            // buttonAdminPanel
            // 
            buttonAdminPanel.FlatStyle = FlatStyle.Flat;
            buttonAdminPanel.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAdminPanel.Location = new Point(185, 269);
            buttonAdminPanel.Name = "buttonAdminPanel";
            buttonAdminPanel.Size = new Size(149, 33);
            buttonAdminPanel.TabIndex = 13;
            buttonAdminPanel.Text = "База данных";
            buttonAdminPanel.UseVisualStyleBackColor = true;
            buttonAdminPanel.Click += buttonAdminPanel_Click;
            // 
            // buttonReview
            // 
            buttonReview.FlatStyle = FlatStyle.Flat;
            buttonReview.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonReview.Location = new Point(356, 269);
            buttonReview.Name = "buttonReview";
            buttonReview.Size = new Size(149, 33);
            buttonReview.TabIndex = 12;
            buttonReview.Text = "Обратная связь";
            buttonReview.UseVisualStyleBackColor = true;
            buttonReview.Click += buttonReview_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Transparent;
            buttonExit.BackgroundImageLayout = ImageLayout.Stretch;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonExit.Location = new Point(12, 269);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(149, 33);
            buttonExit.TabIndex = 8;
            buttonExit.Text = "Главная";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(239, 239, 239);
            panel1.Controls.Add(Group);
            panel1.Controls.Add(Patronymic);
            panel1.Controls.Add(Surname);
            panel1.Controls.Add(Name);
            panel1.Location = new Point(111, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 169);
            panel1.TabIndex = 7;
            // 
            // Group
            // 
            Group.AutoSize = true;
            Group.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold);
            Group.ForeColor = Color.Black;
            Group.Location = new Point(3, 128);
            Group.Name = "Group";
            Group.Size = new Size(91, 28);
            Group.TabIndex = 3;
            Group.Text = "Группа:";
            // 
            // Patronymic
            // 
            Patronymic.AutoSize = true;
            Patronymic.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold);
            Patronymic.ForeColor = Color.Black;
            Patronymic.Location = new Point(1, 90);
            Patronymic.Name = "Patronymic";
            Patronymic.Size = new Size(108, 28);
            Patronymic.TabIndex = 2;
            Patronymic.Text = "Отчество:";
            // 
            // Surname
            // 
            Surname.AutoSize = true;
            Surname.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold);
            Surname.ForeColor = Color.Black;
            Surname.Location = new Point(1, 48);
            Surname.Name = "Surname";
            Surname.Size = new Size(110, 28);
            Surname.TabIndex = 1;
            Surname.Text = "Фамилия:";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold);
            Name.ForeColor = Color.Black;
            Name.Location = new Point(3, 10);
            Name.Name = "Name";
            Name.Size = new Size(61, 28);
            Name.TabIndex = 0;
            Name.Text = "Имя:";
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title.ForeColor = Color.Black;
            title.Location = new Point(167, 22);
            title.Name = "title";
            title.Size = new Size(199, 30);
            title.TabIndex = 6;
            title.Text = "Личный кабинет";
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 315);
            Controls.Add(plane);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
//            Name = "AccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            Load += Account_Load;
            plane.ResumeLayout(false);
            plane.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plane;
        private Panel panel1;
        private Label title;
        private Label Group;
        private Label Patronymic;
        private Label Surname;
        private Label Name;
        private Button buttonExit;
        private Button buttonReview;
        private Button buttonAdminPanel;
    }
}