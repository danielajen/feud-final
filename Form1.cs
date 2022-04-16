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
                button1.BackgroundImage = Properties.Resources._16488348581803__1_;
                button1.Text = "";
                label6.Text = score.ToString();
                MessageBox.Show("Great Job! You gained 100 points");
                textBox1.Clear();

            }
            // germany
            else if (answer == "germany")
            {
                button4.BackgroundImage = Properties.Resources.germ__1_;
                button4.Text = "";
                label6.Text = score.ToString();
                MessageBox.Show("Great Job! You gained 100 points");
                textBox1.Clear();

            }
            //denmark
            else if (answer == "denmark")
            {
                button6.BackgroundImage = Properties.Resources.denmark;
                button6.Text = "";
                label6.Text = score.ToString();
                MessageBox.Show("Great Job! You gained 100 points");
                textBox1.Clear();
            }
            //brazil
            else if (answer == "brazil")
            {
                button8.BackgroundImage = Properties.Resources.bra;
                button8.Text = "";
                label6.Text = score.ToString();
                MessageBox.Show("Great Job! You gained 100 points");
                textBox1.Clear();
            }
            //france
            else if (answer == "france")
            {
                button9.BackgroundImage = Properties.Resources.fra;
                button9.Text = "";
                label6.Text = score.ToString();
                MessageBox.Show("Great Job! You gained 100 points");
                textBox1.Clear();
            }
            //belgium
            else if (answer == "belgium")
            {
                button2.BackgroundImage = Properties.Resources.belgium;
                button2.Text = "";
                label6.Text = score.ToString();
                MessageBox.Show("Great Job! You gained 100 points");
                textBox1.Clear();
            }
            //croatia
            else if (answer == "croatia")
            {
                button3.BackgroundImage = Properties.Resources.croatia;
                button3.Text = "";
                label6.Text = score.ToString();
                MessageBox.Show("Great Job! You gained 100 points");
                textBox1.Clear();
            }
            //spain
            else if (answer == "spain")
            {
                button5.BackgroundImage = Properties.Resources.spain;
                button5.Text = "";
                label6.Text = score.ToString();
                MessageBox.Show("Great Job! You gained 100 points");
                textBox1.Clear();
            }
            //serbia
            else if (answer == "serbia")
            {
                button7.BackgroundImage = Properties.Resources._16488348581803__2___2_;
                button7.Text = "";
                label6.Text = score.ToString();
                MessageBox.Show("Great Job! You gained 100 points");
                textBox1.Clear();
            }
            //eng
            else if (answer == "england")
            {
                button10.BackgroundImage = Properties.Resources.eng;
                button10.Text = "";
                label6.Text = score.ToString();
                MessageBox.Show("Great Job! You gained 100 points");
                textBox1.Clear();
            }
            if (!(answer == "england" || answer == "belgium" || answer == "germany" || answer == "qatar" || answer == "denmark" || answer == "belgium" || answer == "brazil" || answer == "france" || answer == "serbia" || answer == "spain" || answer == "croatia" || lives == 2))
            {
                lives = lives - 1;
                pictureBox5.Visible = true;
                MessageBox.Show("Incorrect. One X! If you get two more you lose!");
                textBox1.Clear();
            }
            else if(!(answer == "england" || answer == "belgium" || answer == "germany" || answer == "qatar" || answer == "denmark" || answer == "belgium" || answer == "brazil" || answer == "france" || answer == "serbia" || answer == "spain" || answer == "croatia" || lives == 1))
            {
                lives = lives - 1;
                pictureBox6.Visible = true;
                MessageBox.Show("Incorrect. Two X! If you get one more you lose!");
                textBox1.Clear();
            }
            else if(!(answer == "england" || answer == "belgium" || answer == "germany" || answer == "qatar" || answer == "denmark" || answer == "belgium" || answer == "brazil" || answer == "france" || answer == "serbia" || answer == "spain" || answer == "croatia" || lives <= 0))
            {
                lives = lives - 1;
                pictureBox7.Visible = true;
                MessageBox.Show("Incorrect. You lose! No Free World Cup Tickets or first class flights for you pal. Try again next time!");
                this.Close();
            }
            if (score >= 1000)
            {
                MessageBox.Show("Great Job! You won the game! You got all the questions right and will recieve 10 free tickets to all the World Cup Games in Qatar this December! You will also recieve first class plane tickets to & from Qatar. Thank you for playing Family Feud World Cup Edition! See you soon");
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
            }
            else if (lives == 1)
            {
                pictureBox6.Visible = true;
                MessageBox.Show("HAHA! TWO X's! ONE MORE AND YOU LOSE!");
            }
             else if (lives <= 0)
            {
                pictureBox7.Visible = true;
                MessageBox.Show("You lost. Three X's is a loss. Try again next time! Unfortunately you lost so no free World Cup Tickets for you lol.");
                this.Close();
            }
            }
        }
    }

