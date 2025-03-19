namespace WinFormsApp.Views.ModuleInfoViews
{
    partial class AddAssigment
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
            labelQuantityFile = new Label();
            label4 = new Label();
            textBoxQuestion = new TextBox();
            buttonOk = new Button();
            buttonOpenFile = new Button();
            radioButtonCheck = new RadioButton();
            radioButtonRadio = new RadioButton();
            label3 = new Label();
            radioButtonText = new RadioButton();
            label2 = new Label();
            textBoxConfusing = new TextBox();
            label1 = new Label();
            textCorrect = new TextBox();
            title = new Label();
            plane.SuspendLayout();
            SuspendLayout();
            // 
            // plane
            // 
            plane.BackColor = Color.White;
            plane.Controls.Add(labelQuantityFile);
            plane.Controls.Add(label4);
            plane.Controls.Add(textBoxQuestion);
            plane.Controls.Add(buttonOk);
            plane.Controls.Add(buttonOpenFile);
            plane.Controls.Add(radioButtonCheck);
            plane.Controls.Add(radioButtonRadio);
            plane.Controls.Add(label3);
            plane.Controls.Add(radioButtonText);
            plane.Controls.Add(label2);
            plane.Controls.Add(textBoxConfusing);
            plane.Controls.Add(label1);
            plane.Controls.Add(textCorrect);
            plane.Controls.Add(title);
            plane.Location = new Point(0, 1);
            plane.Name = "plane";
            plane.Size = new Size(609, 426);
            plane.TabIndex = 0;
            // 
            // labelQuantityFile
            // 
            labelQuantityFile.AutoSize = true;
            labelQuantityFile.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelQuantityFile.ForeColor = Color.Black;
            labelQuantityFile.Location = new Point(404, 346);
            labelQuantityFile.Name = "labelQuantityFile";
            labelQuantityFile.Size = new Size(124, 23);
            labelQuantityFile.TabIndex = 21;
            labelQuantityFile.Text = "Количество: 0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 14.2499981F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(24, 56);
            label4.Name = "label4";
            label4.Size = new Size(78, 28);
            label4.TabIndex = 20;
            label4.Text = "Вопрос";
            label4.Click += label4_Click;
            // 
            // textBoxQuestion
            // 
            textBoxQuestion.Font = new Font("Sitka Text", 14.2499981F);
            textBoxQuestion.ForeColor = Color.Black;
            textBoxQuestion.Location = new Point(24, 87);
            textBoxQuestion.Name = "textBoxQuestion";
            textBoxQuestion.Size = new Size(178, 31);
            textBoxQuestion.TabIndex = 19;
            // 
            // buttonOk
            // 
            buttonOk.FlatStyle = FlatStyle.Flat;
            buttonOk.Font = new Font("Sitka Text", 12F);
            buttonOk.ForeColor = Color.Black;
            buttonOk.Location = new Point(404, 376);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(187, 31);
            buttonOk.TabIndex = 18;
            buttonOk.Text = "Готово";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.FlatStyle = FlatStyle.Flat;
            buttonOpenFile.Font = new Font("Sitka Text", 12F);
            buttonOpenFile.ForeColor = Color.Black;
            buttonOpenFile.Location = new Point(24, 378);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(131, 31);
            buttonOpenFile.TabIndex = 17;
            buttonOpenFile.Text = "Добавить файлы";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // radioButtonCheck
            // 
            radioButtonCheck.AutoSize = true;
            radioButtonCheck.Font = new Font("Sitka Text", 14.2499981F);
            radioButtonCheck.ForeColor = Color.Black;
            radioButtonCheck.Location = new Point(24, 340);
            radioButtonCheck.Name = "radioButtonCheck";
            radioButtonCheck.Size = new Size(108, 32);
            radioButtonCheck.TabIndex = 16;
            radioButtonCheck.TabStop = true;
            radioButtonCheck.Text = "Отметка";
            radioButtonCheck.UseVisualStyleBackColor = true;
            radioButtonCheck.CheckedChanged += radioButtonCheck_CheckedChanged;
            // 
            // radioButtonRadio
            // 
            radioButtonRadio.AutoSize = true;
            radioButtonRadio.Font = new Font("Sitka Text", 14.2499981F);
            radioButtonRadio.ForeColor = Color.Black;
            radioButtonRadio.Location = new Point(24, 315);
            radioButtonRadio.Name = "radioButtonRadio";
            radioButtonRadio.Size = new Size(90, 32);
            radioButtonRadio.TabIndex = 15;
            radioButtonRadio.TabStop = true;
            radioButtonRadio.Text = "Выбор";
            radioButtonRadio.UseVisualStyleBackColor = true;
            radioButtonRadio.CheckedChanged += radioButtonRadio_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 14.2499981F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(24, 256);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 14;
            label3.Text = "Тип ввода";
            // 
            // radioButtonText
            // 
            radioButtonText.AutoSize = true;
            radioButtonText.Font = new Font("Sitka Text", 14.2499981F);
            radioButtonText.ForeColor = Color.Black;
            radioButtonText.Location = new Point(24, 287);
            radioButtonText.Name = "radioButtonText";
            radioButtonText.Size = new Size(81, 32);
            radioButtonText.TabIndex = 13;
            radioButtonText.TabStop = true;
            radioButtonText.Text = "Текст";
            radioButtonText.UseVisualStyleBackColor = true;
            radioButtonText.CheckedChanged += radioButtonText_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(24, 191);
            label2.Name = "label2";
            label2.Size = new Size(486, 28);
            label2.TabIndex = 12;
            label2.Text = "Перечислите неправильные ответы через запятую";
            // 
            // textBoxConfusing
            // 
            textBoxConfusing.Font = new Font("Sitka Text", 14.2499981F);
            textBoxConfusing.ForeColor = Color.Black;
            textBoxConfusing.Location = new Point(24, 222);
            textBoxConfusing.Name = "textBoxConfusing";
            textBoxConfusing.Size = new Size(178, 31);
            textBoxConfusing.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 14.2499981F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(24, 123);
            label1.Name = "label1";
            label1.Size = new Size(188, 28);
            label1.TabIndex = 10;
            label1.Text = "Правильный ответ";
            // 
            // textCorrect
            // 
            textCorrect.Font = new Font("Sitka Text", 14.2499981F);
            textCorrect.ForeColor = Color.Black;
            textCorrect.Location = new Point(24, 154);
            textCorrect.Name = "textCorrect";
            textCorrect.Size = new Size(178, 31);
            textCorrect.TabIndex = 9;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title.ForeColor = Color.Black;
            title.Location = new Point(204, 20);
            title.Name = "title";
            title.Size = new Size(205, 30);
            title.TabIndex = 7;
            title.Text = "Добавление теста";
            // 
            // AddAssigment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 420);
            Controls.Add(plane);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddAssigment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAssigment";
            Load += AddAssigment_Load;
            plane.ResumeLayout(false);
            plane.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plane;
        private Label title;
        private Label label1;
        private TextBox textCorrect;
        private Label label2;
        private TextBox textBoxConfusing;
        private RadioButton radioButtonText;
        private RadioButton radioButtonCheck;
        private RadioButton radioButtonRadio;
        private Label label3;
        private Button buttonOpenFile;
        private Button buttonOk;
        private Label label4;
        private TextBox textBoxQuestion;
        private Label labelQuantityFile;
    }
}