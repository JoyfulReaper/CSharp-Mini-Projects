namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.lblHeader = new System.Windows.Forms.Label();
            this.cbSelectTournament = new System.Windows.Forms.ComboBox();
            this.lblLoadExistingTournament = new System.Windows.Forms.Label();
            this.btnLoadTournament = new System.Windows.Forms.Button();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(124, 40);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(385, 50);
            this.lblHeader.TabIndex = 10;
            this.lblHeader.Text = "Tournament Dashboard";
            // 
            // cbSelectTournament
            // 
            this.cbSelectTournament.FormattingEnabled = true;
            this.cbSelectTournament.Location = new System.Drawing.Point(119, 165);
            this.cbSelectTournament.Name = "cbSelectTournament";
            this.cbSelectTournament.Size = new System.Drawing.Size(395, 38);
            this.cbSelectTournament.TabIndex = 17;
            // 
            // lblLoadExistingTournament
            // 
            this.lblLoadExistingTournament.AutoSize = true;
            this.lblLoadExistingTournament.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadExistingTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblLoadExistingTournament.Location = new System.Drawing.Point(155, 125);
            this.lblLoadExistingTournament.Name = "lblLoadExistingTournament";
            this.lblLoadExistingTournament.Size = new System.Drawing.Size(322, 37);
            this.lblLoadExistingTournament.TabIndex = 16;
            this.lblLoadExistingTournament.Text = "Load Existing Tournament";
            // 
            // btnLoadTournament
            // 
            this.btnLoadTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnLoadTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnLoadTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnLoadTournament.Location = new System.Drawing.Point(213, 209);
            this.btnLoadTournament.Name = "btnLoadTournament";
            this.btnLoadTournament.Size = new System.Drawing.Size(207, 52);
            this.btnLoadTournament.TabIndex = 18;
            this.btnLoadTournament.Text = "Load Tournament";
            this.btnLoadTournament.UseVisualStyleBackColor = true;
            this.btnLoadTournament.Click += new System.EventHandler(this.btnLoadTournament_Click);
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreateTournament.Location = new System.Drawing.Point(182, 278);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(268, 82);
            this.btnCreateTournament.TabIndex = 22;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            this.btnCreateTournament.Click += new System.EventHandler(this.btnCreateTournament_Click);
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 394);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnLoadTournament);
            this.Controls.Add(this.cbSelectTournament);
            this.Controls.Add(this.lblLoadExistingTournament);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox cbSelectTournament;
        private System.Windows.Forms.Label lblLoadExistingTournament;
        private System.Windows.Forms.Button btnLoadTournament;
        private System.Windows.Forms.Button btnCreateTournament;
    }
}