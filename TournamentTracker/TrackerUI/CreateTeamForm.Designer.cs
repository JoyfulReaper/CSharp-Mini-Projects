namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.cbSelectMemberDropDown = new System.Windows.Forms.ComboBox();
            this.lblSelectMember = new System.Windows.Forms.Label();
            this.groupBoxAddNewMember = new System.Windows.Forms.GroupBox();
            this.textBoxCellphone = new System.Windows.Forms.TextBox();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblTeamFirstName = new System.Windows.Forms.Label();
            this.btmCreateMember = new System.Windows.Forms.Button();
            this.listBoxTeamMembers = new System.Windows.Forms.ListBox();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.groupBoxAddNewMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Location = new System.Drawing.Point(39, 125);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(391, 35);
            this.textBoxTeamName.TabIndex = 10;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamName.Location = new System.Drawing.Point(32, 85);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(157, 37);
            this.lblTeamName.TabIndex = 9;
            this.lblTeamName.Text = "Team Name";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(30, 24);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(213, 50);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Create Team";
            // 
            // btnAddMember
            // 
            this.btnAddMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAddMember.Location = new System.Drawing.Point(123, 270);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(207, 52);
            this.btnAddMember.TabIndex = 16;
            this.btnAddMember.Text = "Add Team Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            // 
            // cbSelectMemberDropDown
            // 
            this.cbSelectMemberDropDown.FormattingEnabled = true;
            this.cbSelectMemberDropDown.Location = new System.Drawing.Point(35, 226);
            this.cbSelectMemberDropDown.Name = "cbSelectMemberDropDown";
            this.cbSelectMemberDropDown.Size = new System.Drawing.Size(395, 38);
            this.cbSelectMemberDropDown.TabIndex = 15;
            // 
            // lblSelectMember
            // 
            this.lblSelectMember.AutoSize = true;
            this.lblSelectMember.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblSelectMember.Location = new System.Drawing.Point(33, 186);
            this.lblSelectMember.Name = "lblSelectMember";
            this.lblSelectMember.Size = new System.Drawing.Size(263, 37);
            this.lblSelectMember.TabIndex = 14;
            this.lblSelectMember.Text = "Select Team Member";
            // 
            // groupBoxAddNewMember
            // 
            this.groupBoxAddNewMember.Controls.Add(this.btmCreateMember);
            this.groupBoxAddNewMember.Controls.Add(this.textBoxCellphone);
            this.groupBoxAddNewMember.Controls.Add(this.lblCellPhone);
            this.groupBoxAddNewMember.Controls.Add(this.textBoxEmail);
            this.groupBoxAddNewMember.Controls.Add(this.lblEmail);
            this.groupBoxAddNewMember.Controls.Add(this.textBoxLastName);
            this.groupBoxAddNewMember.Controls.Add(this.lblLastName);
            this.groupBoxAddNewMember.Controls.Add(this.textBoxFirstName);
            this.groupBoxAddNewMember.Controls.Add(this.lblTeamFirstName);
            this.groupBoxAddNewMember.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddNewMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.groupBoxAddNewMember.Location = new System.Drawing.Point(35, 359);
            this.groupBoxAddNewMember.Name = "groupBoxAddNewMember";
            this.groupBoxAddNewMember.Size = new System.Drawing.Size(395, 388);
            this.groupBoxAddNewMember.TabIndex = 17;
            this.groupBoxAddNewMember.TabStop = false;
            this.groupBoxAddNewMember.Text = "Add New Member";
            // 
            // textBoxCellphone
            // 
            this.textBoxCellphone.Location = new System.Drawing.Point(169, 258);
            this.textBoxCellphone.Name = "textBoxCellphone";
            this.textBoxCellphone.Size = new System.Drawing.Size(201, 43);
            this.textBoxCellphone.TabIndex = 13;
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblCellPhone.Location = new System.Drawing.Point(19, 256);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(138, 37);
            this.lblCellPhone.TabIndex = 12;
            this.lblCellPhone.Text = "Cellphone";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(167, 195);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(201, 43);
            this.textBoxEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblEmail.Location = new System.Drawing.Point(19, 192);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 37);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(167, 131);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(201, 43);
            this.textBoxLastName.TabIndex = 9;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblLastName.Location = new System.Drawing.Point(17, 129);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(142, 37);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(167, 60);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(201, 43);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // lblTeamFirstName
            // 
            this.lblTeamFirstName.AutoSize = true;
            this.lblTeamFirstName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamFirstName.Location = new System.Drawing.Point(17, 58);
            this.lblTeamFirstName.Name = "lblTeamFirstName";
            this.lblTeamFirstName.Size = new System.Drawing.Size(144, 37);
            this.lblTeamFirstName.TabIndex = 6;
            this.lblTeamFirstName.Text = "First Name";
            // 
            // btmCreateMember
            // 
            this.btmCreateMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btmCreateMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btmCreateMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btmCreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmCreateMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCreateMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btmCreateMember.Location = new System.Drawing.Point(88, 314);
            this.btmCreateMember.Name = "btmCreateMember";
            this.btmCreateMember.Size = new System.Drawing.Size(207, 52);
            this.btmCreateMember.TabIndex = 17;
            this.btmCreateMember.Text = "Create Member";
            this.btmCreateMember.UseVisualStyleBackColor = true;
            // 
            // listBoxTeamMembers
            // 
            this.listBoxTeamMembers.FormattingEnabled = true;
            this.listBoxTeamMembers.ItemHeight = 30;
            this.listBoxTeamMembers.Location = new System.Drawing.Point(484, 113);
            this.listBoxTeamMembers.Name = "listBoxTeamMembers";
            this.listBoxTeamMembers.Size = new System.Drawing.Size(347, 634);
            this.listBoxTeamMembers.TabIndex = 18;
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDeleteMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeleteMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnDeleteMember.Location = new System.Drawing.Point(855, 379);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(124, 75);
            this.btnDeleteMember.TabIndex = 19;
            this.btnDeleteMember.Text = "Delete Selected";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreateTeam.Location = new System.Drawing.Point(365, 770);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(207, 52);
            this.btnCreateTeam.TabIndex = 20;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 834);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.listBoxTeamMembers);
            this.Controls.Add(this.groupBoxAddNewMember);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.cbSelectMemberDropDown);
            this.Controls.Add(this.lblSelectMember);
            this.Controls.Add(this.textBoxTeamName);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.groupBoxAddNewMember.ResumeLayout(false);
            this.groupBoxAddNewMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.ComboBox cbSelectMemberDropDown;
        private System.Windows.Forms.Label lblSelectMember;
        private System.Windows.Forms.GroupBox groupBoxAddNewMember;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label lblTeamFirstName;
        private System.Windows.Forms.TextBox textBoxCellphone;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btmCreateMember;
        private System.Windows.Forms.ListBox listBoxTeamMembers;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnCreateTeam;
    }
}