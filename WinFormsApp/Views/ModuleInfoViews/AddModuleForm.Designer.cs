namespace WinFormsApp.Views
{
    partial class AddModuleForm
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
            labelQuantityTask = new Label();
            buttonOk = new Button();
            planeForTypeAttribute = new Panel();
            label1 = new Label();
            textName = new TextBox();
            title = new Label();
            plane.SuspendLayout();
            SuspendLayout();
            // 
            // plane
            // 
            plane.BackColor = Color.White;
            plane.Controls.Add(labelQuantityTask);
            plane.Controls.Add(buttonOk);
            plane.Controls.Add(planeForTypeAttribute);
            plane.Controls.Add(label1);
            plane.Controls.Add(textName);
            plane.Controls.Add(title);
            plane.Location = new Point(0, 1);
            plane.Name = "plane";
            plane.Size = new Size(411, 381);
            plane.TabIndex = 0;
            // 
            // labelQuantityTask
            // 
            labelQuantityTask.AutoSize = true;
            labelQuantityTask.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelQuantityTask.ForeColor = Color.Black;
            labelQuantityTask.Location = new Point(12, 335);
            labelQuantityTask.Name = "labelQuantityTask";
            labelQuantityTask.Size = new Size(146, 28);
            labelQuantityTask.TabIndex = 20;
            labelQuantityTask.Text = "Количество: 0";
            // 
            // buttonOk
            // 
            buttonOk.FlatStyle = FlatStyle.Flat;
            buttonOk.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOk.ForeColor = Color.Black;
            buttonOk.Location = new Point(300, 336);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(91, 28);
            buttonOk.TabIndex = 19;
            buttonOk.Text = "Готово";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // planeForTypeAttribute
            // 
            planeForTypeAttribute.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            planeForTypeAttribute.AutoScroll = true;
            planeForTypeAttribute.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            planeForTypeAttribute.ForeColor = Color.Black;
            planeForTypeAttribute.Location = new Point(13, 127);
            planeForTypeAttribute.Name = "planeForTypeAttribute";
            planeForTypeAttribute.RightToLeft = RightToLeft.No;
            planeForTypeAttribute.Size = new Size(378, 193);
            planeForTypeAttribute.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 75);
            label1.Name = "label1";
            label1.Size = new Size(52, 28);
            label1.TabIndex = 8;
            label1.Text = "Имя";
            // 
            // textName
            // 
            textName.Font = new Font("Sitka Text", 9.749999F);
            textName.ForeColor = Color.Black;
            textName.Location = new Point(71, 79);
            textName.Name = "textName";
            textName.Size = new Size(178, 24);
            textName.TabIndex = 7;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title.ForeColor = Color.Black;
            title.Location = new Point(93, 23);
            title.Name = "title";
            title.Size = new Size(227, 30);
            title.TabIndex = 6;
            title.Text = "Добавление модуля";
            // 
            // AddModuleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 377);
            Controls.Add(plane);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddModuleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddModuleForm";
            Load += AddModuleForm_Load;
            plane.ResumeLayout(false);
            plane.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plane;
        private Label label1;
        private TextBox textName;
        private Label title;
        private Panel planeForTypeAttribute;
        private Button buttonOk;
        private Label labelQuantityTask;
    }
}