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

            lblStatus.Text = "Click start to begin game.";
            DisableLetterButtons(false);
            btnStart.Click += BtnStart_Click;
            txtLetterAmount.KeyPress += TxtLetterAmount_KeyPress;
            txtLetterAmount.TextChanged += TxtLetterAmount_TextChanged;

        }


        private string GetRandomWord(int? requestedLength = null)
        {
            List<string> availableWords = requestedLength.HasValue
                ? lstwords.Where(word => word.Length == requestedLength.Value).ToList()
                : lstwords;

            return availableWords[rnd.Next(availableWords.Count)].ToString().ToLower();
        }

        private void GetLabels(int? requestedLength = null)
        {
            tblLabels.Controls.Clear();
            currentWord = GetRandomWord(requestedLength);

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
            if (!TryGetRequestedLetterAmount(out int? requestedLength))
            {
                return;
            }

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

            GetLabels(requestedLength);
        }

        private bool TryGetRequestedLetterAmount(out int? requestedLength)
        {
            requestedLength = null;
            string amountText = txtLetterAmount.Text.Trim();

            if (string.IsNullOrEmpty(amountText))
            {
                return true;
            }

            if (!int.TryParse(amountText, out int amount) || amount < 1 || amount > 10)
            {
                lblStatus.Text = "Enter a number from 1 to 10, or leave it blank.";
                DisableLetterButtons(false);
                return false;
            }

            requestedLength = amount;
            return true;
        }

        private void TxtLetterAmount_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lblStatus.Text = "Only numbers from 1 to 10 are allowed.";
            }
        }

        private void TxtLetterAmount_TextChanged(object? sender, EventArgs e)
        {
            string digitsOnly = new(txtLetterAmount.Text.Where(char.IsDigit).ToArray());

            if (txtLetterAmount.Text != digitsOnly)
            {
                txtLetterAmount.Text = digitsOnly;
                txtLetterAmount.SelectionStart = txtLetterAmount.Text.Length;
                lblStatus.Text = "Only numbers from 1 to 10 are allowed.";
                return;
            }

            if (int.TryParse(txtLetterAmount.Text, out int amount) && (amount < 1 || amount > 10))
            {
                txtLetterAmount.Clear();
                lblStatus.Text = "Only numbers from 1 to 10 are allowed.";
            }
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartGame();
        }

    }
}
