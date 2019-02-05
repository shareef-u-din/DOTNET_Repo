using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DhruvBday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //lblText.BeginInvoke(delegate()
            //{
            //    backgroundWorke();
            //});
            string txt = "VERY VERY HAPPY BIRTHDAY DHRUV GOSAIN";
            lblText.Text = txt;
            axWindowsMediaPlayer1.URL = @"D:\VISUAL_STUDIO_PROGRAMS\DhruvBday\DhruvBday\DhruvBirthday.mp3";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void lblText_Click(object sender, EventArgs e)
        {


        }

        private void backgroundWorke()
        {
            Color[] colorSet = { Color.Red, Color.Blue, Color.Green, Color.Yellow };
            try
            {
                string txt = "VERY VERY HAPPY BIRTHDAY DHRUV GOSAIN";
                int i = 0;
                while (true)
                {
                    lblText.Text = txt;
                    if (i == 4)
                        i = 0;
                    lblText.ForeColor = colorSet[i];
                    Thread.Sleep(1000);
                    i++;
                }
            }
            catch (Exception ex)
            {
                // log errors
            }
        }
    }
}
