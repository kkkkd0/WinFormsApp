namespace WinFormsApp.Views
{
    partial class ReviewsForm
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
            buttonSend = new Button();
            textReview = new TextBox();
            title = new Label();
            plane.SuspendLayout();
            SuspendLayout();
            // 
            // plane
            // 
            plane.BackColor = Color.White;
            plane.BackgroundImageLayout = ImageLayout.Stretch;
            plane.Controls.Add(buttonExit);
            plane.Controls.Add(buttonSend);
            plane.Controls.Add(textReview);
            plane.Controls.Add(title);
            plane.Location = new Point(0, 1);
            plane.Name = "plane";
            plane.Size = new Size(524, 323);
            plane.TabIndex = 0;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Transparent;
            buttonExit.BackgroundImageLayout = ImageLayout.Stretch;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonExit.ForeColor = Color.Black;
            buttonExit.Location = new Point(91, 269);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(123, 33);
            buttonExit.TabIndex = 10;
            buttonExit.Text = "На главную";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonSend
            // 
            buttonSend.FlatStyle = FlatStyle.Flat;
            buttonSend.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSend.Location = new Point(311, 269);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(123, 33);
            buttonSend.TabIndex = 9;
            buttonSend.Text = "Отправить";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // textReview
            // 
            textReview.BackColor = Color.FromArgb(239, 239, 239);
            textReview.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textReview.Location = new Point(12, 70);
            textReview.Multiline = true;
            textReview.Name = "textReview";
            textReview.Size = new Size(493, 182);
            textReview.TabIndex = 8;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title.ForeColor = Color.Black;
            title.Location = new Point(167, 22);
            title.Name = "title";
            title.Size = new Size(181, 30);
            title.TabIndex = 7;
            title.Text = "Обратная связь";
            // 
            // ReviewsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 315);
            Controls.Add(plane);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReviewsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reviews";
            plane.ResumeLayout(false);
            plane.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plane;
        private Label title;
        private Button buttonSend;
        private TextBox textReview;
        private Button buttonExit;
    }
}