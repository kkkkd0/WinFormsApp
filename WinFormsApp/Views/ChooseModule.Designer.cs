namespace WinFormsApp.Views
{
    partial class ChooseModule
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
            buttonExit = new Button();
            buttonTherModule = new Button();
            buttonTestModule = new Button();
            title = new Label();
            plane.SuspendLayout();
            SuspendLayout();
            // 
            // plane
            // 
            plane.BackColor = Color.White;
            plane.BackgroundImageLayout = ImageLayout.Stretch;
            plane.Controls.Add(buttonExit);
            plane.Controls.Add(buttonTherModule);
            plane.Controls.Add(buttonTestModule);
            plane.Controls.Add(title);
            plane.Location = new Point(0, 1);
            plane.Name = "plane";
            plane.Size = new Size(405, 381);
            plane.TabIndex = 0;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Transparent;
            buttonExit.BackgroundImageLayout = ImageLayout.Stretch;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonExit.Location = new Point(12, 331);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(109, 33);
            buttonExit.TabIndex = 10;
            buttonExit.Text = "Назад";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonTherModule
            // 
            buttonTherModule.BackColor = Color.Transparent;
            buttonTherModule.FlatStyle = FlatStyle.Flat;
            buttonTherModule.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            buttonTherModule.ForeColor = Color.Black;
            buttonTherModule.Location = new Point(100, 165);
            buttonTherModule.Name = "buttonTherModule";
            buttonTherModule.Size = new Size(203, 34);
            buttonTherModule.TabIndex = 7;
            buttonTherModule.Text = "Теоретический";
            buttonTherModule.UseVisualStyleBackColor = false;
            buttonTherModule.Click += buttonTherModule_Click;
            // 
            // buttonTestModule
            // 
            buttonTestModule.BackColor = Color.Transparent;
            buttonTestModule.FlatStyle = FlatStyle.Flat;
            buttonTestModule.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            buttonTestModule.ForeColor = Color.Black;
            buttonTestModule.Location = new Point(100, 205);
            buttonTestModule.Name = "buttonTestModule";
            buttonTestModule.Size = new Size(203, 34);
            buttonTestModule.TabIndex = 6;
            buttonTestModule.Text = "Тестирование";
            buttonTestModule.UseVisualStyleBackColor = false;
            buttonTestModule.Click += buttonTestModule_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title.ForeColor = Color.Black;
            title.Location = new Point(31, 40);
            title.Name = "title";
            title.Size = new Size(347, 60);
            title.TabIndex = 5;
            title.Text = "Выберите модуль, который вы\r\nбудете проходить";
            title.TextAlign = ContentAlignment.TopCenter;
            // 
            // ChooseModule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 377);
            Controls.Add(plane);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChooseModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChooseModule";
            Load += ChooseModule_Load;
            plane.ResumeLayout(false);
            plane.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plane;
        private Label title;
        private Button buttonTestModule;
        private Button buttonTherModule;
        private Button buttonExit;
    }
}