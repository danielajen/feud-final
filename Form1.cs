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
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            score = score + 10;
            //answer button soccer ball
            string answer = textBox1.Text.ToLower();
            if (answer == "qatar")
            {
                button1.BackgroundImage = Properties.Resources._16488348581803__1_;
                button1.Text = "";
                label6.Text = score.ToString();
            }
            // germany
            else if (answer == "germany")
            {
                button4.BackgroundImage = Properties.Resources.germ__1_;
                button4.Text = "";
                label6.Text = score.ToString();

            }
            //denmark
            else if (answer == "denmark")
            {
                button6.BackgroundImage = Properties.Resources.denmark;
                button6.Text = "";
                label6.Text = score.ToString();
            }
            //brazil
            else if (answer == "brazil")
            {
                button8.BackgroundImage = Properties.Resources.bra;
                button8.Text = "";
                label6.Text = score.ToString();
            }
            //france
            else if (answer == "france")
            {
                button9.BackgroundImage = Properties.Resources.fra;
                button9.Text = "";
                label6.Text = score.ToString();
            }
            //belgium
            else if (answer == "belgium")
            {
                button2.BackgroundImage = Properties.Resources.belgium;
                button2.Text = "";
                label6.Text = score.ToString();
            }
            //croatia
            else if (answer == "croatia")
            {
                button3.BackgroundImage = Properties.Resources.croatia;
                button3.Text = "";
                label6.Text = score.ToString();
            }
            //spain
            else if (answer == "spain")
            {
                button5.BackgroundImage = Properties.Resources.spain;
                button5.Text = "";
                label6.Text = score.ToString();
            }
            //serbia
            else if (answer == "serbia")
            {
                button7.BackgroundImage = Properties.Resources.denmark;
                button7.Text = "";
                label6.Text = score.ToString();
            }
            //eng
            else if (answer == "england")
            {
                button10.BackgroundImage = Properties.Resources.eng;
                button10.Text = "";
                label6.Text = score.ToString();
            }
            else if (answer == "canada")
            {
                MessageBox.Show("Sorry Canada was not one of the first teams to qualify");
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
            label3.Text = time.ToString();
            time--;
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

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

