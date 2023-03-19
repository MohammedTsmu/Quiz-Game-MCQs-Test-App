namespace quizGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.FinishButton = new System.Windows.Forms.Button();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.TotalQuestionsLabel = new System.Windows.Forms.Label();
            this.WrongAnswersLabel = new System.Windows.Forms.Label();
            this.appTitle = new System.Windows.Forms.Label();
            this.ExitFullScreenBtn = new System.Windows.Forms.Button();
            this.FullScreenBtn = new System.Windows.Forms.Button();
            this.currentQuestion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.correctAnswersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(62, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 78);
            this.button1.TabIndex = 1;
            this.button1.Tag = "1";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ClickAnswerEvent);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(500, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(355, 78);
            this.button2.TabIndex = 1;
            this.button2.Tag = "2";
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ClickAnswerEvent);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(62, 657);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(355, 78);
            this.button3.TabIndex = 1;
            this.button3.Tag = "3";
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ClickAnswerEvent);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(500, 657);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(355, 78);
            this.button4.TabIndex = 1;
            this.button4.Tag = "4";
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ClickAnswerEvent);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuestion.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblQuestion.Location = new System.Drawing.Point(62, 479);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(793, 74);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FinishButton
            // 
            this.FinishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.FinishButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FinishButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FinishButton.Location = new System.Drawing.Point(1428, 203);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(138, 75);
            this.FinishButton.TabIndex = 6;
            this.FinishButton.Text = "أنهاء البرنامج";
            this.FinishButton.UseVisualStyleBackColor = false;
            this.FinishButton.Click += new System.EventHandler(this.finishClick);
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PlayAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayAgainButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgainButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PlayAgainButton.Location = new System.Drawing.Point(1428, 122);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(138, 75);
            this.PlayAgainButton.TabIndex = 7;
            this.PlayAgainButton.Text = "أعادة الأختبار";
            this.PlayAgainButton.UseVisualStyleBackColor = false;
            this.PlayAgainButton.Click += new System.EventHandler(this.playAgainClick);
            // 
            // TotalQuestionsLabel
            // 
            this.TotalQuestionsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.TotalQuestionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalQuestionsLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalQuestionsLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TotalQuestionsLabel.Location = new System.Drawing.Point(872, 122);
            this.TotalQuestionsLabel.Name = "TotalQuestionsLabel";
            this.TotalQuestionsLabel.Size = new System.Drawing.Size(282, 75);
            this.TotalQuestionsLabel.TabIndex = 2;
            this.TotalQuestionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WrongAnswersLabel
            // 
            this.WrongAnswersLabel.BackColor = System.Drawing.Color.DarkRed;
            this.WrongAnswersLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WrongAnswersLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongAnswersLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.WrongAnswersLabel.Location = new System.Drawing.Point(872, 302);
            this.WrongAnswersLabel.Name = "WrongAnswersLabel";
            this.WrongAnswersLabel.Size = new System.Drawing.Size(282, 74);
            this.WrongAnswersLabel.TabIndex = 2;
            this.WrongAnswersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // appTitle
            // 
            this.appTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.appTitle.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.appTitle.Location = new System.Drawing.Point(52, 9);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(886, 74);
            this.appTitle.TabIndex = 2;
            this.appTitle.Text = "C# App          Simple Quiz Game";
            this.appTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExitFullScreenBtn
            // 
            this.ExitFullScreenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ExitFullScreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitFullScreenBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitFullScreenBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ExitFullScreenBtn.Location = new System.Drawing.Point(1284, 203);
            this.ExitFullScreenBtn.Name = "ExitFullScreenBtn";
            this.ExitFullScreenBtn.Size = new System.Drawing.Size(138, 75);
            this.ExitFullScreenBtn.TabIndex = 7;
            this.ExitFullScreenBtn.Text = "ألغاء الشاشة المطلقة";
            this.ExitFullScreenBtn.UseVisualStyleBackColor = false;
            this.ExitFullScreenBtn.Click += new System.EventHandler(this.ExitFullScreenClick);
            // 
            // FullScreenBtn
            // 
            this.FullScreenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.FullScreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FullScreenBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullScreenBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FullScreenBtn.Location = new System.Drawing.Point(1284, 122);
            this.FullScreenBtn.Name = "FullScreenBtn";
            this.FullScreenBtn.Size = new System.Drawing.Size(138, 75);
            this.FullScreenBtn.TabIndex = 7;
            this.FullScreenBtn.Text = "الشاشة المطلقة";
            this.FullScreenBtn.UseVisualStyleBackColor = false;
            this.FullScreenBtn.Click += new System.EventHandler(this.FullScreenClick);
            // 
            // currentQuestion
            // 
            this.currentQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.currentQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentQuestion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentQuestion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.currentQuestion.Location = new System.Drawing.Point(320, 740);
            this.currentQuestion.Name = "currentQuestion";
            this.currentQuestion.Size = new System.Drawing.Size(282, 74);
            this.currentQuestion.TabIndex = 2;
            this.currentQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Image = global::quizGame.Properties.Resources.questions;
            this.pictureBox1.Location = new System.Drawing.Point(62, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(793, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // correctAnswersLabel
            // 
            this.correctAnswersLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.correctAnswersLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.correctAnswersLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAnswersLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.correctAnswersLabel.Location = new System.Drawing.Point(872, 212);
            this.correctAnswersLabel.Name = "correctAnswersLabel";
            this.correctAnswersLabel.Size = new System.Drawing.Size(282, 75);
            this.correctAnswersLabel.TabIndex = 2;
            this.correctAnswersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1584, 811);
            this.Controls.Add(this.FullScreenBtn);
            this.Controls.Add(this.ExitFullScreenBtn);
            this.Controls.Add(this.PlayAgainButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.appTitle);
            this.Controls.Add(this.currentQuestion);
            this.Controls.Add(this.WrongAnswersLabel);
            this.Controls.Add(this.correctAnswersLabel);
            this.Controls.Add(this.TotalQuestionsLabel);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Simple Quiz Game v0.0.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button PlayAgainButton;
        private System.Windows.Forms.Label TotalQuestionsLabel;
        private System.Windows.Forms.Label WrongAnswersLabel;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Button ExitFullScreenBtn;
        private System.Windows.Forms.Button FullScreenBtn;
        private System.Windows.Forms.Label currentQuestion;
        private System.Windows.Forms.Label correctAnswersLabel;
    }
}

