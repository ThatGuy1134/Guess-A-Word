namespace GuessAWordGUI
{
    partial class MainFrm
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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.GuessTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WordLbl = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.GUpBtn = new System.Windows.Forms.Button();
            this.HintBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ScoreTxt = new System.Windows.Forms.TextBox();
            this.TotalTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeadLbl = new System.Windows.Forms.Label();
            this.HangManPic = new System.Windows.Forms.PictureBox();
            this.LetterLst = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.HangManPic)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(309, 321);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(100, 32);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CheckBtn
            // 
            this.CheckBtn.Enabled = false;
            this.CheckBtn.Location = new System.Drawing.Point(125, 79);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(100, 32);
            this.CheckBtn.TabIndex = 2;
            this.CheckBtn.Text = "&Check";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // GuessTxt
            // 
            this.GuessTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.GuessTxt.Location = new System.Drawing.Point(125, 48);
            this.GuessTxt.MaxLength = 1;
            this.GuessTxt.Name = "GuessTxt";
            this.GuessTxt.Size = new System.Drawing.Size(100, 25);
            this.GuessTxt.TabIndex = 1;
            this.GuessTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Guess the word:";
            // 
            // WordLbl
            // 
            this.WordLbl.AutoSize = true;
            this.WordLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordLbl.Location = new System.Drawing.Point(122, 22);
            this.WordLbl.Name = "WordLbl";
            this.WordLbl.Size = new System.Drawing.Size(0, 21);
            this.WordLbl.TabIndex = 4;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(273, 21);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(100, 32);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "&Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // GUpBtn
            // 
            this.GUpBtn.Enabled = false;
            this.GUpBtn.Location = new System.Drawing.Point(273, 131);
            this.GUpBtn.Name = "GUpBtn";
            this.GUpBtn.Size = new System.Drawing.Size(100, 32);
            this.GUpBtn.TabIndex = 3;
            this.GUpBtn.Text = "&Give Up";
            this.GUpBtn.UseVisualStyleBackColor = true;
            this.GUpBtn.Click += new System.EventHandler(this.GUpBtn_Click);
            // 
            // HintBtn
            // 
            this.HintBtn.Enabled = false;
            this.HintBtn.Location = new System.Drawing.Point(273, 93);
            this.HintBtn.Name = "HintBtn";
            this.HintBtn.Size = new System.Drawing.Size(100, 32);
            this.HintBtn.TabIndex = 4;
            this.HintBtn.Text = "&Hint";
            this.HintBtn.UseVisualStyleBackColor = true;
            this.HintBtn.Click += new System.EventHandler(this.HintBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Score:";
            // 
            // ScoreTxt
            // 
            this.ScoreTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScoreTxt.Location = new System.Drawing.Point(266, 231);
            this.ScoreTxt.Name = "ScoreTxt";
            this.ScoreTxt.Size = new System.Drawing.Size(44, 25);
            this.ScoreTxt.TabIndex = 2;
            this.ScoreTxt.TabStop = false;
            this.ScoreTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalTxt
            // 
            this.TotalTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalTxt.Location = new System.Drawing.Point(335, 231);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.Size = new System.Drawing.Size(44, 25);
            this.TotalTxt.TabIndex = 2;
            this.TotalTxt.TabStop = false;
            this.TotalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Correct";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Out of";
            // 
            // DeadLbl
            // 
            this.DeadLbl.AutoSize = true;
            this.DeadLbl.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeadLbl.ForeColor = System.Drawing.Color.Red;
            this.DeadLbl.Location = new System.Drawing.Point(254, 181);
            this.DeadLbl.Name = "DeadLbl";
            this.DeadLbl.Size = new System.Drawing.Size(155, 20);
            this.DeadLbl.TabIndex = 10;
            this.DeadLbl.Text = "Sorry, you died!";
            this.DeadLbl.Visible = false;
            // 
            // HangManPic
            // 
            this.HangManPic.Image = global::GuessAWordGUI.Properties.Resources.Slide;
            this.HangManPic.Location = new System.Drawing.Point(16, 131);
            this.HangManPic.Name = "HangManPic";
            this.HangManPic.Size = new System.Drawing.Size(224, 222);
            this.HangManPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HangManPic.TabIndex = 5;
            this.HangManPic.TabStop = false;
            // 
            // LetterLst
            // 
            this.LetterLst.FormattingEnabled = true;
            this.LetterLst.ItemHeight = 17;
            this.LetterLst.Location = new System.Drawing.Point(17, 48);
            this.LetterLst.Name = "LetterLst";
            this.LetterLst.Size = new System.Drawing.Size(102, 72);
            this.LetterLst.TabIndex = 11;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(421, 365);
            this.Controls.Add(this.LetterLst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeadLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HintBtn);
            this.Controls.Add(this.GUpBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.HangManPic);
            this.Controls.Add(this.WordLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalTxt);
            this.Controls.Add(this.ScoreTxt);
            this.Controls.Add(this.GuessTxt);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.ExitBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.HangManPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.TextBox GuessTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WordLbl;
        private System.Windows.Forms.PictureBox HangManPic;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button GUpBtn;
        private System.Windows.Forms.Button HintBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ScoreTxt;
        private System.Windows.Forms.TextBox TotalTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DeadLbl;
        private System.Windows.Forms.ListBox LetterLst;
    }
}

