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
    public partial class GameOver : Form
    {
        Thread newGameForm;
        public GameOver()
        {
            InitializeComponent();
        }

        private void GameOver_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
                newGameForm = new Thread(openNewGame);
                newGameForm.SetApartmentState(ApartmentState.STA);
                newGameForm.Start();
            }

        }
        private void openNewGame()
        {
            Application.Run(new MainMenu());
        }


        
    }
}
