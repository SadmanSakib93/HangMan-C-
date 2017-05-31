using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace HANGMAN
{
    public partial class MainMenu : Form
    {
        Thread newGameForm;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Close();
            newGameForm = new Thread(openOption);
            newGameForm.SetApartmentState(ApartmentState.STA);
            newGameForm.Start();
        }
        private void openOption()
        {
            Application.Run(new Option());
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            this.Close();
            newGameForm = new Thread(openNewGame);
            newGameForm.SetApartmentState(ApartmentState.STA);
            newGameForm.Start();

        }
        private void openNewGame()
        {
            Application.Run(new HangmanGameForm());
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playButton_MouseHover(object sender, EventArgs e)
        {
            playButton.BackColor = Color.RosyBrown;
            playButton.Cursor=System.Windows.Forms.Cursors.Hand;
            playButton.Size = new Size(136, 35);
            playButton.Location = new System.Drawing.Point(193, 163);
        }

        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            playButton.BackColor = Color.Transparent;
            playButton.Size = new Size(126, 30);
            playButton.Location = new System.Drawing.Point(197, 163);
        }

        private void settingsButton_MouseHover(object sender, EventArgs e)
        {
            settingsButton.BackColor = Color.RosyBrown;
            settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            settingsButton.Size = new Size(136, 35);
            settingsButton.Location = new System.Drawing.Point(193, 228);
        }

        private void settingsButton_MouseLeave(object sender, EventArgs e)
        {
            settingsButton.BackColor = Color.Transparent;
            settingsButton.Size = new Size(126, 30);
            settingsButton.Location = new System.Drawing.Point(197, 228);
        }

        private void quitButton_MouseHover(object sender, EventArgs e)
        {
            quitButton.BackColor = Color.RosyBrown;
            quitButton.Size = new Size(136, 35);
            quitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            quitButton.Location = new System.Drawing.Point(193, 301);
        }

        private void quitButton_MouseLeave(object sender, EventArgs e)
        {
            quitButton.BackColor = Color.Transparent;
            quitButton.Size = new Size(126, 30);
            quitButton.Location = new System.Drawing.Point(197, 301);
        }
    }
}
