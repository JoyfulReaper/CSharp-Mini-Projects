namespace Art_Auction_GUI
{
    partial class frmSettings
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
            this.lblNumPaintings = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtBoxNumPainting = new System.Windows.Forms.TextBox();
            this.btnNow = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumPaintings
            // 
            this.lblNumPaintings.AutoSize = true;
            this.lblNumPaintings.Location = new System.Drawing.Point(27, 40);
            this.lblNumPaintings.Name = "lblNumPaintings";
            this.lblNumPaintings.Size = new System.Drawing.Size(104, 13);
            this.lblNumPaintings.TabIndex = 0;
            this.lblNumPaintings.Text = "Number of paintings:";
            // 
            // txtBoxNumPainting
            // 
            this.txtBoxNumPainting.Location = new System.Drawing.Point(138, 32);
            this.txtBoxNumPainting.Name = "txtBoxNumPainting";
            this.txtBoxNumPainting.Size = new System.Drawing.Size(56, 20);
            this.txtBoxNumPainting.TabIndex = 1;
            // 
            // btnNow
            // 
            this.btnNow.Location = new System.Drawing.Point(30, 70);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(75, 23);
            this.btnNow.TabIndex = 2;
            this.btnNow.Text = "Apply now";
            this.btnNow.UseVisualStyleBackColor = true;
            this.btnNow.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(138, 70);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(99, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Apply Next Game";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnNow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 108);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.txtBoxNumPainting);
            this.Controls.Add(this.lblNumPaintings);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumPaintings;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtBoxNumPainting;
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.Button btnNext;
    }
}