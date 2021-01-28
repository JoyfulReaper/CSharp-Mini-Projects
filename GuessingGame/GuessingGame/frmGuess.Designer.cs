
namespace GuessingGame
{
    partial class frmGuess
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
            this.btnGuess = new System.Windows.Forms.Button();
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.textBoxMaxGuess = new System.Windows.Forms.TextBox();
            this.lblMaxGuesses = new System.Windows.Forms.Label();
            this.lblHighestNumber = new System.Windows.Forms.Label();
            this.textBoxMaxNumber = new System.Windows.Forms.TextBox();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnGuess
            // 
            this.btnGuess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuess.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuess.ForeColor = System.Drawing.Color.Blue;
            this.btnGuess.Location = new System.Drawing.Point(129, 143);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(100, 35);
            this.btnGuess.TabIndex = 0;
            this.btnGuess.Text = "Guess!";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.Location = new System.Drawing.Point(129, 112);
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(100, 25);
            this.textBoxGuess.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.Blue;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(149, 25);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Guessing Game";
            // 
            // textBoxMaxGuess
            // 
            this.textBoxMaxGuess.Location = new System.Drawing.Point(12, 37);
            this.textBoxMaxGuess.Name = "textBoxMaxGuess";
            this.textBoxMaxGuess.Size = new System.Drawing.Size(69, 25);
            this.textBoxMaxGuess.TabIndex = 3;
            this.textBoxMaxGuess.Text = "10";
            // 
            // lblMaxGuesses
            // 
            this.lblMaxGuesses.AutoSize = true;
            this.lblMaxGuesses.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaxGuesses.ForeColor = System.Drawing.Color.Blue;
            this.lblMaxGuesses.Location = new System.Drawing.Point(87, 37);
            this.lblMaxGuesses.Name = "lblMaxGuesses";
            this.lblMaxGuesses.Size = new System.Drawing.Size(190, 21);
            this.lblMaxGuesses.TabIndex = 4;
            this.lblMaxGuesses.Text = "Max Number Of Guesses";
            // 
            // lblHighestNumber
            // 
            this.lblHighestNumber.AutoSize = true;
            this.lblHighestNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHighestNumber.ForeColor = System.Drawing.Color.Blue;
            this.lblHighestNumber.Location = new System.Drawing.Point(87, 73);
            this.lblHighestNumber.Name = "lblHighestNumber";
            this.lblHighestNumber.Size = new System.Drawing.Size(194, 21);
            this.lblHighestNumber.TabIndex = 6;
            this.lblHighestNumber.Text = "Highest Possible Number";
            // 
            // textBoxMaxNumber
            // 
            this.textBoxMaxNumber.Location = new System.Drawing.Point(12, 73);
            this.textBoxMaxNumber.Name = "textBoxMaxNumber";
            this.textBoxMaxNumber.Size = new System.Drawing.Size(69, 25);
            this.textBoxMaxNumber.TabIndex = 5;
            this.textBoxMaxNumber.Text = "100";
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.Location = new System.Drawing.Point(12, 187);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(153, 17);
            this.linkLabelGitHub.TabIndex = 7;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "github.com/JoyfulReaper";
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // frmGuess
            // 
            this.AcceptButton = this.btnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(376, 213);
            this.Controls.Add(this.linkLabelGitHub);
            this.Controls.Add(this.lblHighestNumber);
            this.Controls.Add(this.textBoxMaxNumber);
            this.Controls.Add(this.lblMaxGuesses);
            this.Controls.Add(this.textBoxMaxGuess);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.textBoxGuess);
            this.Controls.Add(this.btnGuess);
            this.Name = "frmGuess";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox textBoxMaxGuess;
        private System.Windows.Forms.Label lblMaxGuesses;
        private System.Windows.Forms.Label lblHighestNumber;
        private System.Windows.Forms.TextBox textBoxMaxNumber;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
    }
}

