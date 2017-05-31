namespace HANGMAN
{
    partial class HangmanGameForm
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
            this.wordShowGroupBox = new System.Windows.Forms.GroupBox();
            this.missedLetters = new System.Windows.Forms.Label();
            this.guessSubmitGroupBox = new System.Windows.Forms.GroupBox();
            this.submitWordTextBox = new System.Windows.Forms.TextBox();
            this.submitLetterTextBox = new System.Windows.Forms.TextBox();
            this.submitWordButton = new System.Windows.Forms.Button();
            this.submitLetterButton = new System.Windows.Forms.Button();
            this.hangManImage = new System.Windows.Forms.PictureBox();
            this.hangmanAnim = new System.Windows.Forms.Label();
            this.wordShowGroupBox.SuspendLayout();
            this.guessSubmitGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangManImage)).BeginInit();
            this.SuspendLayout();
            // 
            // wordShowGroupBox
            // 
            this.wordShowGroupBox.Controls.Add(this.missedLetters);
            this.wordShowGroupBox.Location = new System.Drawing.Point(12, 30);
            this.wordShowGroupBox.Name = "wordShowGroupBox";
            this.wordShowGroupBox.Size = new System.Drawing.Size(355, 127);
            this.wordShowGroupBox.TabIndex = 1;
            this.wordShowGroupBox.TabStop = false;
            this.wordShowGroupBox.Text = "WordShow;";
            // 
            // missedLetters
            // 
            this.missedLetters.AutoSize = true;
            this.missedLetters.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missedLetters.Location = new System.Drawing.Point(7, 108);
            this.missedLetters.Name = "missedLetters";
            this.missedLetters.Size = new System.Drawing.Size(110, 12);
            this.missedLetters.TabIndex = 0;
            this.missedLetters.Text = "Missed Letters:";
            // 
            // guessSubmitGroupBox
            // 
            this.guessSubmitGroupBox.Controls.Add(this.submitWordTextBox);
            this.guessSubmitGroupBox.Controls.Add(this.submitLetterTextBox);
            this.guessSubmitGroupBox.Controls.Add(this.submitWordButton);
            this.guessSubmitGroupBox.Controls.Add(this.submitLetterButton);
            this.guessSubmitGroupBox.Location = new System.Drawing.Point(12, 195);
            this.guessSubmitGroupBox.Name = "guessSubmitGroupBox";
            this.guessSubmitGroupBox.Size = new System.Drawing.Size(355, 135);
            this.guessSubmitGroupBox.TabIndex = 2;
            this.guessSubmitGroupBox.TabStop = false;
            // 
            // submitWordTextBox
            // 
            this.submitWordTextBox.Font = new System.Drawing.Font("Hobo Std", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitWordTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.submitWordTextBox.Location = new System.Drawing.Point(18, 84);
            this.submitWordTextBox.Name = "submitWordTextBox";
            this.submitWordTextBox.Size = new System.Drawing.Size(153, 22);
            this.submitWordTextBox.TabIndex = 3;
            this.submitWordTextBox.Text = "Guess word";
            this.submitWordTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.submitWordTextBox_MouseClick);
            // 
            // submitLetterTextBox
            // 
            this.submitLetterTextBox.Font = new System.Drawing.Font("Hobo Std", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitLetterTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.submitLetterTextBox.Location = new System.Drawing.Point(18, 22);
            this.submitLetterTextBox.MaxLength = 1;
            this.submitLetterTextBox.Name = "submitLetterTextBox";
            this.submitLetterTextBox.Size = new System.Drawing.Size(153, 22);
            this.submitLetterTextBox.TabIndex = 2;
            this.submitLetterTextBox.Text = "Guess a letter";
            this.submitLetterTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.submitLetterTextBox_MouseClick);
            // 
            // submitWordButton
            // 
            this.submitWordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitWordButton.Font = new System.Drawing.Font("OCR A Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitWordButton.Location = new System.Drawing.Point(203, 76);
            this.submitWordButton.Name = "submitWordButton";
            this.submitWordButton.Size = new System.Drawing.Size(146, 30);
            this.submitWordButton.TabIndex = 1;
            this.submitWordButton.Text = "Submit Word";
            this.submitWordButton.UseVisualStyleBackColor = true;
            this.submitWordButton.Click += new System.EventHandler(this.submitWordButton_Click);
            this.submitWordButton.MouseLeave += new System.EventHandler(this.submitWordButton_MouseLeave);
            this.submitWordButton.MouseHover += new System.EventHandler(this.submitWordButton_MouseHover);
            // 
            // submitLetterButton
            // 
            this.submitLetterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitLetterButton.Font = new System.Drawing.Font("OCR A Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitLetterButton.Location = new System.Drawing.Point(203, 19);
            this.submitLetterButton.Name = "submitLetterButton";
            this.submitLetterButton.Size = new System.Drawing.Size(146, 30);
            this.submitLetterButton.TabIndex = 0;
            this.submitLetterButton.Text = "Submit Letter";
            this.submitLetterButton.UseVisualStyleBackColor = true;
            this.submitLetterButton.Click += new System.EventHandler(this.submitLetterButton_Click);
            this.submitLetterButton.MouseLeave += new System.EventHandler(this.submitLetterButton_MouseLeave);
            this.submitLetterButton.MouseHover += new System.EventHandler(this.submitLetterButton_MouseHover);
            // 
            // hangManImage
            // 
            this.hangManImage.Image = global::HANGMAN.Properties.Resources._1;
            this.hangManImage.Location = new System.Drawing.Point(380, 30);
            this.hangManImage.Name = "hangManImage";
            this.hangManImage.Size = new System.Drawing.Size(200, 300);
            this.hangManImage.TabIndex = 3;
            this.hangManImage.TabStop = false;
            // 
            // hangmanAnim
            // 
            this.hangmanAnim.AutoSize = true;
            this.hangmanAnim.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hangmanAnim.Location = new System.Drawing.Point(122, 162);
            this.hangmanAnim.Name = "hangmanAnim";
            this.hangmanAnim.Size = new System.Drawing.Size(149, 30);
            this.hangmanAnim.TabIndex = 4;
            this.hangmanAnim.Text = "HANGMAN";
            // 
            // HangmanGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.hangmanAnim);
            this.Controls.Add(this.hangManImage);
            this.Controls.Add(this.guessSubmitGroupBox);
            this.Controls.Add(this.wordShowGroupBox);
            this.MaximizeBox = false;
            this.Name = "HangmanGameForm";
            this.Text = "HANGMAN";
            this.wordShowGroupBox.ResumeLayout(false);
            this.wordShowGroupBox.PerformLayout();
            this.guessSubmitGroupBox.ResumeLayout(false);
            this.guessSubmitGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangManImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox wordShowGroupBox;
        private System.Windows.Forms.GroupBox guessSubmitGroupBox;
        private System.Windows.Forms.PictureBox hangManImage;
        private System.Windows.Forms.TextBox submitWordTextBox;
        private System.Windows.Forms.TextBox submitLetterTextBox;
        private System.Windows.Forms.Button submitWordButton;
        private System.Windows.Forms.Button submitLetterButton;
        private System.Windows.Forms.Label missedLetters;
        private System.Windows.Forms.Label hangmanAnim;
    }
}

