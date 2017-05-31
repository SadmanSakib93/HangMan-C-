namespace HANGMAN
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.playButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(197, 163);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(126, 30);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseLeave += new System.EventHandler(this.playButton_MouseLeave);
            this.playButton.MouseHover += new System.EventHandler(this.playButton_MouseHover);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(197, 301);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(126, 30);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            this.quitButton.MouseLeave += new System.EventHandler(this.quitButton_MouseLeave);
            this.quitButton.MouseHover += new System.EventHandler(this.quitButton_MouseHover);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(197, 228);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(126, 36);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.Text = "OPTION";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            this.settingsButton.MouseLeave += new System.EventHandler(this.settingsButton_MouseLeave);
            this.settingsButton.MouseHover += new System.EventHandler(this.settingsButton_MouseHover);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.playButton);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button settingsButton;
    }
}