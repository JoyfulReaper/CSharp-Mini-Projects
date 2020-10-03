namespace DateAndTimeCalculator
{
    partial class DateTimeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateTimeForm));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TimerSecond = new System.Windows.Forms.Timer(this.components);
            this.lblCurrentDateTime = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblMonths = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.radioSubtract = new System.Windows.Forms.RadioButton();
            this.numericSeconds = new System.Windows.Forms.NumericUpDown();
            this.numericMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericHours = new System.Windows.Forms.NumericUpDown();
            this.numericDays = new System.Windows.Forms.NumericUpDown();
            this.numericMonths = new System.Windows.Forms.NumericUpDown();
            this.numericYears = new System.Windows.Forms.NumericUpDown();
            this.btnSetToCurrent = new System.Windows.Forms.Button();
            this.lblCurrentContent = new System.Windows.Forms.Label();
            this.lblSelectedContent = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResultDate = new System.Windows.Forms.Label();
            this.chkAlert = new System.Windows.Forms.CheckBox();
            this.lblStartingDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYears)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dddd MMM dd yyyy hh:mm:ss tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // TimerSecond
            // 
            this.TimerSecond.Enabled = true;
            this.TimerSecond.Interval = 1000;
            this.TimerSecond.Tick += new System.EventHandler(this.TimerSecond_Tick);
            // 
            // lblCurrentDateTime
            // 
            this.lblCurrentDateTime.AutoSize = true;
            this.lblCurrentDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDateTime.Location = new System.Drawing.Point(7, 8);
            this.lblCurrentDateTime.Name = "lblCurrentDateTime";
            this.lblCurrentDateTime.Size = new System.Drawing.Size(210, 20);
            this.lblCurrentDateTime.TabIndex = 1;
            this.lblCurrentDateTime.Text = "The current date and time is:";
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.Location = new System.Drawing.Point(7, 28);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(220, 20);
            this.lblSelected.TabIndex = 2;
            this.lblSelected.Text = "The selected date and time is:";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(9, 130);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(52, 13);
            this.lblSeconds.TabIndex = 6;
            this.lblSeconds.Text = "Seconds:";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(86, 130);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(47, 13);
            this.lblMinutes.TabIndex = 6;
            this.lblMinutes.Text = "Minutes:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(159, 130);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(38, 13);
            this.lblHours.TabIndex = 6;
            this.lblHours.Text = "Hours:";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(230, 130);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(34, 13);
            this.lblDays.TabIndex = 6;
            this.lblDays.Text = "Days:";
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Location = new System.Drawing.Point(301, 130);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(45, 13);
            this.lblMonths.TabIndex = 6;
            this.lblMonths.Text = "Months:";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(375, 130);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(40, 13);
            this.lblYears.TabIndex = 6;
            this.lblYears.Text = "Years: ";
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Checked = true;
            this.radioAdd.Location = new System.Drawing.Point(468, 126);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(70, 17);
            this.radioAdd.TabIndex = 7;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "Add Time";
            this.radioAdd.UseVisualStyleBackColor = true;
            // 
            // radioSubtract
            // 
            this.radioSubtract.AutoSize = true;
            this.radioSubtract.Location = new System.Drawing.Point(468, 149);
            this.radioSubtract.Name = "radioSubtract";
            this.radioSubtract.Size = new System.Drawing.Size(91, 17);
            this.radioSubtract.TabIndex = 8;
            this.radioSubtract.Text = "Subtract Time";
            this.radioSubtract.UseVisualStyleBackColor = true;
            // 
            // numericSeconds
            // 
            this.numericSeconds.Location = new System.Drawing.Point(12, 146);
            this.numericSeconds.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericSeconds.Name = "numericSeconds";
            this.numericSeconds.Size = new System.Drawing.Size(65, 20);
            this.numericSeconds.TabIndex = 1;
            // 
            // numericMinutes
            // 
            this.numericMinutes.Location = new System.Drawing.Point(89, 146);
            this.numericMinutes.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericMinutes.Name = "numericMinutes";
            this.numericMinutes.Size = new System.Drawing.Size(65, 20);
            this.numericMinutes.TabIndex = 2;
            // 
            // numericHours
            // 
            this.numericHours.Location = new System.Drawing.Point(162, 146);
            this.numericHours.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericHours.Name = "numericHours";
            this.numericHours.Size = new System.Drawing.Size(65, 20);
            this.numericHours.TabIndex = 3;
            // 
            // numericDays
            // 
            this.numericDays.Location = new System.Drawing.Point(233, 146);
            this.numericDays.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericDays.Name = "numericDays";
            this.numericDays.Size = new System.Drawing.Size(65, 20);
            this.numericDays.TabIndex = 4;
            // 
            // numericMonths
            // 
            this.numericMonths.Location = new System.Drawing.Point(304, 146);
            this.numericMonths.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericMonths.Name = "numericMonths";
            this.numericMonths.Size = new System.Drawing.Size(65, 20);
            this.numericMonths.TabIndex = 5;
            // 
            // numericYears
            // 
            this.numericYears.Location = new System.Drawing.Point(378, 146);
            this.numericYears.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericYears.Name = "numericYears";
            this.numericYears.Size = new System.Drawing.Size(65, 20);
            this.numericYears.TabIndex = 6;
            // 
            // btnSetToCurrent
            // 
            this.btnSetToCurrent.Location = new System.Drawing.Point(394, 75);
            this.btnSetToCurrent.Name = "btnSetToCurrent";
            this.btnSetToCurrent.Size = new System.Drawing.Size(118, 23);
            this.btnSetToCurrent.TabIndex = 9;
            this.btnSetToCurrent.Text = "Set to Current Time";
            this.btnSetToCurrent.UseVisualStyleBackColor = true;
            this.btnSetToCurrent.Click += new System.EventHandler(this.btnSetToCurrent_Click);
            // 
            // lblCurrentContent
            // 
            this.lblCurrentContent.AutoSize = true;
            this.lblCurrentContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentContent.Location = new System.Drawing.Point(229, 8);
            this.lblCurrentContent.Name = "lblCurrentContent";
            this.lblCurrentContent.Size = new System.Drawing.Size(43, 20);
            this.lblCurrentContent.TabIndex = 10;
            this.lblCurrentContent.Text = "time";
            // 
            // lblSelectedContent
            // 
            this.lblSelectedContent.AutoSize = true;
            this.lblSelectedContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedContent.Location = new System.Drawing.Point(229, 28);
            this.lblSelectedContent.Name = "lblSelectedContent";
            this.lblSelectedContent.Size = new System.Drawing.Size(43, 20);
            this.lblSelectedContent.TabIndex = 10;
            this.lblSelectedContent.Text = "time";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(132, 194);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(283, 31);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResultDate
            // 
            this.lblResultDate.AutoSize = true;
            this.lblResultDate.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultDate.Location = new System.Drawing.Point(99, 258);
            this.lblResultDate.Name = "lblResultDate";
            this.lblResultDate.Size = new System.Drawing.Size(98, 32);
            this.lblResultDate.TabIndex = 12;
            this.lblResultDate.Text = "Result";
            this.lblResultDate.Visible = false;
            // 
            // chkAlert
            // 
            this.chkAlert.AutoSize = true;
            this.chkAlert.Checked = true;
            this.chkAlert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlert.Location = new System.Drawing.Point(441, 207);
            this.chkAlert.Name = "chkAlert";
            this.chkAlert.Size = new System.Drawing.Size(71, 17);
            this.chkAlert.TabIndex = 13;
            this.chkAlert.Text = "Set Alarm";
            this.chkAlert.UseVisualStyleBackColor = true;
            // 
            // lblStartingDate
            // 
            this.lblStartingDate.AutoSize = true;
            this.lblStartingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartingDate.Location = new System.Drawing.Point(32, 79);
            this.lblStartingDate.Name = "lblStartingDate";
            this.lblStartingDate.Size = new System.Drawing.Size(108, 20);
            this.lblStartingDate.TabIndex = 2;
            this.lblStartingDate.Text = "Starting Date:";
            // 
            // DateTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 320);
            this.Controls.Add(this.chkAlert);
            this.Controls.Add(this.lblResultDate);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblSelectedContent);
            this.Controls.Add(this.lblCurrentContent);
            this.Controls.Add(this.btnSetToCurrent);
            this.Controls.Add(this.numericYears);
            this.Controls.Add(this.numericMonths);
            this.Controls.Add(this.numericDays);
            this.Controls.Add(this.numericHours);
            this.Controls.Add(this.numericMinutes);
            this.Controls.Add(this.numericSeconds);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblMonths);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.radioSubtract);
            this.Controls.Add(this.radioAdd);
            this.Controls.Add(this.lblStartingDate);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lblCurrentDateTime);
            this.Controls.Add(this.dateTimePicker1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DateTimeForm";
            this.Text = "Date and Time Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYears)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer TimerSecond;
        private System.Windows.Forms.Label lblCurrentDateTime;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.RadioButton radioSubtract;
        private System.Windows.Forms.NumericUpDown numericSeconds;
        private System.Windows.Forms.NumericUpDown numericMinutes;
        private System.Windows.Forms.NumericUpDown numericHours;
        private System.Windows.Forms.NumericUpDown numericDays;
        private System.Windows.Forms.NumericUpDown numericMonths;
        private System.Windows.Forms.NumericUpDown numericYears;
        private System.Windows.Forms.Button btnSetToCurrent;
        private System.Windows.Forms.Label lblCurrentContent;
        private System.Windows.Forms.Label lblSelectedContent;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResultDate;
        private System.Windows.Forms.CheckBox chkAlert;
        private System.Windows.Forms.Label lblStartingDate;
    }
}

