namespace WinFormsApp.Views
{
    partial class CompleteForm
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
            panel1 = new Panel();
            textName = new Label();
            textResult = new Label();
            buttonExit = new Button();
            title = new Label();
            plane.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // plane
            // 
            plane.BackColor = Color.White;
            plane.BackgroundImageLayout = ImageLayout.Stretch;
            plane.Controls.Add(panel1);
            plane.Controls.Add(buttonExit);
            plane.Controls.Add(title);
            plane.Location = new Point(0, 1);
            plane.Name = "plane";
            plane.Size = new Size(523, 323);
            plane.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(239, 239, 239);
            panel1.Controls.Add(textName);
            panel1.Controls.Add(textResult);
            panel1.Location = new Point(12, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 147);
            panel1.TabIndex = 11;
            // 
            // textName
            // 
            textName.AutoSize = true;
            textName.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold);
            textName.ForeColor = Color.Black;
            textName.Location = new Point(13, 31);
            textName.Name = "textName";
            textName.Size = new Size(67, 28);
            textName.TabIndex = 10;
            textName.Text = "Тема:";
            // 
            // textResult
            // 
            textResult.AutoSize = true;
            textResult.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold);
            textResult.ForeColor = Color.Black;
            textResult.Location = new Point(13, 87);
            textResult.Name = "textResult";
            textResult.Size = new Size(169, 28);
            textResult.TabIndex = 8;
            textResult.Text = "Ваш результат: ";
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Transparent;
            buttonExit.BackgroundImageLayout = ImageLayout.Stretch;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonExit.Location = new Point(12, 269);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(109, 33);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "Назад";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title.ForeColor = Color.Black;
            title.Location = new Point(105, 22);
            title.Name = "title";
            title.Size = new Size(296, 30);
            title.TabIndex = 7;
            title.Text = "Результаты тестирования";
            // 
            // CompleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 315);
            Controls.Add(plane);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CompleteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompleteForm";
            Load += CompleteForm_Load;
            plane.ResumeLayout(false);
            plane.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plane;
        private Label textResult;
        private Label title;
        private Button buttonExit;
        private Label textName;
        private Panel panel1;
    }
}