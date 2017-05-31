using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace HANGMAN
{
    public partial class HangmanGameForm : Form
    {
        Bitmap[] hangManImages = { HANGMAN.Properties.Resources._1,HANGMAN.Properties.Resources._2, HANGMAN.Properties.Resources._3,
                                     HANGMAN.Properties.Resources._4,HANGMAN.Properties.Resources._5,HANGMAN.Properties.Resources._6,
                                     HANGMAN.Properties.Resources._7 };
        char[] word;
        String[] wordList;
        string wordMain;
        int guess = 0;
        List<Label> labels = new List<Label>();
        bool letterTextBoxClickedOnce, wordTextBoxClickedOnce;
        Thread mainMenuForm;

        public HangmanGameForm()
        {
            InitializeComponent();
            letterTextBoxClickedOnce =wordTextBoxClickedOnce= false;
            loadWord();

        }

        public void loadWord()
        {
            if(Option.wordType == 0)
                wordList = File.ReadAllLines("WordList.txt");
            if (Option.wordType == 1)
                wordList = File.ReadAllLines("Country.txt");
            if (Option.wordType == 2)
                wordList = File.ReadAllLines("Food.txt");
            if (Option.wordType == 3)
                wordList = File.ReadAllLines("Sports.txt");
            if (Option.wordType == 4)
                wordList = File.ReadAllLines("Animal.txt");
            if (Option.wordType == 5)
                wordList = File.ReadAllLines("Fish.txt");
            Random randomNum = new Random();
            int rnd = randomNum.Next(0, wordList.Length-1);
            wordShowGroupBox.Text = wordList[rnd];
            wordMain = wordList[rnd];
            //submitLetterTextBox.Text = Convert.ToString(rnd);

            
            word = wordList[rnd].ToCharArray();
            int distanceBetweenLabeles = 355 / word.Length;
            for (int i = 0; i < word.Length; i++)
            {
                labels.Add(new Label());
                labels[i].Location = new Point(i * distanceBetweenLabeles +5, 70);
                labels[i].Text = "_";
                labels[i].Parent = wordShowGroupBox;
                labels[i].BringToFront();
                //labels[i].CreateControl();

            }   
        }

        public void changeImage()
        {
            if (guess < 6)
            {
                guess++;

                hangManImage.Image = hangManImages[guess];
            }
            else
            {

                MessageBox.Show("Sorry , Game Over . The word was " + wordMain, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
              //  restGame();
                this.Close();
                mainMenuForm = new Thread(openNewGame);
                mainMenuForm.SetApartmentState(ApartmentState.STA);
                mainMenuForm.Start(); 
            }
        }
        private void openNewGame()
        {
            Application.Run(new GameOver());
        }
            

        

        public void restGame()
        {
            guess = 0;
            hangManImage.Image = HANGMAN.Properties.Resources._1;
            submitLetterTextBox.Text = "";
            submitWordTextBox.Text = "";
            missedLetters.Text = "Missed Letters:";
            loadWord();
        }


        private void submitWordButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(submitLetterTextBox.Text))
            {
                if (submitWordTextBox.Text == wordMain)
                {
                    MessageBox.Show("You Won ! ", "Congratulation !!! ", MessageBoxButtons.OK);
                    restGame();
                }
                else
                {
                    if (guess != 6)
                        MessageBox.Show("Wrong Guess ! ", "Sorry", MessageBoxButtons.OK);
                    changeImage();
                }
            }
        }

        private void submitLetterButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(submitLetterTextBox.Text))
            {
                char letter = submitLetterTextBox.Text.ToLower().ToCharArray()[0];

                if (!char.IsLetter(letter))
                {
                    MessageBox.Show("Only a letter is accepted ! ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (word.Contains(letter))
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == letter)
                            labels[i].Text = letter.ToString();

                    }

                }


                else
                {
                    if (guess != 6)
                        MessageBox.Show("Wrong Guess ! ", "Sorry", MessageBoxButtons.OK);
                    missedLetters.Text = missedLetters.Text + " " + letter.ToString() + " ,";
                    changeImage();
                }

                foreach (Label l in labels)
                    if (l.Text == "_") return;
                MessageBox.Show("You Won ! ", "Congratulation !!! ", MessageBoxButtons.OK);
                restGame();
            }
        }

        private void submitLetterButton_MouseHover(object sender, EventArgs e)
        {
            submitLetterButton.BackColor = Color.LightSteelBlue;
            submitLetterButton.Size = new Size(151, 34);
            
           
        }

        private void submitLetterButton_MouseLeave(object sender, EventArgs e)
        {
            submitLetterButton.BackColor = Color.Transparent;
            submitLetterButton.Size = new Size(146, 30);
        }

        private void submitWordButton_MouseHover(object sender, EventArgs e)
        {
            submitWordButton.BackColor = Color.LightSteelBlue;
            submitWordButton.Size = new Size(151, 34);
        }

        private void submitWordButton_MouseLeave(object sender, EventArgs e)
        {
            submitWordButton.BackColor = Color.Transparent;
            submitWordButton.Size = new Size(146, 30);
        }

        private void submitLetterTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!letterTextBoxClickedOnce)
            {
                submitLetterTextBox.Text = "";
                letterTextBoxClickedOnce = true;
            }
        }

        private void submitWordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!wordTextBoxClickedOnce)
            {
                submitWordTextBox.Text = "";
                wordTextBoxClickedOnce = true;
            }
        }




    }
}
