using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace animal_Race
{
    // ****************************************************************
    // Title: Animal Race
    // Application Type: Winforms 
    // Description: 
    // Author: Michelle Beckett
    // Date Created: 04/03/21
    // Last Modified: 04/17/21
    //******************************************************************  

    public partial class Frog1 : Form
    {
        public Frog1()
        {


            InitializeComponent();
            over.Visible = false;
            win.Visible = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RoadMover_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            tiger(gamespeed);
            Frog(gamespeed);
            Grass(gamespeed);
            //gameover();
            stars(gamespeed);
            starcollection();
            Game_UpDate();
            Win();
            PlaySound();
        }

        /// <summary>
        /// when the lives are over a crash sound will appear
        /// </summary>
        private void PlaySound()
        {
            System.Media.SoundPlayer playauto_crash3 = new System.Media.SoundPlayer(Properties.Resources.auto_crash3);
            playauto_crash3.Play();
        }


        /// <summary>
        /// allow the white road marks to move
        /// </summary>
        /// <param name="speed"></param>
        void moveline(int speed)
        {

            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

            if (pictureBox5.Top >= 500)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }

            if (pictureBox6.Top >= 500)
            {
                pictureBox6.Top = 0;
            }
            else
            {
                pictureBox6.Top += speed;
            }

            if (pictureBox7.Top >= 500)
            {
                pictureBox7.Top = 0;
            }
            else
            {
                pictureBox7.Top += speed;
            }

            if (pictureBox8.Top >= 500)
            {
                pictureBox8.Top = 0;
            }
            else
            {
                pictureBox8.Top += speed;
            }

            pictureBox1.Top += speed;
            pictureBox2.Top += speed;
            pictureBox3.Top += speed;
            pictureBox4.Top += speed;
            pictureBox5.Top += speed;
            pictureBox6.Top += speed;
            pictureBox7.Top += speed;
            pictureBox8.Top += speed;

        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// the tiger xs 3 is able to move with the moveline and is placed throughout the form
        /// </summary>
        int collectedstars = 0;
        Random r = new Random();
        int a, b;
        void tiger(int speed)
        {
            if (tiger1.Top >= 500)
            {
                a = r.Next(0, 220);
                tiger1.Location = new Point(a, 0);
            }
            else
            {
                tiger1.Top += speed;
            }

            if (tiger2.Top >= 500)
            {
                a = r.Next(0, 300);
                tiger2.Location = new Point(a, 0);
            }
            else
            {
                tiger2.Top += speed;
            }

            if (tiger3.Top >= 500)
            {
                a = r.Next(0, 400);
                tiger3.Location = new Point(a, 0);
            }
            else
            {
                tiger3.Top += speed;
            }
        }

        /// <summary>
        /// the frog xs 2 is placed in the moveline and moves along the road
        /// </summary>
        /// <param name="speed"></param>
        void Frog(int speed)
        {
            if (frog2.Top >= 500)
            {
                a = r.Next(0, 400);
                frog2.Location = new Point(a, 0);
            }
            else
            {
                frog2.Top += speed;
            }

            if (frog3.Top >= 500)
            {
                a = r.Next(0, 400);
                frog3.Location = new Point(a, 0);
            }
            else
            {
                frog3.Top += speed;
            }
        }

        /// <summary>
        /// 
        /// </summary>the grass moves with the moveline and is placed throughout the form
        /// <param name="speed"></param>
        void Grass(int speed)
        {
            if (grass1.Top >= 500)
            {
                a = r.Next(0, 400);
                grass1.Location = new Point(a, 0);
            }
            else
            {
                grass1.Top += speed;
            }

            if (grass2.Top >= 500)
            {
                a = r.Next(0, 400);
                grass2.Location = new Point(a, 0);
            }
            else
            {
                grass2.Top += speed;
            }

            if (grass3.Top >= 500)
            {
                a = r.Next(0, 400);
                grass3.Location = new Point(a, 0);
            }
            else
            {
                grass3.Top += speed;
            }
        }

        /// <summary>
        /// the stars xs 5 are placed along the moveline and are spread out within the form
        /// </summary>
        /// <param name="speed"></param>
        void stars(int speed)
        {
            if (star1.Top >= 500)
            {
                a = r.Next(0, 225);
                star1.Location = new Point(a, 0);
            }
            else
            {
                star1.Top += speed;
            }

            if (star2.Top >= 500)
            {
                a = r.Next(0, 225);
                star2.Location = new Point(a, 0);
            }
            else
            {
                star2.Top += speed;
            }

            if (star3.Top >= 500)
            {
                a = r.Next(0, 225);
                star3.Location = new Point(a, 0);
            }
            else
            {
                star3.Top += speed;
            }

            if (star4.Top >= 500)
            {
                a = r.Next(0, 225);
                star4.Location = new Point(a, 0);
            }
            else
            {
                star4.Top += speed;
            }

            if (star5.Top >= 500)
            {
                a = r.Next(0, 225);
                star5.Location = new Point(a, 0);
            }
            else
            {
                star5.Top += speed;
            }
        }

        /// <summary>
        /// this is where the method allows the stars to be collected by the safari car to collect points
        /// </summary>
        void starcollection()
        {
            if (car.Bounds.IntersectsWith(star1.Bounds))
            {
                collectedstars++;
                label1.Text = "stars=" + collectedstars.ToString();

                a = r.Next(50, 200);
                star1.Location = new Point(a, 0);
            }

            if (car.Bounds.IntersectsWith(star2.Bounds))
            {
                collectedstars++;
                label1.Text = "stars=" + collectedstars.ToString();

                a = r.Next(50, 200);
                star2.Location = new Point(a, 0);
            }

            if (car.Bounds.IntersectsWith(star3.Bounds))
            {
                collectedstars++;
                label1.Text = "stars=" + collectedstars.ToString();

                a = r.Next(50, 200);
                star3.Location = new Point(a, 0);
            }

            if (car.Bounds.IntersectsWith(star4.Bounds))
            {
                collectedstars++;
                label1.Text = "stars=" + collectedstars.ToString();

                a = r.Next(50, 200);
                star4.Location = new Point(a, 0);
            }

            if (car.Bounds.IntersectsWith(star5.Bounds))
            {
                collectedstars++;
                label1.Text = "stars=" + collectedstars.ToString();

                a = r.Next(50, 200);
                star5.Location = new Point(a, 0);
            }
        }

        //void gameover()
        //{
        //  if (car.Bounds.IntersectsWith(tiger1.Bounds))
        //{
        //  RoadMover.Enabled = false;
        //over.Visible = true;
        //}

        //if (car.Bounds.IntersectsWith(tiger2.Bounds))
        //{
        //  RoadMover.Enabled = false;
        //over.Visible = true;
        //}

        //if (car.Bounds.IntersectsWith(tiger3.Bounds))
        //{
        //  RoadMover.Enabled = false;
        //over.Visible = true;
        //}
        //}

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void car_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        int gamespeed = 0;

        private void life1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// total life starts with red hearts and moves to black when it touches a tiger, frog, or grass
        /// </summary>
        int life;
        void life_index()
        {
            if (life == 1)
            {
                lif1.Image = Properties.Resources.black_Heart;
            }

            if (life == 2)
            {
                lif2.Image = Properties.Resources.black_Heart;
            }

            if (life == 3)
            {
                lif3.Image = Properties.Resources.black_Heart;

                over.Visible = true;
                RoadMover.Stop();
                PlaySound();
            }
        }

        /// <summary>
        /// minus one life when the safari car touchs a tiger, frog or dune grass
        /// </summary>
        void Game_UpDate()
        {
            if (car.Bounds.IntersectsWith(tiger1.Bounds))
            {
                tiger1.Location = new Point(a, 0);
                tiger1.Top -= 200;
                life += 1;
                life_index();
            }

            if (car.Bounds.IntersectsWith(tiger2.Bounds))
            {
                tiger2.Location = new Point(a, 0);
                tiger2.Top -= 200;
                life += 1;
                life_index();
            }

            if (car.Bounds.IntersectsWith(tiger3.Bounds))
            {
                tiger3.Location = new Point(a, 0);
                tiger3.Top -= 200;
                life += 1;
                life_index();
            }

            if (car.Bounds.IntersectsWith(frog2.Bounds))
            {
                frog2.Location = new Point(a, 0);
                frog2.Top -= 200;
                life += 1;
                life_index();
            }

            if (car.Bounds.IntersectsWith(frog3.Bounds))
            {
                frog3.Location = new Point(a, 0);
                frog3.Top -= 200;
                life += 1;
                life_index();
            }

            if (car.Bounds.IntersectsWith(grass1.Bounds))
            {
                grass1.Location = new Point(a, 0);
                grass1.Top -= 200;
                life += 1;
                life_index();
            }

            if (car.Bounds.IntersectsWith(grass2.Bounds))
            {
                grass2.Location = new Point(a, 0);
                grass2.Top -= 200;
                life += 1;
                life_index();
            }

            if (car.Bounds.IntersectsWith(grass3.Bounds))
            {
                grass3.Location = new Point(a, 0);
                grass3.Top -= 200;
                life += 1;
                life_index();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void over_Click(object sender, EventArgs e)
        {

        }

        private void win_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// when the safari car collects 20 stars-'You Win'
        /// </summary>
        void Win()
        {
            if (car.Bounds.IntersectsWith(star1.Bounds) || collectedstars == 20)
            {
                star1.Location = new Point(a, 0);
                star1.Top -= 200;
                life += 1;
                //life_index();
                RoadMover.Enabled = false;
                win.Visible = true;
            }

            if (car.Bounds.IntersectsWith(star2.Bounds) || collectedstars == 20)
            {
                star2.Location = new Point(a, 0);
                star2.Top -= 200;
                life += 1;
                //life_index();
                RoadMover.Enabled = false;
                win.Visible = true;
            }

            if (car.Bounds.IntersectsWith(star3.Bounds) || collectedstars == 20)
            {
                star3.Location = new Point(a, 0);
                star3.Top -= 200;
                life += 1;
                //life_index();
                RoadMover.Enabled = false;
                win.Visible = true;
            }

            if (car.Bounds.IntersectsWith(star4.Bounds) || collectedstars == 20)
            {
                star4.Location = new Point(a, 0);
                star4.Top -= 200;
                life += 1;
                //life_index();
                RoadMover.Enabled = false;
                win.Visible = true;
            }

            if (car.Bounds.IntersectsWith(star5.Bounds) || collectedstars == 20)
            {
                star5.Location = new Point(a, 0);
                star5.Top -= 200;
                life += 1;
                //life_index();
                RoadMover.Enabled = false;
                win.Visible = true;
            }
        }
        
        /// <summary>
        /// how to move the safari car within the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left>0)
                {
                    car.Left += -6;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                if (car.Right<350)
                {
                    car.Left += 6;
                }
            }

            if (e.KeyCode==Keys.Up)
            {
                if (gamespeed < 20)
                {
                    gamespeed++;
                }
            }

            if (e.KeyCode==Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                }
            }
        }
    }
}
