namespace CarRacingGame
{
    partial class CarRacingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarRacingForm));
            this.LeftLine = new System.Windows.Forms.PictureBox();
            this.RightLine = new System.Windows.Forms.PictureBox();
            this.LaneLine1 = new System.Windows.Forms.PictureBox();
            this.LaneLine4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayerCar = new System.Windows.Forms.PictureBox();
            this.LaneLine2 = new System.Windows.Forms.PictureBox();
            this.LaneLine3 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.coinsLabel = new System.Windows.Forms.Label();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LeftLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaneLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaneLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaneLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaneLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftLine
            // 
            this.LeftLine.BackColor = System.Drawing.Color.White;
            this.LeftLine.Location = new System.Drawing.Point(0, -3);
            this.LeftLine.Name = "LeftLine";
            this.LeftLine.Size = new System.Drawing.Size(10, 467);
            this.LeftLine.TabIndex = 0;
            this.LeftLine.TabStop = false;
            // 
            // RightLine
            // 
            this.RightLine.BackColor = System.Drawing.Color.White;
            this.RightLine.Location = new System.Drawing.Point(375, -3);
            this.RightLine.Name = "RightLine";
            this.RightLine.Size = new System.Drawing.Size(10, 467);
            this.RightLine.TabIndex = 0;
            this.RightLine.TabStop = false;
            // 
            // LaneLine1
            // 
            this.LaneLine1.BackColor = System.Drawing.Color.White;
            this.LaneLine1.Location = new System.Drawing.Point(191, -3);
            this.LaneLine1.Name = "LaneLine1";
            this.LaneLine1.Size = new System.Drawing.Size(10, 83);
            this.LaneLine1.TabIndex = 1;
            this.LaneLine1.TabStop = false;
            // 
            // LaneLine4
            // 
            this.LaneLine4.BackColor = System.Drawing.Color.White;
            this.LaneLine4.Location = new System.Drawing.Point(191, 381);
            this.LaneLine4.Name = "LaneLine4";
            this.LaneLine4.Size = new System.Drawing.Size(10, 83);
            this.LaneLine4.TabIndex = 1;
            this.LaneLine4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PlayerCar
            // 
            this.PlayerCar.Image = ((System.Drawing.Image)(resources.GetObject("PlayerCar.Image")));
            this.PlayerCar.Location = new System.Drawing.Point(65, 330);
            this.PlayerCar.Name = "PlayerCar";
            this.PlayerCar.Size = new System.Drawing.Size(45, 61);
            this.PlayerCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCar.TabIndex = 2;
            this.PlayerCar.TabStop = false;
            // 
            // LaneLine2
            // 
            this.LaneLine2.BackColor = System.Drawing.Color.White;
            this.LaneLine2.Location = new System.Drawing.Point(191, 128);
            this.LaneLine2.Name = "LaneLine2";
            this.LaneLine2.Size = new System.Drawing.Size(10, 83);
            this.LaneLine2.TabIndex = 1;
            this.LaneLine2.TabStop = false;
            // 
            // LaneLine3
            // 
            this.LaneLine3.BackColor = System.Drawing.Color.White;
            this.LaneLine3.Location = new System.Drawing.Point(191, 253);
            this.LaneLine3.Name = "LaneLine3";
            this.LaneLine3.Size = new System.Drawing.Size(10, 84);
            this.LaneLine3.TabIndex = 1;
            this.LaneLine3.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(12, 39);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(40, 50);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 3;
            this.enemy1.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(287, 93);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(40, 50);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 3;
            this.enemy3.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(207, 189);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(40, 50);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 3;
            this.enemy2.TabStop = false;
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Yellow;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.Red;
            this.gameOverLabel.Location = new System.Drawing.Point(119, 131);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(162, 31);
            this.gameOverLabel.TabIndex = 4;
            this.gameOverLabel.Text = "Game Over";
            // 
            // coinsLabel
            // 
            this.coinsLabel.AutoSize = true;
            this.coinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinsLabel.ForeColor = System.Drawing.Color.Yellow;
            this.coinsLabel.Location = new System.Drawing.Point(16, 9);
            this.coinsLabel.Name = "coinsLabel";
            this.coinsLabel.Size = new System.Drawing.Size(75, 20);
            this.coinsLabel.TabIndex = 5;
            this.coinsLabel.Text = "Coins = 0";
            // 
            // coin1
            // 
            this.coin1.Image = ((System.Drawing.Image)(resources.GetObject("coin1.Image")));
            this.coin1.Location = new System.Drawing.Point(125, 25);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(25, 25);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 6;
            this.coin1.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.Image = ((System.Drawing.Image)(resources.GetObject("coin2.Image")));
            this.coin2.Location = new System.Drawing.Point(342, 113);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(25, 25);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 6;
            this.coin2.TabStop = false;
            // 
            // coin3
            // 
            this.coin3.Image = ((System.Drawing.Image)(resources.GetObject("coin3.Image")));
            this.coin3.Location = new System.Drawing.Point(36, 241);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(25, 25);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 6;
            this.coin3.TabStop = false;
            // 
            // coin4
            // 
            this.coin4.Image = ((System.Drawing.Image)(resources.GetObject("coin4.Image")));
            this.coin4.Location = new System.Drawing.Point(330, 347);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(25, 25);
            this.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin4.TabIndex = 6;
            this.coin4.TabStop = false;
            // 
            // CarRacingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.coin4);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.coinsLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.PlayerCar);
            this.Controls.Add(this.LaneLine4);
            this.Controls.Add(this.LaneLine3);
            this.Controls.Add(this.LaneLine2);
            this.Controls.Add(this.LaneLine1);
            this.Controls.Add(this.RightLine);
            this.Controls.Add(this.LeftLine);
            this.Name = "CarRacingForm";
            this.Text = "Car Racing Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CarRacingForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.LeftLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaneLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaneLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaneLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaneLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox LeftLine;
        private System.Windows.Forms.PictureBox RightLine;
        private System.Windows.Forms.PictureBox LaneLine1;
        private System.Windows.Forms.PictureBox LaneLine4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PlayerCar;
        private System.Windows.Forms.PictureBox LaneLine2;
        private System.Windows.Forms.PictureBox LaneLine3;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label coinsLabel;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin4;
    }
}

