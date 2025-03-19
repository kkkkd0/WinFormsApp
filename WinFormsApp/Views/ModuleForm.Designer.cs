namespace WinFormsApp.Views
{
    partial class ModuleForm
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
            buttonAccount = new Button();
            flowModulePanel = new FlowLayoutPanel();
            title = new Label();
            plane.SuspendLayout();
            SuspendLayout();
            // 
            // plane
            // 
            plane.BackColor = Color.White;
            plane.Controls.Add(buttonAccount);
            plane.Controls.Add(flowModulePanel);
            plane.Controls.Add(title);
            plane.Location = new Point(0, 0);
            plane.Name = "plane";
            plane.Size = new Size(407, 383);
            plane.TabIndex = 0;
            // 
            // buttonAccount
            // 
            buttonAccount.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAccount.FlatStyle = FlatStyle.Flat;
            buttonAccount.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAccount.Location = new Point(282, 332);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Size = new Size(109, 33);
            buttonAccount.TabIndex = 9;
            buttonAccount.Text = "Назад";
            buttonAccount.UseVisualStyleBackColor = true;
            buttonAccount.Click += buttonAccount_Click;
            // 
            // flowModulePanel
            // 
            flowModulePanel.AutoScroll = true;
            flowModulePanel.FlowDirection = FlowDirection.TopDown;
            flowModulePanel.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flowModulePanel.Location = new Point(12, 82);
            flowModulePanel.Name = "flowModulePanel";
            flowModulePanel.Size = new Size(379, 244);
            flowModulePanel.TabIndex = 8;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title.ForeColor = Color.Black;
            title.Location = new Point(161, 29);
            title.Name = "title";
            title.Size = new Size(72, 30);
            title.TabIndex = 6;
            title.Text = "Темы";
            // 
            // ModuleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 377);
            Controls.Add(plane);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ModuleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModuleForm";
            Load += ModuleForm_Load;
            plane.ResumeLayout(false);
            plane.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plane;
        private Label title;
        private FlowLayoutPanel flowModulePanel;
        private Button buttonAccount;
    }
}