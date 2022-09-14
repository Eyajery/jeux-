using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class moyen : Form
    {
        List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        string firstChoice;
        string secondChoice;
        int tries;
        List<PictureBox> picturs = new List<PictureBox>();
        PictureBox picA;
        PictureBox picB;
        int totalTime = 30;
        int countDownTime;
        bool gameOver = false;
        public moyen()
        {
            InitializeComponent();
            LoadPictures();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTimeLeft_Click(object sender, EventArgs e)
        {

        }

        private void TamerEvent(object sender, EventArgs e)
        {
            countDownTime--;
            lblTimeLeft.Text = "Time Left: " + countDownTime;

            if (countDownTime < 1)
            {
                GameOver("Time Up, You Lose");
                foreach (PictureBox x in picturs)
                {
                    if (x.Tag != null)
                    {
                        x.Image = Image.FromFile("pics1/" + (string)x.Tag + ".png");
                    }
                }
            }
        }

        private void RestartGameEvent(object sender, EventArgs e)
        {
            RestartGame();

        }

        private void LoadPictures()
        {
            int leftPos = 250;
            int topPos = 180;
            int rows = 0;

            for (int i = 0; i < 12; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = 100;
                newPic.Width = 100;
                newPic.BackColor = Color.SkyBlue;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += newPic_Click;
                picturs.Add(newPic);

                if (rows < 4)
                {
                    rows++;
                    newPic.Left = leftPos;
                    newPic.Top = topPos;
                    this.Controls.Add(newPic);
                    leftPos = leftPos + 140;

                }

                if (rows == 4)
                {
                    leftPos = 250;
                    topPos += 140;
                    rows = 0;
                }
            }

            RestartGame();

        }


        private void newPic_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                // dont register a click if the game is over 
                return;
            }

            if (firstChoice == null)
            {
                picA = sender as PictureBox;
                if (picA.Tag != null && picA.Image == null)
                {
                    picA.Image = Image.FromFile("pics1/" + (String)picA.Tag + ".png");
                    firstChoice = (string)picA.Tag;
                }
            }
            else if (secondChoice == null)
            {
                picB = sender as PictureBox;
                if (picB.Tag != null && picB.Image == null)
                {
                    picB.Image = Image.FromFile("pics1/" + (string)picB.Tag + ".png");
                    secondChoice = (string)picB.Tag;
                }
            }

            else
            {
                CheckPictures(picA, picB);
            }



        }


        private void RestartGame()
        {
            //randomise the original list
            var randomList = numbers.OrderBy(x => Guid.NewGuid()).ToList();
            //assign the random list to the original
            numbers = randomList;

            for (int i = 0; i < picturs.Count; i++)
            {
                picturs[i].Image = null;
                picturs[i].Tag = numbers[i].ToString();
            }

            tries = 0;
            lblStatues.Text = "Mismatched: " + tries + " times.";
            lblTimeLeft.Text = "Time Left: " + totalTime;
            gameOver = false;
            GameTimer.Start();
            countDownTime = totalTime;

        }
        private void CheckPictures(PictureBox A, PictureBox B)
        {
            if (firstChoice == secondChoice)
            {
                A.Tag = null;
                B.Tag = null;

            }
            else
            {
                tries++;
                lblStatues.Text = "Mismatched " + tries + " times.";
            }
            firstChoice = null;
            secondChoice = null;

            foreach (PictureBox pics in picturs.ToList())
            {

                if (pics.Tag != null)
                {
                    pics.Image = null;

                }
            }
            if (A.Tag == B.Tag)
            {
                var newform = new quizmath();
                newform.Show();

            }
            if (A.Tag != B.Tag)
            {
                var newform = new quizculturel();
                newform.Show();
            }
            // now lets check if all of the items have been solved 
            if (picturs.All(o => o.Tag == picturs[0].Tag))
            {
                GameOver("BRAVO !!! ");

            }
        }
        private void GameOver(string msg)
        {
            GameTimer.Stop();
            gameOver = true;
            MessageBox.Show(msg + " Click Restart to ", "Moo Says: ");
            //fermer la quizz math
            quizmath.ActiveForm.Close();
            //fermer la class moyen
            moyen.ActiveForm.Close();
            //affichier la class play 
            var newform2 = new Play();
            newform2.Show();

        }

        private void lblStatues_Click(object sender, EventArgs e)
        {

        }
    }
}
