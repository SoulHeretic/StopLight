using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Assignmentt2
{


    public partial class Form1 : Form
    {
        class TrafficLight
        {
            string Direction;
        }
        public Form1()
        {
            InitializeComponent();

            Text = "Assignment 2";
            ClientSize = new Size(2000, 2000);
            CenterToScreen();
            TrafficLight North = new TrafficLight();
            TrafficLight South = new TrafficLight();
            TrafficLight East = new TrafficLight();
            TrafficLight West = new TrafficLight();

        }

        async private void Form1_Load(object sender, EventArgs e)
        {
            //North
            pictureBox7.BackColor = Color.Green;
            pictureBox6.BackColor = Color.Gray;
            pictureBox3.BackColor = Color.Gray;
            //South
            pictureBox8.BackColor = Color.Gray;
            pictureBox4.BackColor = Color.Gray;
            pictureBox2.BackColor = Color.Red;
            //West
            pictureBox9.BackColor = Color.Gray;
            pictureBox5.BackColor = Color.Gray;
            pictureBox1.BackColor = Color.Red;
            //East
            pictureBox12.BackColor = Color.Gray;
            pictureBox11.BackColor = Color.Gray;
            pictureBox10.BackColor = Color.Red;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("Time, North, South, West, East");
            while (true)
            {
                await Task.Delay(1000);
                TimeSpan ts = stopWatch.Elapsed;
                label2.Text = ts.Seconds.ToString();
                int time = ts.Seconds;

                if (time == 3)
                {
                    Console.WriteLine("Elapsed time = {0}, Green, Red, Red, Red", time);
                }
                if (time == 6)
                {
                    Console.WriteLine("Elapsed time = {0}, Green, Green, Red, Red", time);
                    pictureBox2.BackColor = Color.Gray;
                    pictureBox8.BackColor = Color.Green;
                }
                if (time == 9)
                {
                    Console.WriteLine("Elapsed time = {0}, Yello, Green, Red, Red", time);
                    pictureBox7.BackColor = Color.Gray;
                    pictureBox6.BackColor = Color.Yellow;
                }
                if (time == 12)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Green, Red, Red", time);
                    pictureBox6.BackColor = Color.Gray;
                    pictureBox3.BackColor = Color.Red;
                }
                if (time == 15)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Yellow, Red, Red", time);
                }
                if (time == 18)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Yellow, Red, Red", time);
                    pictureBox9.BackColor = Color.Green;
                    pictureBox2.BackColor = Color.Gray;
                }
                if (time == 24)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Green, Green", time);
                    pictureBox12.BackColor = Color.Green;
                }
                if (time == 27)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Yellow, Green", time);
                }
                if (time == 30)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Red, Green", time);
                    pictureBox12.BackColor = Color.Gray;
                }
                if (time == 33)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Red, Yellow", time);
                }
                if (time == 35)
                {
                    Console.WriteLine("Emergency Vehicle coming");
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Green, Red", time);
                    pictureBox8.BackColor = Color.Gray;
                }
                if (time == 45)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Green, Red", time);
                }
                if (time == 48)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Green, Green", time);
                }
                if (time == 51)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Green, Green", time);
                    pictureBox12.BackColor = Color.Green;
                }
                if (time == 54)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Yellow, Green", time);
                }
                if (time == 57)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Red, Green", time);
                }
                if (time == 60)
                {
                    //North
                    pictureBox7.BackColor = Color.Green;
                    pictureBox6.BackColor = Color.Gray;
                    pictureBox3.BackColor = Color.Gray;
                    //South
                    pictureBox8.BackColor = Color.Gray;
                    pictureBox4.BackColor = Color.Gray;
                    pictureBox2.BackColor = Color.Red;
                    //West
                    pictureBox9.BackColor = Color.Gray;
                    pictureBox5.BackColor = Color.Gray;
                    pictureBox1.BackColor = Color.Red;
                    //East
                    pictureBox12.BackColor = Color.Gray;
                    pictureBox11.BackColor = Color.Gray;
                    pictureBox10.BackColor = Color.Red;
                    stopWatch.Reset();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
        }
    }
}
