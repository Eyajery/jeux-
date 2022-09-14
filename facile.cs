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
    public partial class facile : Form
    {
        List<int> numbers = new List<int> { 1, 1, 2, 2,3,3 };
        string premierchois;//le premier chois d,un carte 
        string deuxemechois;//le deauxieme chois d'un carte
        int tries;
        List<PictureBox> image = new List<PictureBox>();
        PictureBox imA;
        PictureBox imB;
        int totalTime = 30;//le temps pour finir le jaux 
        int countDownTime;//le conteur qui diminue au cours du temps 
        bool gameOver = false;
        
        public facile()
        {
            InitializeComponent();
            LoadPictures();
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
                foreach (PictureBox x in image)
                {
                    if (x.Tag != null)
                    {
                        x.Image = Image.FromFile("pics/" + (string)x.Tag + ".png");
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

            for (int i = 0; i < 6; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = 100;
                newPic.Width = 100;
                newPic.BackColor = Color.SkyBlue;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += newPic_Click;
                image.Add(newPic);

                if (rows < 3)
                {
                    rows++;
                    newPic.Left = leftPos;
                    newPic.Top = topPos;
                    this.Controls.Add(newPic);
                    leftPos = leftPos + 140;

                }

                if (rows == 3)
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

            if (premierchois == null)
            {
                imA = sender as PictureBox;
                if (imA.Tag != null && imA.Image == null)
                {
                    imA.Image = Image.FromFile("pics/" + (String)imA.Tag + ".png");
                    premierchois = (string)imA.Tag;
                }
            }
            else if (deuxemechois == null)
            {
                imB = sender as PictureBox;
                if (imB.Tag != null && imB.Image == null)
                {
                    imB.Image = Image.FromFile("pics/" + (string)imB.Tag + ".png");
                    deuxemechois = (string)imB.Tag;
                }
            }

            else
            {
                CheckPictures(imA, imB);
            }



        }


        private void RestartGame()
        {
            //randomise the original list
            var randomList = numbers.OrderBy(x => Guid.NewGuid()).ToList();
            //assign the random list to the original
            numbers = randomList;

            for (int i = 0; i < image.Count; i++)
            {
                image[i].Image = null;
                image[i].Tag = numbers[i].ToString();
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
            if (premierchois == deuxemechois)
            {
                A.Tag = null;
                B.Tag = null;

            }
            else
            {
                tries++;
                lblStatues.Text = "Mismatched " + tries + " times.";
            }
            premierchois = null;
            deuxemechois = null;

            foreach (PictureBox pics in image.ToList())
            {

                if (pics.Tag != null)
                {
                    pics.Image = null;

                }
            }
            if (A.Tag == B.Tag )
            {
               var newform = new quizmath();
                newform.Show();

            }

           

                if (A.Tag != B.Tag )
            {
                var newform = new quizculturel();
                newform.Show();
            }
            // now lets check if all of the items have been solved 
            if (image.All(o => o.Tag == image[0].Tag))
            {  
                    GameOver("BRAVO!!");
                //var newform2 = new Play();
               // newform2.Show();
            }
        }
        private void GameOver(string msg)
        {
            GameTimer.Stop();
            gameOver = true;
            MessageBox.Show(msg + " Click Restart to ", "Moo Says: ");
            //fermer la quizz math
            quizmath.ActiveForm.Close();
            //fermer la class facile
            facile.ActiveForm.Close();
            //affichier la class play 
            var newform2 = new Play();
            newform2.Show();
            
        }

       
        
    }
}
