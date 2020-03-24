using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Data;

/*
 * Jesse Hauck
 * August 23, 2019
 * A hangman game with an array of words that the user has
 * to guess. The word is selected from the array randomly and
 * displayed as asterisks. When a correct letter is guessed,
 * the asterisks are replaced with the letters.
 */

namespace GuessAWordGUI
{
    public partial class MainFrm : Form
    {
        // a array of words for the user to guess
        string[] theWords = { "passport", "computer", "screen", "soda",
                "lamp", "remote", "battery", "tablet", "pencil", "cord" };
        string theRandWord; // from theWords, selected randomly
        char[] guessWord; // shows the length of the random word
        char[] randWordChars; // holds the random word as an array of chars
        int wordLength; // for the length of the randomly selected word
        int score = 0, totalWords = 0, wrongLetters = 0;

        public MainFrm()
        {
            InitializeComponent();
            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StartBtn_Click(object sender, EventArgs e) 
        {
            int randomNumber; // for randomly selecting a word from the list

            // resetting the wrong letter counter, guesses, the image, and the dead label
            wrongLetters = 0;
            DeadLbl.Visible = false;
            HangManPic.Image = GuessAWordGUI.Properties.Resources.Slide;
            LetterLst.Items.Clear();

            // enabling the buttons for the game
            CheckBtn.Enabled = true;
            GUpBtn.Enabled = true;
            HintBtn.Enabled = true;

            // getting a random number for a random word from the list, finding
            // the length of the word, putting the chars into an array, and
            // making an array of '*' the lenght of the random word
            Random ranNumberGenerator = new Random();
            randomNumber = ranNumberGenerator.Next(0, 9);
            theRandWord = theWords[randomNumber];

            wordLength = theRandWord.Length;

            randWordChars = new char[wordLength];
            guessWord = new char[wordLength];
            
            for (int i = 0; i < wordLength; ++i)
            {
                randWordChars[i] = theRandWord[i];
                guessWord[i] = '*';
            }

            // displaying the *s
            string starword = new string('*', wordLength);
            WordLbl.Text = starword;

            // incrementing the totalWords counter
            ++totalWords;
            TotalTxt.Text = totalWords.ToString("N0");

            // moving attention to the text box and selecting all text
            GuessTxt.Focus();
            GuessTxt.Text = String.Empty;
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            // checks to see if the guess is part of the random word

            string theGuess = GuessTxt.Text;
            string starword = "*";
            bool aMatch = false;
            bool allGuessed = true;

            for (int i = 0; i < wordLength; ++i)
            {
                if (theGuess[0] == theRandWord[i])
                {
                    guessWord[i] = theGuess[0];
                    starword = new string(guessWord);
                    WordLbl.Text = starword;
                    aMatch = true;
                }
            }

            // filling the list box with the letters that have been played
            LetterLst.Items.Add(theGuess[0]);

            // returning focus to the text box
            GuessTxt.Focus();
            GuessTxt.SelectAll();
            
            if (!aMatch)
            {
                ++wrongLetters;
            }

            // displays the hangman for wrong guesses
            Hangem();

            // finding out if the word was guessed before the man hangs
            allGuessed = starword.Contains("*");
            if (wrongLetters < 14 && !allGuessed)
            {
                ++score;
                ScoreTxt.Text = score.ToString("N0");
                HangManPic.Image = GuessAWordGUI.Properties.Resources.Slide_o;
                CheckBtn.Enabled = false;
                GUpBtn.Enabled = false;
                HintBtn.Enabled = false;
            }
            else if (wrongLetters == 14)
            {
                CheckBtn.Enabled = false;
                GUpBtn.Enabled = false;
                HintBtn.Enabled = false;
            }
        }

        private void HintBtn_Click(object sender, EventArgs e)
        {
            // this replaces the first star with the correct letter
            // at the cost of two additions to the wrong letter counter
            
            string starword;

            for (int i = 0; i < wordLength; ++i)
            {
                if (guessWord[i] == '*')
                {
                    guessWord[i] = theRandWord[i];
                    starword = new string(guessWord);
                    WordLbl.Text = starword;
                    wrongLetters += 2;
                    i = wordLength;
                }
            }
            Hangem();
        }

        private void Hangem()
        {
            // displays the hangman for wrong guesses
            switch (wrongLetters)
            {
                case 0:
                    HangManPic.Image = GuessAWordGUI.Properties.Resources.Slide;
                    break;
                case 1:
                    HangManPic.Image = GuessAWordGUI.Properties.Resources.Slide_a;
                    break;
                case 2:
                    HangManPic.Image = GuessAWordGUI.Properties.Resources.Slide_b;
                    break;
                case 3:
                    HangManPic.Image = GuessAWordGUI.Properties.Resources.Slide_c;
                    break;
                case 4:
                    HangManPic.Image = GuessAWordGUI.Properties.Resources.Slide_d;
                    break;
                case 5:
                    HangManPic.Image = GuessAWordGUI.Properties.Resources.Slide_e;
                    break;
                case 6:
                    HangManPic.Image = GuessAWordGUI.Properties.Resources.Slide_f;
                    break;
                case 7:
                    HangManPic.Image = GuessAWordGUI.Properties.Resources.Slide_g;
                    break;
                case 8:
                    HangManPic.Image = GuessAWordGUI.Properties.Resources.Slide_h;
                    break;
                case 9:
                    HangManPic.Image = GuessAWordGUI.Properties.Resources.Slide_i;
                    break;
                case 10:
                    HangManPic.Image = GuessAWordGUI.Properties.Resources.Slide_j;
                    break;
                case 11:
                    HangManPic.Image = GuessAWordGUI.Properties.Resources.Slide_k;
                    break;
                case 12:
                    HangManPic.Image = GuessAWordGUI.Properties.Resources.Slide_l;
                    break;
                case 13:
                    HangManPic.Image = GuessAWordGUI.Properties.Resources.Slide_m;
                    break;
                case 14:
                    HangManPic.Image = GuessAWordGUI.Properties.Resources.Slide_n;
                    DeadLbl.Visible = true;
                    break;
            }
        }

        // the Give Up button
        private void GUpBtn_Click(object sender, EventArgs e)
        {
            WordLbl.Text = theRandWord;
            HangManPic.Image = GuessAWordGUI.Properties.Resources.Slide_n;
            DeadLbl.Visible = true;

            CheckBtn.Enabled = false;
            GUpBtn.Enabled = false;
            HintBtn.Enabled = false;
        }
    }
}
