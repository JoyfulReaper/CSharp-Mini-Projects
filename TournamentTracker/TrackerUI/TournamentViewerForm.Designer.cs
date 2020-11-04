namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTournament = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.cbRoundDropDown = new System.Windows.Forms.ComboBox();
            this.checkUnplayedOnly = new System.Windows.Forms.CheckBox();
            this.listBoxMatchup = new System.Windows.Forms.ListBox();
            this.lblTeamOneName = new System.Windows.Forms.Label();
            this.lblTeamOneScore = new System.Windows.Forms.Label();
            this.textBoxTeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.lblTeamTwoName = new System.Windows.Forms.Label();
            this.lblTeamTwoScore = new System.Windows.Forms.Label();
            this.textBoxTeamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.lblVersus = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(22, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(214, 50);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tournament:";
            // 
            // lblTournament
            // 
            this.lblTournament.AutoSize = true;
            this.lblTournament.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTournament.Location = new System.Drawing.Point(226, 23);
            this.lblTournament.Name = "lblTournament";
            this.lblTournament.Size = new System.Drawing.Size(150, 50);
            this.lblTournament.TabIndex = 0;
            this.lblTournament.Text = "<none>";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblRound.Location = new System.Drawing.Point(24, 89);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(94, 37);
            this.lblRound.TabIndex = 1;
            this.lblRound.Text = "Round";
            // 
            // cbRoundDropDown
            // 
            this.cbRoundDropDown.FormattingEnabled = true;
            this.cbRoundDropDown.Location = new System.Drawing.Point(124, 88);
            this.cbRoundDropDown.Name = "cbRoundDropDown";
            this.cbRoundDropDown.Size = new System.Drawing.Size(211, 38);
            this.cbRoundDropDown.TabIndex = 2;
            this.cbRoundDropDown.SelectedIndexChanged += new System.EventHandler(this.cbRoundDropDown_SelectedIndexChanged);
            // 
            // checkUnplayedOnly
            // 
            this.checkUnplayedOnly.AutoSize = true;
            this.checkUnplayedOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkUnplayedOnly.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUnplayedOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.checkUnplayedOnly.Location = new System.Drawing.Point(124, 132);
            this.checkUnplayedOnly.Name = "checkUnplayedOnly";
            this.checkUnplayedOnly.Size = new System.Drawing.Size(209, 41);
            this.checkUnplayedOnly.TabIndex = 3;
            this.checkUnplayedOnly.Text = "Unplayed Only";
            this.checkUnplayedOnly.UseVisualStyleBackColor = true;
            this.checkUnplayedOnly.CheckedChanged += new System.EventHandler(this.checkUnplayedOnly_CheckedChanged);
            // 
            // listBoxMatchup
            // 
            this.listBoxMatchup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxMatchup.FormattingEnabled = true;
            this.listBoxMatchup.ItemHeight = 30;
            this.listBoxMatchup.Location = new System.Drawing.Point(31, 180);
            this.listBoxMatchup.Name = "listBoxMatchup";
            this.listBoxMatchup.Size = new System.Drawing.Size(302, 302);
            this.listBoxMatchup.TabIndex = 4;
            this.listBoxMatchup.SelectedIndexChanged += new System.EventHandler(this.listBoxMatchup_SelectedIndexChanged);
            // 
            // lblTeamOneName
            // 
            this.lblTeamOneName.AutoSize = true;
            this.lblTeamOneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamOneName.Location = new System.Drawing.Point(374, 180);
            this.lblTeamOneName.Name = "lblTeamOneName";
            this.lblTeamOneName.Size = new System.Drawing.Size(165, 37);
            this.lblTeamOneName.TabIndex = 1;
            this.lblTeamOneName.Text = "<team one>";
            // 
            // lblTeamOneScore
            // 
            this.lblTeamOneScore.AutoSize = true;
            this.lblTeamOneScore.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamOneScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamOneScore.Location = new System.Drawing.Point(374, 236);
            this.lblTeamOneScore.Name = "lblTeamOneScore";
            this.lblTeamOneScore.Size = new System.Drawing.Size(82, 37);
            this.lblTeamOneScore.TabIndex = 1;
            this.lblTeamOneScore.Text = "Score";
            // 
            // textBoxTeamOneScoreValue
            // 
            this.textBoxTeamOneScoreValue.Location = new System.Drawing.Point(462, 238);
            this.textBoxTeamOneScoreValue.Name = "textBoxTeamOneScoreValue";
            this.textBoxTeamOneScoreValue.Size = new System.Drawing.Size(100, 35);
            this.textBoxTeamOneScoreValue.TabIndex = 5;
            // 
            // lblTeamTwoName
            // 
            this.lblTeamTwoName.AutoSize = true;
            this.lblTeamTwoName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamTwoName.Location = new System.Drawing.Point(374, 355);
            this.lblTeamTwoName.Name = "lblTeamTwoName";
            this.lblTeamTwoName.Size = new System.Drawing.Size(165, 37);
            this.lblTeamTwoName.TabIndex = 1;
            this.lblTeamTwoName.Text = "<team two>";
            // 
            // lblTeamTwoScore
            // 
            this.lblTeamTwoScore.AutoSize = true;
            this.lblTeamTwoScore.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamTwoScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamTwoScore.Location = new System.Drawing.Point(374, 411);
            this.lblTeamTwoScore.Name = "lblTeamTwoScore";
            this.lblTeamTwoScore.Size = new System.Drawing.Size(82, 37);
            this.lblTeamTwoScore.TabIndex = 1;
            this.lblTeamTwoScore.Text = "Score";
            // 
            // textBoxTeamTwoScoreValue
            // 
            this.textBoxTeamTwoScoreValue.Location = new System.Drawing.Point(462, 413);
            this.textBoxTeamTwoScoreValue.Name = "textBoxTeamTwoScoreValue";
            this.textBoxTeamTwoScoreValue.Size = new System.Drawing.Size(100, 35);
            this.textBoxTeamTwoScoreValue.TabIndex = 5;
            // 
            // lblVersus
            // 
            this.lblVersus.AutoSize = true;
            this.lblVersus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblVersus.Location = new System.Drawing.Point(443, 301);
            this.lblVersus.Name = "lblVersus";
            this.lblVersus.Size = new System.Drawing.Size(70, 37);
            this.lblVersus.TabIndex = 1;
            this.lblVersus.Text = "-VS-";
            // 
            // btnScore
            // 
            this.btnScore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnScore.Location = new System.Drawing.Point(586, 291);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(124, 63);
            this.btnScore.TabIndex = 6;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 506);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.textBoxTeamTwoScoreValue);
            this.Controls.Add(this.textBoxTeamOneScoreValue);
            this.Controls.Add(this.listBoxMatchup);
            this.Controls.Add(this.checkUnplayedOnly);
            this.Controls.Add(this.cbRoundDropDown);
            this.Controls.Add(this.lblTeamTwoScore);
            this.Controls.Add(this.lblTeamOneScore);
            this.Controls.Add(this.lblVersus);
            this.Controls.Add(this.lblTeamTwoName);
            this.Controls.Add(this.lblTeamOneName);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblTournament);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTournament;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.ComboBox cbRoundDropDown;
        private System.Windows.Forms.CheckBox checkUnplayedOnly;
        private System.Windows.Forms.ListBox listBoxMatchup;
        private System.Windows.Forms.Label lblTeamOneName;
        private System.Windows.Forms.Label lblTeamOneScore;
        private System.Windows.Forms.TextBox textBoxTeamOneScoreValue;
        private System.Windows.Forms.Label lblTeamTwoName;
        private System.Windows.Forms.Label lblTeamTwoScore;
        private System.Windows.Forms.TextBox textBoxTeamTwoScoreValue;
        private System.Windows.Forms.Label lblVersus;
        private System.Windows.Forms.Button btnScore;
    }
}

