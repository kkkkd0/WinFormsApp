namespace WinFormsApp.Views
{
    partial class TaskForm
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
            buttonComplete = new Button();
            buttonExit = new Button();
            buttonChange = new Button();
            buttonBefore = new Button();
            buttonNext = new Button();
            planeforQuestion = new Panel();
            planeforAnswer = new Panel();
            buttonAnswer = new Button();
            title = new Label();
            plane.SuspendLayout();
            planeforQuestion.SuspendLayout();
            SuspendLayout();
            // 
            // plane
            // 
            plane.AutoSize = true;
            plane.BackColor = Color.White;
            plane.Controls.Add(buttonComplete);
            plane.Controls.Add(buttonExit);
            plane.Controls.Add(buttonChange);
            plane.Controls.Add(buttonBefore);
            plane.Controls.Add(buttonNext);
            plane.Controls.Add(planeforQuestion);
            plane.Controls.Add(buttonAnswer);
            plane.Controls.Add(title);
            plane.ForeColor = Color.White;
            plane.Location = new Point(0, 1);
            plane.Name = "plane";
            plane.Size = new Size(804, 450);
            plane.TabIndex = 0;
            // 
            // buttonComplete
            // 
            buttonComplete.BackColor = Color.Transparent;
            buttonComplete.FlatStyle = FlatStyle.Popup;
            buttonComplete.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            buttonComplete.ForeColor = Color.Black;
            buttonComplete.Location = new Point(627, 398);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(139, 33);
            buttonComplete.TabIndex = 14;
            buttonComplete.Text = "Завершить";
            buttonComplete.UseVisualStyleBackColor = false;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Transparent;
            buttonExit.BackgroundImageLayout = ImageLayout.Stretch;
            buttonExit.FlatStyle = FlatStyle.Popup;
            buttonExit.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonExit.ForeColor = Color.Black;
            buttonExit.Location = new Point(20, 15);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(131, 33);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "Вернуться";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonChange
            // 
            buttonChange.BackColor = Color.Transparent;
            buttonChange.FlatStyle = FlatStyle.Popup;
            buttonChange.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            buttonChange.ForeColor = Color.Black;
            buttonChange.Location = new Point(50, 398);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(139, 33);
            buttonChange.TabIndex = 13;
            buttonChange.Text = "Изменить ответ";
            buttonChange.UseVisualStyleBackColor = false;
            buttonChange.Visible = false;
            buttonChange.Click += buttonChange_Click;
            // 
            // buttonBefore
            // 
            buttonBefore.BackColor = Color.Transparent;
            buttonBefore.FlatStyle = FlatStyle.Popup;
            buttonBefore.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            buttonBefore.ForeColor = Color.Black;
            buttonBefore.Location = new Point(240, 398);
            buttonBefore.Name = "buttonBefore";
            buttonBefore.Size = new Size(139, 33);
            buttonBefore.TabIndex = 12;
            buttonBefore.Text = "Назад";
            buttonBefore.UseVisualStyleBackColor = false;
            buttonBefore.Click += buttonBefore_Click;
            // 
            // buttonNext
            // 
            buttonNext.BackColor = Color.Transparent;
            buttonNext.FlatStyle = FlatStyle.Popup;
            buttonNext.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            buttonNext.ForeColor = Color.Black;
            buttonNext.Location = new Point(437, 398);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(139, 33);
            buttonNext.TabIndex = 11;
            buttonNext.Text = "Дальше";
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // planeforQuestion
            // 
            planeforQuestion.AutoScroll = true;
            planeforQuestion.AutoSize = true;
            planeforQuestion.Controls.Add(planeforAnswer);
            planeforQuestion.ForeColor = Color.Black;
            planeforQuestion.Location = new Point(20, 61);
            planeforQuestion.Name = "planeforQuestion";
            planeforQuestion.Size = new Size(768, 303);
            planeforQuestion.TabIndex = 9;
            // 
            // planeforAnswer
            // 
            planeforAnswer.AutoScroll = true;
            planeforAnswer.ForeColor = Color.Black;
            planeforAnswer.Location = new Point(0, 0);
            planeforAnswer.Name = "planeforAnswer";
            planeforAnswer.Size = new Size(223, 169);
            planeforAnswer.TabIndex = 10;
            // 
            // buttonAnswer
            // 
            buttonAnswer.BackColor = Color.Transparent;
            buttonAnswer.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAnswer.ForeColor = Color.Black;
            buttonAnswer.Location = new Point(50, 398);
            buttonAnswer.Name = "buttonAnswer";
            buttonAnswer.Size = new Size(139, 33);
            buttonAnswer.TabIndex = 7;
            buttonAnswer.Text = "Ответить";
            buttonAnswer.UseVisualStyleBackColor = false;
            buttonAnswer.Click += buttonAnswer_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title.ForeColor = Color.Black;
            title.Location = new Point(218, 18);
            title.Name = "title";
            title.Size = new Size(103, 30);
            title.TabIndex = 6;
            title.Text = "Задание";
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(plane);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TaskForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskForm";
            Load += TaskForm_Load;
            plane.ResumeLayout(false);
            plane.PerformLayout();
            planeforQuestion.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel plane;
        private Label title;
        private Button buttonAnswer;
        private Panel planeforAnswer;
        private Panel planeforQuestion;
        private Button buttonChange;
        private Button buttonBefore;
        private Button buttonNext;
        private Button buttonComplete;
        private Button buttonExit;
    }
}