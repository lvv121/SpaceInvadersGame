using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using Projekt.Properties;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Projekt
{
    public partial class Form1 : Form
    {
        private PictureBox[] enemiesArray;
        private int enemyBulletTimer = 100;
        private int enemySpeed = 5;
        private bool goLeft, goRight;
        private bool isGameOver;
        private readonly int playerSpeed = 12;
        private int score;

        private bool shooting;

        public Form1()
        {
            InitializeComponent();
            gameSetup();
        }

        private void gameTime(object sender, EventArgs e)
        {
            textScore.Text = "Wynik: " + score;
            if (goLeft)
                player.Left -= playerSpeed;

            if (goRight)
                player.Left += playerSpeed;

            enemyBulletTimer -= 10;

            if (enemyBulletTimer < 1)
            {
                enemyBulletTimer = 300;
                makeBullet("enemyBullet");
            }

            foreach (Control x in Controls)
            {
                if (x is PictureBox && (string)x.Tag == "enemies")
                {
                    x.Left += enemySpeed;

                    if (x.Left > 730)
                    {
                        x.Top += 65;
                        x.Left = -80;
                    }

                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {
                        heart1.Image = null;
                        heart2.Image = null;
                        heart3.Image = null;
                        gameOver("Zostałeś pokonany!");
                    }

                    foreach (Control y in Controls)
                        if (y is PictureBox && (string)y.Tag == "bullet")
                            if (y.Bounds.IntersectsWith(x.Bounds))
                            {
                                Controls.Remove(x);
                                Controls.Remove(y);
                                score += 1;
                                shooting = false;
                            }
                }

                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Top -= 20;

                    if (x.Top < 15)
                    {
                        Controls.Remove(x);
                        shooting = false;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "enemyBullet")
                {
                    x.Top += 20;

                    if (x.Top > 620) Controls.Remove(x);

                    if (heart1.Image != null && x.Bounds.IntersectsWith(player.Bounds))
                    {
                        Controls.Remove(x);
                        heart1.Image = null;
                    }
                    else if (heart2.Image != null && x.Bounds.IntersectsWith(player.Bounds) && heart1.Image == null)
                    {
                        Controls.Remove(x);
                        heart2.Image = null;
                    }
                    else if (heart3.Image != null && x.Bounds.IntersectsWith(player.Bounds) && heart1.Image == null &&
                             heart2.Image == null)
                    {
                        Controls.Remove(x);
                        heart3.Image = null;
                        gameOver("Skończyły ci się życia!");
                    }
                }
            }

            if (score > 8) enemySpeed = 10;

            if (score == enemiesArray.Length) gameOver("Wygrana!");
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goLeft = true;

            if (e.KeyCode == Keys.Right)
                goRight = true;
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goLeft = false;

            if (e.KeyCode == Keys.Right)
                goRight = false;

            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;
                makeBullet("bullet");
            }

            if (e.KeyCode == Keys.Enter && isGameOver)
            {
                removeAll();
                gameSetup();
            }
        }

        private void makeEnemies()
        {
            enemiesArray = new PictureBox[15];

            var left = 0;

            for (var i = 0; i < enemiesArray.Length; i++)
            {
                enemiesArray[i] = new PictureBox();
                enemiesArray[i].Size = new Size(60, 50);
                enemiesArray[i].Image = Resources._2;
                enemiesArray[i].Top = 5;
                enemiesArray[i].Tag = "enemies";
                enemiesArray[i].Left = left;
                enemiesArray[i].SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(enemiesArray[i]);
                left = left - 80;
            }
        }

        private void gameSetup()
        {
            textScore.Text = "Wynik: 0";
            score = 0;
            isGameOver = false;

            enemyBulletTimer = 300;
            enemySpeed = 5;
            shooting = false;

            manLabelText();
            makeEnemies();
            gameTimer.Start();
        }

        private void gameOver(string message)
        {
            isGameOver = true;
            gameTimer.Stop();

            var result = (MessageBoxResult)MessageBox.Show(
                message + "\nTwój wynik to " + score + "\nCzy chciałbyś zagrać jeszcze?", "Koniec gry",
                (MessageBoxButtons)MessageBoxButton.YesNoCancel);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    removeAll();
                    gameSetup();
                    break;

                case MessageBoxResult.No:
                    Close();
                    break;

                case MessageBoxResult.Cancel:
                    Close();
                    break;
            }
        }

        private void removeAll()
        {
            foreach (var i in enemiesArray) Controls.Remove(i);

            foreach (Control x in Controls)
                if (x is PictureBox)
                    if ((string)x.Tag == "bullet" || (string)x.Tag == "enemyBullet")
                        Controls.Remove(x);
        }

        private void makeBullet(string bulletTag)
        {
            var bullet = new PictureBox();
            bullet.Image = Resources.bullet;
            bullet.Size = new Size(5, 20);
            bullet.Tag = bulletTag;
            bullet.Left = player.Left + player.Width / 2;

            if ((string)bullet.Tag == "bullet")
                bullet.Top = player.Top - 20;
            else if ((string)bullet.Tag == "enemyBullet") bullet.Top = 100;

            Controls.Add(bullet);
            bullet.BringToFront();
        }

        private void manLabelText()
        {
            manLabel.Text =
                "Instrukcja\nstrzałka w lewo -> ruch statku w lewo\nstrzałka w prawo -> ruch statku w prawo\nspacja -> wystrzelenie pocisku przez statek\nKliknij, aby to okienko z tekstem zniknęło";
        }

        private void manLabelClick(object sender, EventArgs e)
        {
            manLabel.Text = "";
        }
    }
}