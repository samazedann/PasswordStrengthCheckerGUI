namespace PasswordStrengthCheckerGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblResult = new Label();
            lblSuggestions = new Label();
            txtPassword = new TextBox();
            btnCheck = new Button();
            progressBar1 = new ProgressBar();
            chkShow = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(63, 48);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Password";
            label1.Click += label1_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.GhostWhite;
            lblResult.Location = new Point(231, 229);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(59, 19);
            lblResult.TabIndex = 1;
            lblResult.Text = "Result";
            // 
            // lblSuggestions
            // 
            lblSuggestions.AutoSize = true;
            lblSuggestions.Font = new Font("MV Boli", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSuggestions.ForeColor = Color.Black;
            lblSuggestions.Location = new Point(455, 294);
            lblSuggestions.Name = "lblSuggestions";
            lblSuggestions.Size = new Size(98, 20);
            lblSuggestions.TabIndex = 2;
            lblSuggestions.Text = "Suggestions";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.Location = new Point(63, 81);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(195, 26);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.LightPink;
            btnCheck.ForeColor = Color.White;
            btnCheck.Location = new Point(159, 141);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(170, 27);
            btnCheck.TabIndex = 4;
            btnCheck.Text = "Check Strength";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(252, 174);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(125, 29);
            progressBar1.TabIndex = 5;
            progressBar1.Click += progressBar1_Click;
            // 
            // chkShow
            // 
            chkShow.AutoSize = true;
            chkShow.Location = new Point(29, 113);
            chkShow.Name = "chkShow";
            chkShow.Size = new Size(161, 22);
            chkShow.TabIndex = 6;
            chkShow.Text = "Show Password";
            chkShow.UseVisualStyleBackColor = true;
            chkShow.CheckedChanged += chkShow_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(1000, 405);
            Controls.Add(chkShow);
            Controls.Add(progressBar1);
            Controls.Add(btnCheck);
            Controls.Add(txtPassword);
            Controls.Add(lblSuggestions);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Strength Checker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResult;
        private Label lblSuggestions;
        private TextBox txtPassword;
        private Button btnCheck;
        private ProgressBar progressBar1;
        private CheckBox chkShow;
    }
}
