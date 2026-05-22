using System;
using System.Drawing;
namespace PasswordStrengthCheckerGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            int score = 0;

            bool hasUpper = false;
            bool hasNumber = false;
            bool hasSymbol = false;

            lblSuggestions.Text = "";


            // Length Check
            if (password.Length >= 8)
            {
                score++;
            }
            else
            {
                lblSuggestions.Text += "• Add more characters\n";
            }


            // Character Checks
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }

                if (char.IsDigit(c))
                {
                    hasNumber = true;
                }

                if (!char.IsLetterOrDigit(c))
                {
                    hasSymbol = true;
                }
            }


            // Score Increase
            if (hasUpper)
            {
                score++;
            }
            else
            {
                lblSuggestions.Text += "• Add uppercase letters\n";
            }

            if (hasNumber)
            {
                score++;
            }
            else
            {
                lblSuggestions.Text += "• Add numbers\n";
            }

            if (hasSymbol)
            {
                score++;
            }
            else
            {
                lblSuggestions.Text += "• Add symbols\n";
            }

            progressBar1.Value = score * 25;
            // Result
            if (score <= 1)
            {
                lblResult.Text = "WEAK";
                lblResult.ForeColor = Color.Red;
            }
            else if (score <= 3)
            {
                lblResult.Text = "MEDIUM";
                lblResult.ForeColor = Color.Orange;
            }
            else
            {
                lblResult.Text = "STRONG";
                lblResult.ForeColor = Color.Green;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
