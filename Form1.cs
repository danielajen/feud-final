using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feud_final
{
    public partial class Form1 : Form
    {
        int time = 60;
        int score = 0;
        int lives = 3;
        bool a1 = false, a2 = false, a3 = false, a4 = false, a5 = false, a6 = false, a7 = false, a8 = false, a9 = false, a10 = false; 
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            score = score + 100;
            //answer button soccer ball
            string answer = textBox1.Text.ToLower();
            if (answer == "qatar")
            {
                if (a1 == false)
                {
                    button1.BackgroundImage = Properties.Resources._16488348581803__1_;
                    button1.Text = "";
                    label6.Text = score.ToString();
                    MessageBox.Show("Great Job! You gained 100 points");
                    textBox1.Clear();
                    a1 = true;
                }
                else
                {
                    MessageBox.Show("You already entered this");
                    textBox1.Clear();
                    score = score - 100;
                }

            }
            // germany
            else if (answer == "germany")
            {
                if (a2 == false)
                {
                    button4.BackgroundImage = Properties.Resources.germ__1_;
                    button4.Text = "";
                    label6.Text = score.ToString();
                    MessageBox.Show("Great Job! You gained 100 points");
                    textBox1.Clear();
                    a2 = true;
                }
                else
                {
                    MessageBox.Show("You already entered this");
                    textBox1.Clear();
                    score = score - 100;
                }

            }
            //denmark
          else if (answer == "denmark")
            {
                if (a3 == false)
                {
                    button6.BackgroundImage = Properties.Resources.denmark;
                    button6.Text = "";
                    label6.Text = score.ToString();
                    MessageBox.Show("Great Job! You gained 100 points");
                    textBox1.Clear();
                    a3 = true;
                }
                else
                {
                    MessageBox.Show("You already entered this");
                    textBox1.Clear();
                    score = score - 100;
                }
            }

            //brazil
          else if (answer == "brazil")
            {
                if (a4 == false)
                {
                    button8.BackgroundImage = Properties.Resources.bra;
                    button8.Text = "";
                    label6.Text = score.ToString();
                    MessageBox.Show("Great Job! You gained 100 points");
                    textBox1.Clear();
                    a4 = true;
                }
                else
                {
                    MessageBox.Show("You already entered this");
                    textBox1.Clear();
                    score = score - 100;
                }
            }
            //france
          else if (answer == "france")
            {
                if (a5 == false)
                {
                    button9.BackgroundImage = Properties.Resources.fra;
                    button9.Text = "";
                    label6.Text = score.ToString();
                    MessageBox.Show("Great Job! You gained 100 points");
                    textBox1.Clear();
                    a5 = true;
                }
                else
                {
                    MessageBox.Show("You already entered this");
                    textBox1.Clear();
                    score = score - 100;
                }
            }
            //belgium
         else  if (answer == "belgium")
            {
                if (a6 == false)
                {
                    button2.BackgroundImage = Properties.Resources.belgium;
                    button2.Text = "";
                    label6.Text = score.ToString();
                    MessageBox.Show("Great Job! You gained 100 points");
                    textBox1.Clear();
                    a6 = true;
                }
                else
                {
                    MessageBox.Show("You already entered this");
                    textBox1.Clear();
                    score = score - 100;
                }
            }
            //croatia
         else if (answer == "croatia")
            {
                if (a7 == false)
                {
                    button3.BackgroundImage = Properties.Resources.croatia;
                    button3.Text = "";
                    label6.Text = score.ToString();
                    MessageBox.Show("Great Job! You gained 100 points");
                    textBox1.Clear();
                    a7 = true;
                }
                else
                {
                    MessageBox.Show("You already entered this");
                    textBox1.Clear();
                    score = score - 100;
                }
            }
            //spain
          else if (answer == "spain")
            {
                if (a8 == false)
                {
                    button5.BackgroundImage = Properties.Resources.spain;
                    button5.Text = "";
                    label6.Text = score.ToString();
                    MessageBox.Show("Great Job! You gained 100 points");
                    textBox1.Clear();
                    a8 = true;
                }
                else
                {
                    MessageBox.Show("You already entered this");
                    textBox1.Clear();
                    score = score - 100;
                }
            }
            //serbia
          else if (answer == "serbia")
            {
                if (a9 == false)
                {
                    button7.BackgroundImage = Properties.Resources._16488348581803__2___2_;
                    button7.Text = "";
                    label6.Text = score.ToString();
                    MessageBox.Show("Great Job! You gained 100 points");
                    textBox1.Clear();
                    a9 = true;
                }
                else
                {
                    MessageBox.Show("You already entered this");
                    textBox1.Clear();
                    score = score - 100;
                }
            }
            //eng
           else if (answer == "england")
            {
                if (a10 == false)
                {
                    button10.BackgroundImage = Properties.Resources.eng;
                    button10.Text = "";
                    label6.Text = score.ToString();
                    MessageBox.Show("Great Job! You gained 100 points");
                    textBox1.Clear();
                    a10 = true;
                }
                else
                {
                    MessageBox.Show("You already entered this");
                    textBox1.Clear();
                    score = score - 100;
                }
            }

            // incorrect answers (x)
            else
            {
                lives = lives - 1;
                if (lives == 2)
                {
                    textBox1.Clear();
                    pictureBox5.Visible = true;
                    MessageBox.Show("Incorrect. One X! If you get two more you lose!");

                }
                else if (lives == 1)
                {
                    textBox1.Clear();
                    pictureBox6.Visible = true;
                    MessageBox.Show("Incorrect. You now have Two X's! If you get one more you lose!");
                }
                else if (lives == 0)
                {
                    textBox1.Clear();
                    pictureBox7.Visible = true;
                    MessageBox.Show("Incorrect. HAHA, YOU LOST! Better Luck Next Time! You really lost the oppurtunity to go to the World Cup in Qatar for free! ");
                    this.Close();
                }
            }

            // winning the game score thing
            if (score >= 1000)
            {
                MessageBox.Show("CONGRATS, YOU WON! You just got all the questions right! You now earned yourself free first class tickets to all the World Cup Games in Qatar this November! See you soon!");
                this.Close();          
            }

            







        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void jjjj_Tick(object sender, EventArgs e)
        {
            //timerrr
            label3.Text = time.ToString();
            time--;
            if (time < 2)
            {
                pictureBox4.Image = Properties.Resources.whistle_final;
                label3.ForeColor = Color.Red;
            }
            if (time == -1)
            {
                timer1.Stop();
                MessageBox.Show("Sorry you ran out of time! Unfortunately there is no extra time and you reached the end of the game.");
                this.Close();
            }
                
       }

        private void Form1_Load(object sender, EventArgs e)
        {
            // loading the code and activates it when it starts
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //exit ting
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //no answer x's
            lives = lives - 1;
             if (lives == 2)
            {
                pictureBox5.Visible = true;
                MessageBox.Show("HAHA! One X! TWO MORE AND YOU LOSE!");
                textBox1.Clear();
            }
            else if (lives == 1)
            {
                pictureBox6.Visible = true;
                MessageBox.Show("HAHA! TWO X's! ONE MORE AND YOU LOSE!");
                textBox1.Clear();
            }
             else if (lives <= 0)
            {
                pictureBox7.Visible = true;
                MessageBox.Show("You lost. Three X's is a loss. Try again next time! Unfortunately you lost so no free World Cup Tickets for you lol.");
                this.Close();
            }
            }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
    }

