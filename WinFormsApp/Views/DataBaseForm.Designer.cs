namespace WinFormsApp.Views
{
    partial class DataBaseForm
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
            radioButtonUser = new RadioButton();
            buttonExit = new Button();
            radioButtonTheoreticalActive = new RadioButton();
            radioButtonTestActive = new RadioButton();
            buttonDelete = new Button();
            buttonAdd = new Button();
            dataGridViewTest = new DataGridView();
            title = new Label();
            dataGridUser = new DataGridView();
            dataGridViewTheoretical = new DataGridView();
            plane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTheoretical).BeginInit();
            SuspendLayout();
            // 
            // plane
            // 
            plane.BackColor = Color.White;
            plane.BackgroundImageLayout = ImageLayout.Stretch;
            plane.Controls.Add(radioButtonUser);
            plane.Controls.Add(buttonExit);
            plane.Controls.Add(radioButtonTheoreticalActive);
            plane.Controls.Add(radioButtonTestActive);
            plane.Controls.Add(buttonDelete);
            plane.Controls.Add(buttonAdd);
            plane.Controls.Add(dataGridViewTest);
            plane.Controls.Add(title);
            plane.Controls.Add(dataGridUser);
            plane.Controls.Add(dataGridViewTheoretical);
            plane.Location = new Point(0, 1);
            plane.Name = "plane";
            plane.Size = new Size(721, 343);
            plane.TabIndex = 0;
            // 
            // radioButtonUser
            // 
            radioButtonUser.AutoSize = true;
            radioButtonUser.BackColor = Color.Transparent;
            radioButtonUser.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButtonUser.Location = new Point(506, 39);
            radioButtonUser.Name = "radioButtonUser";
            radioButtonUser.Size = new Size(184, 22);
            radioButtonUser.TabIndex = 18;
            radioButtonUser.TabStop = true;
            radioButtonUser.Text = "Таблица с пользователями";
            radioButtonUser.UseVisualStyleBackColor = false;
            radioButtonUser.CheckedChanged += radioButtonUser_CheckedChanged;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Transparent;
            buttonExit.BackgroundImageLayout = ImageLayout.Stretch;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            buttonExit.Location = new Point(581, 294);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(109, 33);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "Назад";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // radioButtonTheoreticalActive
            // 
            radioButtonTheoreticalActive.AutoSize = true;
            radioButtonTheoreticalActive.BackColor = Color.Transparent;
            radioButtonTheoreticalActive.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButtonTheoreticalActive.Location = new Point(365, 39);
            radioButtonTheoreticalActive.Name = "radioButtonTheoreticalActive";
            radioButtonTheoreticalActive.Size = new Size(135, 22);
            radioButtonTheoreticalActive.TabIndex = 16;
            radioButtonTheoreticalActive.TabStop = true;
            radioButtonTheoreticalActive.Text = "Таблица с теорией";
            radioButtonTheoreticalActive.UseVisualStyleBackColor = false;
            radioButtonTheoreticalActive.CheckedChanged += radioButtonTheoreticalActive_CheckedChanged;
            // 
            // radioButtonTestActive
            // 
            radioButtonTestActive.AutoSize = true;
            radioButtonTestActive.BackColor = Color.Transparent;
            radioButtonTestActive.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButtonTestActive.Location = new Point(225, 39);
            radioButtonTestActive.Name = "radioButtonTestActive";
            radioButtonTestActive.Size = new Size(134, 22);
            radioButtonTestActive.TabIndex = 1;
            radioButtonTestActive.TabStop = true;
            radioButtonTestActive.Text = "Таблица с тестами";
            radioButtonTestActive.UseVisualStyleBackColor = false;
            radioButtonTestActive.CheckedChanged += radioButtonTestActive_CheckedChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            buttonDelete.Location = new Point(195, 294);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(109, 33);
            buttonDelete.TabIndex = 15;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            buttonAdd.Location = new Point(23, 294);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(113, 33);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewTest
            // 
            dataGridViewTest.AllowUserToAddRows = false;
            dataGridViewTest.BackgroundColor = Color.FromArgb(239, 239, 239);
            dataGridViewTest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTest.Location = new Point(23, 67);
            dataGridViewTest.Name = "dataGridViewTest";
            dataGridViewTest.Size = new Size(667, 205);
            dataGridViewTest.TabIndex = 6;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title.ForeColor = Color.Black;
            title.Location = new Point(23, 31);
            title.Name = "title";
            title.Size = new Size(151, 30);
            title.TabIndex = 5;
            title.Text = "База данных";
            // 
            // dataGridUser
            // 
            dataGridUser.BackgroundColor = Color.FromArgb(239, 239, 239);
            dataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUser.Location = new Point(23, 67);
            dataGridUser.Name = "dataGridUser";
            dataGridUser.Size = new Size(667, 205);
            dataGridUser.TabIndex = 17;
            // 
            // dataGridViewTheoretical
            // 
            dataGridViewTheoretical.BackgroundColor = Color.FromArgb(239, 239, 239);
            dataGridViewTheoretical.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTheoretical.Location = new Point(23, 67);
            dataGridViewTheoretical.Name = "dataGridViewTheoretical";
            dataGridViewTheoretical.Size = new Size(667, 205);
            dataGridViewTheoretical.TabIndex = 12;
            // 
            // DataBaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 343);
            Controls.Add(plane);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DataBaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DataBaseForm";
            Load += DataBaseForm_Load;
            plane.ResumeLayout(false);
            plane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTest).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTheoretical).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel plane;
        private DataGridView dataGridViewTest;
        private Label title;
        private DataGridView dataGridViewTheoretical;
        private Button buttonDelete;
        private Button buttonAdd;
        private RadioButton radioButtonTheoreticalActive;
        private RadioButton radioButtonTestActive;
        private Button buttonExit;
        private RadioButton radioButtonUser;
        private DataGridView dataGridUser;
    }
}