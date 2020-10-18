namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.lblHeader = new System.Windows.Forms.Label();
            this.textBoxTournamentName = new System.Windows.Forms.TextBox();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.textBoxEntryFee = new System.Windows.Forms.TextBox();
            this.lblEntryFee = new System.Windows.Forms.Label();
            this.cbSelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.linkNewTeam = new System.Windows.Forms.LinkLabel();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.listBoxTournamentTeams = new System.Windows.Forms.ListBox();
            this.lblTournamentPlayers = new System.Windows.Forms.Label();
            this.btnRemoveTeam = new System.Windows.Forms.Button();
            this.btnRemovePrize = new System.Windows.Forms.Button();
            this.listBoxPrizes = new System.Windows.Forms.ListBox();
            this.lblPrizes = new System.Windows.Forms.Label();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(317, 50);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Create Tournament";
            // 
            // textBoxTournamentName
            // 
            this.textBoxTournamentName.Location = new System.Drawing.Point(31, 110);
            this.textBoxTournamentName.Name = "textBoxTournamentName";
            this.textBoxTournamentName.Size = new System.Drawing.Size(298, 35);
            this.textBoxTournamentName.TabIndex = 7;
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTournamentName.Location = new System.Drawing.Point(24, 70);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(236, 37);
            this.lblTournamentName.TabIndex = 6;
            this.lblTournamentName.Text = "Tournament Name";
            // 
            // textBoxEntryFee
            // 
            this.textBoxEntryFee.Location = new System.Drawing.Point(160, 172);
            this.textBoxEntryFee.Name = "textBoxEntryFee";
            this.textBoxEntryFee.Size = new System.Drawing.Size(100, 35);
            this.textBoxEntryFee.TabIndex = 9;
            this.textBoxEntryFee.Text = "0";
            // 
            // lblEntryFee
            // 
            this.lblEntryFee.AutoSize = true;
            this.lblEntryFee.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblEntryFee.Location = new System.Drawing.Point(29, 170);
            this.lblEntryFee.Name = "lblEntryFee";
            this.lblEntryFee.Size = new System.Drawing.Size(125, 37);
            this.lblEntryFee.TabIndex = 8;
            this.lblEntryFee.Text = "Entry Fee";
            // 
            // cbSelectTeamDropDown
            // 
            this.cbSelectTeamDropDown.FormattingEnabled = true;
            this.cbSelectTeamDropDown.Location = new System.Drawing.Point(31, 279);
            this.cbSelectTeamDropDown.Name = "cbSelectTeamDropDown";
            this.cbSelectTeamDropDown.Size = new System.Drawing.Size(298, 38);
            this.cbSelectTeamDropDown.TabIndex = 11;
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblSelectTeam.Location = new System.Drawing.Point(29, 239);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(156, 37);
            this.lblSelectTeam.TabIndex = 10;
            this.lblSelectTeam.Text = "Select Team";
            // 
            // linkNewTeam
            // 
            this.linkNewTeam.AutoSize = true;
            this.linkNewTeam.Location = new System.Drawing.Point(201, 246);
            this.linkNewTeam.Name = "linkNewTeam";
            this.linkNewTeam.Size = new System.Drawing.Size(128, 30);
            this.linkNewTeam.TabIndex = 12;
            this.linkNewTeam.TabStop = true;
            this.linkNewTeam.Text = "Create Team";
            this.linkNewTeam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNewTeam_LinkClicked);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAddTeam.Location = new System.Drawing.Point(74, 323);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(207, 52);
            this.btnAddTeam.TabIndex = 13;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreateTournament.Location = new System.Drawing.Point(344, 546);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(207, 52);
            this.btnCreateTournament.TabIndex = 13;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            this.btnCreateTournament.Click += new System.EventHandler(this.btnCreateTournament_Click);
            // 
            // listBoxTournamentTeams
            // 
            this.listBoxTournamentTeams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTournamentTeams.FormattingEnabled = true;
            this.listBoxTournamentTeams.ItemHeight = 30;
            this.listBoxTournamentTeams.Location = new System.Drawing.Point(403, 100);
            this.listBoxTournamentTeams.Name = "listBoxTournamentTeams";
            this.listBoxTournamentTeams.Size = new System.Drawing.Size(302, 182);
            this.listBoxTournamentTeams.TabIndex = 14;
            // 
            // lblTournamentPlayers
            // 
            this.lblTournamentPlayers.AutoSize = true;
            this.lblTournamentPlayers.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTournamentPlayers.Location = new System.Drawing.Point(396, 60);
            this.lblTournamentPlayers.Name = "lblTournamentPlayers";
            this.lblTournamentPlayers.Size = new System.Drawing.Size(198, 37);
            this.lblTournamentPlayers.TabIndex = 6;
            this.lblTournamentPlayers.Text = "Teams / Players";
            // 
            // btnRemoveTeam
            // 
            this.btnRemoveTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRemoveTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnRemoveTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnRemoveTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnRemoveTeam.Location = new System.Drawing.Point(724, 153);
            this.btnRemoveTeam.Name = "btnRemoveTeam";
            this.btnRemoveTeam.Size = new System.Drawing.Size(124, 77);
            this.btnRemoveTeam.TabIndex = 15;
            this.btnRemoveTeam.Text = "Remove Selected";
            this.btnRemoveTeam.UseVisualStyleBackColor = true;
            this.btnRemoveTeam.Click += new System.EventHandler(this.btnRemoveTeam_Click);
            // 
            // btnRemovePrize
            // 
            this.btnRemovePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRemovePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnRemovePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnRemovePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePrize.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePrize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnRemovePrize.Location = new System.Drawing.Point(724, 395);
            this.btnRemovePrize.Name = "btnRemovePrize";
            this.btnRemovePrize.Size = new System.Drawing.Size(124, 75);
            this.btnRemovePrize.TabIndex = 18;
            this.btnRemovePrize.Text = "Remove Selected";
            this.btnRemovePrize.UseVisualStyleBackColor = true;
            this.btnRemovePrize.Click += new System.EventHandler(this.btnRemovePrize_Click);
            // 
            // listBoxPrizes
            // 
            this.listBoxPrizes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPrizes.FormattingEnabled = true;
            this.listBoxPrizes.ItemHeight = 30;
            this.listBoxPrizes.Location = new System.Drawing.Point(403, 341);
            this.listBoxPrizes.Name = "listBoxPrizes";
            this.listBoxPrizes.Size = new System.Drawing.Size(302, 182);
            this.listBoxPrizes.TabIndex = 17;
            // 
            // lblPrizes
            // 
            this.lblPrizes.AutoSize = true;
            this.lblPrizes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrizes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblPrizes.Location = new System.Drawing.Point(396, 301);
            this.lblPrizes.Name = "lblPrizes";
            this.lblPrizes.Size = new System.Drawing.Size(85, 37);
            this.lblPrizes.TabIndex = 16;
            this.lblPrizes.Text = "Prizes";
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreatePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreatePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePrize.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePrize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreatePrize.Location = new System.Drawing.Point(74, 395);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(207, 52);
            this.btnCreatePrize.TabIndex = 13;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            this.btnCreatePrize.Click += new System.EventHandler(this.btnCreatePrize_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 610);
            this.Controls.Add(this.btnRemovePrize);
            this.Controls.Add(this.listBoxPrizes);
            this.Controls.Add(this.lblPrizes);
            this.Controls.Add(this.btnRemoveTeam);
            this.Controls.Add(this.listBoxTournamentTeams);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.linkNewTeam);
            this.Controls.Add(this.cbSelectTeamDropDown);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.textBoxEntryFee);
            this.Controls.Add(this.lblEntryFee);
            this.Controls.Add(this.textBoxTournamentName);
            this.Controls.Add(this.lblTournamentPlayers);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox textBoxTournamentName;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.TextBox textBoxEntryFee;
        private System.Windows.Forms.Label lblEntryFee;
        private System.Windows.Forms.ComboBox cbSelectTeamDropDown;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.LinkLabel linkNewTeam;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnCreateTournament;
        private System.Windows.Forms.ListBox listBoxTournamentTeams;
        private System.Windows.Forms.Label lblTournamentPlayers;
        private System.Windows.Forms.Button btnRemoveTeam;
        private System.Windows.Forms.Button btnRemovePrize;
        private System.Windows.Forms.ListBox listBoxPrizes;
        private System.Windows.Forms.Label lblPrizes;
        private System.Windows.Forms.Button btnCreatePrize;
    }
}