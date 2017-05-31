using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HANGMAN
{
    public partial class Option : Form
    {
        public static int wordType;
        Thread newGameForm;
        public Option()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.Close();
            newGameForm = new Thread(openNewGame);
            newGameForm.SetApartmentState(ApartmentState.STA);
            newGameForm.Start();
        }
        private void openNewGame()
        {
            Application.Run(new MainMenu());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                wordType = 1; //Country
            if (comboBox1.SelectedIndex == 01)
                wordType = 02; //Food
            if (comboBox1.SelectedIndex == 02)
                wordType = 03; //Sports
            if (comboBox1.SelectedIndex == 03)
                wordType = 04; //Animal
            if (comboBox1.SelectedIndex == 04)
                wordType = 05; //Fish
            if (comboBox1.SelectedIndex == 05)
                wordType = 0; //All

        }
    }
}
