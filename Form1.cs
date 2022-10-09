using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3sem_1lr_kg
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 500;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // каждые 30 миллисекунд
            int count = 0;
            int max = 1000;
            Graphics g = this.CreateGraphics();
            g.Clear(Color.SkyBlue);
            int x = 10;
            int y = 10;
            //g.DrawEllipse(Pens.Yellow, x, y, 100, 100);
            timer.Tick += new EventHandler((o, ev) =>
            {
                x += 5;
                y += 5;
                g.Clear(Color.SkyBlue);
                g.FillEllipse(Brushes.Yellow, x, y, 100, 100);
                count++;
                DoubleBuffered = true;
                if (count == max)
                {
                    Timer t = o as Timer; // можно тут просто воспользоваться timer
                    t.Stop();
                }
                
            });
            timer.Start();   // запустили, а остановится он сам  
            

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = CreateGraphics();
            g.Clear(Color.LightSkyBlue);
            // g.DrawEllipse(Pens.Red, 100, 100, 300, 200);
            // g.DrawRectangle(Pens.Red, 100, 100, 300, 200);
            // g.DrawLine(Pens.Red, 100, 100, 300, 300);
            /*Pen myPen = new Pen(Color.Black, 3);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            e.Graphics.DrawEllipse(myPen, 20, 30, 30, 20);
            e.Graphics.DrawEllipse(myPen, 15, 40, 25, 15);
            e.Graphics.DrawEllipse(myPen, 10, 50, 20, 10);
            e.Graphics.FillEllipse(whiteBrush, 11, 51, 17, 7);
            e.Graphics.FillEllipse(whiteBrush, 16, 41, 22, 12);
            e.Graphics.FillEllipse(whiteBrush, 21, 31, 27, 17);*/


            //земля и солнце
            g.FillRectangle(Brushes.Green, 0, 350, 800, 120);
            g.FillEllipse(Brushes.Yellow, 50, 50, 50, 50);

            Point house_1 = new Point(200, 380);
            Point house_2 = new Point(600, 380);
            Point house_3 = new Point(600, 200);
            Point house_4 = new Point(200, 200);
            Point[] house ={
                house_1, house_2, house_3, house_4
            };
            g.FillPolygon(Brushes.BurlyWood, house);
            g.DrawPolygon(Pens.DarkRed, house);

            Point roof_1 = new Point(150, 200);
            Point roof_2 = new Point(400, 100);
            Point roof_3 = new Point(650, 200);
            Point[] roof ={
                roof_1, roof_2, roof_3
            };
            g.FillPolygon(Brushes.DarkRed, roof);

            Point door_1 = new Point(250, 380);
            Point door_2 = new Point(250, 270);
            Point door_3 = new Point(310, 270);
            Point door_4 = new Point(310, 380);
            Point[] door ={
                door_1, door_2, door_3, door_4
            };
            g.FillPolygon(Brushes.Brown, door);

            //ручка двери
            g.FillEllipse(Brushes.Black, 290, 325, 13, 13);
            
            // окно
            Point window_1 = new Point(400, 250); //x1y1
            Point window_2 = new Point(550, 250); //x2y2
            Point window_3 = new Point(550, 330); // x3y3
            Point window_4 = new Point(400, 330); //x4y4
            Point[] window =
            {
                window_1,
                window_2,
                window_3,
                window_4
            };
            g.FillPolygon(Brushes.LightSteelBlue, window);
            g.DrawPolygon(Pens.DarkSlateBlue, window);

            timer1.Enabled = true;
            }
    }
}
