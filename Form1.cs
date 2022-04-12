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
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //answer button soccer ball
            string answer = textBox1.Text.ToLower();
            if (answer == "qatar")
            {
                button1.BackgroundImage = Properties.Resources._16488348581803__1_;
            }
            // germany
            else if (answer == "germany")
            {
                button4.BackgroundImage = Properties.Resources.germ__1_;
            }
            //denmark
            else if (answer == "denmark")
            {
                button6.BackgroundImage = Properties.Resources.denmark;
            }
            //brazil
            else if (answer == "brazil")
            {
                button8.BackgroundImage = Properties.Resources.bra;
            }
            //france
            else if (answer == "france")
            {
                button9.BackgroundImage = Properties.Resources.fra;
            }
            //belgium
            else if (answer == "belgium")
            {
                button2.BackgroundImage = Properties.Resources.belgium;
            }
            //croatia
            else if (answer == "croatia")
            {
                button3.BackgroundImage = Properties.Resources.croatia;
            }
            //spain
            else if (answer == "spain")
            {
                button5.BackgroundImage = Properties.Resources.spain;
            }
            //serbia
            else if (answer == "serbia")
            {
                button7.BackgroundImage = Properties.Resources.denmark;
            }
            //eng
            else if (answer == "england")
            {
                button10.BackgroundImage = Properties.Resources.eng;
            }
        }
    }
}

