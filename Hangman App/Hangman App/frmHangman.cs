using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Transactions;

namespace Hangman_App
{
    public partial class frmHangman : Form
    {
        List<String> lstwords = File.ReadAllLines(Path.Combine(Application.StartupPath, "words.txt")).ToList();
        List<Button> lstbuttons = new();
        List<Image> lstimages = new();
        string currentWord = "";
        Random rnd = new();
        int wrongguesses = 0;

        string path = Path.Combine(Application.StartupPath, "Images");
        public frmHangman()
        {
            InitializeComponent();

            lstbuttons = new() {btnA, btnB, btnC, btnD, btnE, btnF,
                                    btnG, btnH, btnI, btnJ, btnK, btnL,
                                    btnM, btnN, btnO, btnP, btnQ, btnR,
                                    btnS, btnT, btnU, btnV, btnW, btnX,
                                    btnY, btnZ
            };

            lstbuttons.ForEach(b => b.Click += SpotButton_Click);

            lstimages = new List<String>()
               {
                    "gallows.png",
                    "head.png",
                    "eyes.png",
                    "glasses.png",
                    "nose.png",
                    "mouth.png",
                    "hair.png",
                    "body.png",
                    "rightarm.png",
                    "leftarm.png",
                    "rightfoot.png",
                    "leftfoot.png"
               }
                .Select(file => Image.FromFile(Path.Combine(path, file))).ToList();

            lblStatus.Text = "Select optional amount before Start, then click Start.";
            DisableLetterButtons(false);
            btnStart.Click += BtnStart_Click;
            cboLetterAmount.SelectedIndex = 0;

        }


        private string GetRandomWord()
        {
            List<string> availableWords = int.TryParse(cboLetterAmount.Text, out int wordLength)
                ? lstwords.Where(word => word.Length == wordLength).ToList()
                : lstwords;

            return availableWords[rnd.Next(availableWords.Count)].ToString().ToLower();
        }

        private void GetLabels()
        {
            tblLabels.Controls.Clear();
            currentWord = GetRandomWord();

            tblLabels.ColumnStyles.Clear();
            tblLabels.RowStyles.Clear();

            tblLabels.ColumnCount = currentWord.Length;
            tblLabels.RowCount = 1;

            tblLabels.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));


            for (int i = 0; i < currentWord.Length; i++)
            {
                tblLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / currentWord.Length));
                Label lbl = new()
                {
                    Text = "___",
                    Font = new Font("Arial", 25, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,

                };
                tblLabels.Controls.Add(lbl);
            }
        }

        private void ProcessGuess(Button clickedbutton)
        {
            string guessedletter = clickedbutton.Text.ToLower();

            bool correct = RevealLetters(guessedletter);

            if (correct)
            {
                HandleCorrectGuess(clickedbutton);
            }
            else
            {
                HandleWrongGuess(clickedbutton);
            }
            clickedbutton.Enabled = false;

            CheckWin();
        }


        private bool RevealLetters(string guessedletter)
        {
            bool found = false;

            for (int i = 0; i < currentWord.Length; i++)
            {
                if (currentWord[i].ToString() == guessedletter)
                {
                    Label lbl = (Label)tblLabels.Controls[i];
                    lbl.Text = guessedletter;
                    found = true;
                }
            }
            return found;
        }

        private void HandleCorrectGuess(Button clickedbutton)
        {
            clickedbutton.BackColor = Color.Yellow;
            lblStatus.Text = "Correct Letter. Go again.";
        }

        private void HandleWrongGuess(Button clickedbutton)
        {
            clickedbutton.BackColor = Color.Black;
            lblStatus.Text = "Incorrect letter. Try again.";

            wrongguesses++;

            UpdateHangman();
        }

        private void UpdateHangman()
        {
            picHangman.Image = lstimages[wrongguesses - 1];
        }

        private void CheckWin()
        {
            if (wrongguesses == lstimages.Count())
            {
                lblStatus.Text = "You lost. The word was " + currentWord + ".";
                DisableLetterButtons(false);
                return;
            }

            foreach (Label lbl in tblLabels.Controls)
            {
                if (lbl.Text == "___")
                {
                    return;
                }
            }
            lblStatus.Text = "You Win!";
            DisableLetterButtons(false);
        }

        private void DisableLetterButtons(bool enabled)
        {
            foreach (Button btn in lstbuttons)
            {
                btn.Enabled = enabled;
            }
        }


        private void SpotButton_Click(object? sender, EventArgs e)
        {
            Button clickedbutton = (Button)sender;
            ProcessGuess(clickedbutton);

        }

        private void StartGame()
        {
            DisableLetterButtons(true);
            wrongguesses = 0;

            picHangman.Image = null;

            lblStatus.Text = "";

            foreach (Button btn in lstbuttons)
            {
                btn.Enabled = true;
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }

            GetLabels();
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartGame();
        }

    }
}
