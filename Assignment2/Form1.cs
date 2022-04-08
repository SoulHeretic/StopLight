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
        public class TrafficLight
        {
            public void changeLights(PictureBox pictureBox1, PictureBox pictureBox2, PictureBox pictureBox3, string color)
            {
                if(color == "green")
                {
                    pictureBox1.BackColor = Color.Green;
                    pictureBox2.BackColor = Color.Gray;
                    pictureBox3.BackColor = Color.Gray;
                }
                if (color == "yellow")
                {
                    pictureBox1.BackColor = Color.Gray;
                    pictureBox2.BackColor = Color.Yellow;
                    pictureBox3.BackColor = Color.Gray;
                }
                if (color == "red")
                {
                    pictureBox1.BackColor = Color.Gray;
                    pictureBox2.BackColor = Color.Gray;
                    pictureBox3.BackColor = Color.Red;
                }
            }
        }

        public class controller    //Let class controller inherit Form1 which will allow form objects to be modified.
                                    //Alternative way is to pass form object form , and int time into class method.
        {
            private Form1 MainForm;
            public void UpdateLights(int time, Form1 form, PictureBox pictureBox1, PictureBox pictureBox2, PictureBox pictureBox3,
                                                 PictureBox pictureBox4, PictureBox pictureBox5, PictureBox pictureBox6,
                                                 PictureBox pictureBox7, PictureBox pictureBox8, PictureBox pictureBox9,
                                                 PictureBox pictureBox10, PictureBox pictureBox11, PictureBox pictureBox12,
                                                 TrafficLight North, TrafficLight South, TrafficLight West, TrafficLight East) 
            {
                MainForm = form;
                if(time == 1)
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
                }
                if (time == 3)
                {
                    Console.WriteLine("Elapsed time = {0}, Green, Red, Red, Red", time);
                }
                if (time == 6)
                {
                    Console.WriteLine("Elapsed time = {0}, Green, Green, Red, Red", time);
                    South.changeLights(pictureBox8, pictureBox4, pictureBox2,"green");
                }
                if (time == 9)
                {
                    Console.WriteLine("Elapsed time = {0}, Yello, Green, Red, Red", time);
                    North.changeLights(pictureBox7, pictureBox6, pictureBox3,"yellow");
                }
                if (time == 12)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Green, Red, Red", time);
                    North.changeLights(pictureBox7, pictureBox6, pictureBox3, "red");
                }
                if (time == 15)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Yellow, Red, Red", time);
                    South.changeLights(pictureBox8, pictureBox4, pictureBox2, "yellow");
                }
                if (time == 18)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Yellow, Red, Red", time);

                }
                if (time == 24)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Green, Green", time);
                    West.changeLights(pictureBox9, pictureBox5, pictureBox1, "green");
                    East.changeLights(pictureBox12, pictureBox11, pictureBox10, "green");
                    South.changeLights(pictureBox8, pictureBox4, pictureBox2, "red");
                }
                if (time == 27)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Yellow, Green", time);
                    West.changeLights(pictureBox9, pictureBox5, pictureBox1, "yellow");
                }
                if (time == 30)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Red, Green", time);
                    West.changeLights(pictureBox9, pictureBox5, pictureBox1, "red");
                }
                if (time == 33)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Red, Yellow", time);
                    East.changeLights(pictureBox9, pictureBox5, pictureBox1, "yellow");
                }
                if (time == 36)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Red, Red", time);
                    East.changeLights(pictureBox9, pictureBox5, pictureBox1, "red");
                }
                if (time == 39)
                {
                    Console.WriteLine("Elapsed time = {0}, Green, Red, Red, Red", time);
                    North.changeLights(pictureBox9, pictureBox5, pictureBox1, "green");
                }
                if (time == 40)
                {
                    Console.WriteLine("Emergency Vehicle coming");
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Green, Red", time);
                    West.changeLights(pictureBox9, pictureBox5, pictureBox1, "green");
                }
                if (time == 50)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Green, Red", time);
                }
                if (time == 53)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Green, Green", time);
                }
                if (time == 56)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Green, Green", time);
                    pictureBox12.BackColor = Color.Green;
                }
                if (time == 59)
                {
                    Console.WriteLine("Elapsed time = {0}, Red, Red, Yellow, Green", time);
                    West.changeLights(pictureBox9, pictureBox5, pictureBox1, "yellow");
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
                }
            }
        }
        public Form1()
        {
            InitializeComponent();

            Text = "Assignment 2";
            ClientSize = new Size(2000, 2000);
            CenterToScreen();
        }

        async private void Form1_Load(object sender, EventArgs e)
        {
            TrafficLight North = new TrafficLight();
            TrafficLight South = new TrafficLight();
            TrafficLight East = new TrafficLight();
            TrafficLight West = new TrafficLight();
            
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("Time, North, South, West, East");
            controller main = new controller();
            while (true)
            {
                await Task.Delay(1000);
                TimeSpan ts = stopWatch.Elapsed;
                label2.Text = ts.Seconds.ToString();
                int time = ts.Seconds;

                main.UpdateLights(time, this, pictureBox1, pictureBox2, pictureBox3,
                                                 pictureBox4, pictureBox5, pictureBox6,
                                                 pictureBox7, pictureBox8, pictureBox9,
                                                 pictureBox10, pictureBox11, pictureBox12, North, South, West, East);
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
