using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace CarRacingGame
{
    public partial class CarRacingForm : Form
    {
        private int gameSpeed = 5;
        private int coinCount = 0;
        Random rand = new Random();

        public CarRacingForm()
        {
            InitializeComponent();
            gameOverLabel.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveLaneLines(gameSpeed);
            MoveEnemy(gameSpeed);
            CheckGameOver();
            MoveCoins(gameSpeed);
            CheckCoinCollison();
        }

        private void MoveEnemy(int speed)
        {
            int x, y;

            if (enemy1.Top >= 500)
            {
                x = rand.Next(0, 200);
                enemy1.Location = new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }

            if (enemy2.Top >= 500)
            {
                x = rand.Next(0, 400);
                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top >= 500)
            {
                x = rand.Next(200, 350);
                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }
        }

        private void MoveCoins(int speed)
        {
            int x, y;

            if (coin1.Top >= 500)
            {
                x = rand.Next(0, 200);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }

            if (coin2.Top >= 500)
            {
                x = rand.Next(0, 200);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }

            if (coin3.Top >= 500)
            {
                x = rand.Next(50, 300);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }

            if (coin4.Top >= 500)
            {
                x = rand.Next(0, 400);
                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }
        }

        private void CheckGameOver()
        {
            if(PlayerCar.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                gameOverLabel.Visible = true;
            }

            if (PlayerCar.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                gameOverLabel.Visible = true;
            }

            if (PlayerCar.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                gameOverLabel.Visible = true;
            }
        }

        private void CheckCoinCollison()
        {
            int x;
            if (PlayerCar.Bounds.IntersectsWith(coin1.Bounds))
            {
                coinCount++;
                coinsLabel.Text = "Coins = " + coinCount.ToString();

                x = rand.Next(50, 300);
                coin1.Location = new Point(x, 0);
            }

            if (PlayerCar.Bounds.IntersectsWith(coin2.Bounds))
            {
                coinCount++;
                coinsLabel.Text = "Coins = " + coinCount.ToString();

                x = rand.Next(50, 300);
                coin2.Location = new Point(x, 0);
            }

            if (PlayerCar.Bounds.IntersectsWith(coin3.Bounds))
            {
                coinCount++;
                coinsLabel.Text = "Coins = " + coinCount.ToString();

                x = rand.Next(50, 300);
                coin3.Location = new Point(x, 0);
            }

            if (PlayerCar.Bounds.IntersectsWith(coin4.Bounds))
            {
                coinCount++;
                coinsLabel.Text = "Coins = " + coinCount.ToString();

                x = rand.Next(50, 300);
                coin4.Location = new Point(x, 0);
            }
        }

        private void MoveLaneLines(int speed)
        {
            if (LaneLine1.Top >= 500)
            {
                LaneLine1.Top = 0;
            }
            else
            {
                LaneLine1.Top += speed;
            }

            if (LaneLine2.Top >= 500)
            {
                LaneLine2.Top = 0;
            }
            else
            {
                LaneLine2.Top += speed;
            }

            if (LaneLine3.Top >= 500)
            {
                LaneLine3.Top = 0;
            }
            else
            {
                LaneLine3.Top += speed;
            }

            if (LaneLine4.Top >= 500)
            {
                LaneLine4.Top = 0;
            }
            else
            {
                LaneLine4.Top += speed;
            }
        }

        private void CarRacingForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(!timer1.Enabled)
            {
                return;
            }

            if(e.KeyCode == Keys.Left)
            {
                if (PlayerCar.Left > 0)
                {
                    PlayerCar.Left -= 8;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                if (PlayerCar.Right < 380)
                {
                    PlayerCar.Left += 8;
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                if (gameSpeed < 21)
                {
                    gameSpeed++;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (gameSpeed > 0)
                {
                    gameSpeed--;
                }
            }
        }
    }
}
