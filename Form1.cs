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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3sem_1lr_kg
{

    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 500;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            count++;
            if (count == 1) {
                g.FillEllipse(Brushes.Yellow, 50, 50, 50, 50);
            }
            if (count == 11)
            {
                g.FillEllipse(Brushes.LightSkyBlue, 50, 50, 50, 50);
                g.FillEllipse(Brushes.Yellow, 160, 35, 50, 50);

            }
            if (count == 21)
            {
                g.FillEllipse(Brushes.LightSkyBlue, 160, 35, 50, 50);
                g.FillEllipse(Brushes.Yellow, 250, 20, 50, 50);
            }
            if (count == 31)
            {
                g.FillEllipse(Brushes.LightSkyBlue, 250, 20, 50, 50);
                g.FillEllipse(Brushes.Yellow, 350, 15, 50, 50);
            }            
            if (count == 40)
            {
                BackColor = Color.Plum;
            }
            if(count == 41)
            {
                g.FillEllipse(Brushes.Plum, 350, 15, 50, 50);
                g.FillEllipse(Brushes.Yellow, 450, 20, 50, 50);
            }
            if(count == 50)
            {
                BackColor = Color.MediumPurple;
            }
            if (count == 51)
            {
                g.FillEllipse(Brushes.MediumPurple, 450, 20, 50, 50);
                g.FillEllipse(Brushes.Yellow, 550, 35, 50, 50);
            }
            if (count == 60)
            {
                BackColor = Color.SlateBlue;
            }
            if (count == 61)
            {
                g.FillEllipse(Brushes.SlateBlue, 550, 35, 50, 50);
                g.FillEllipse(Brushes.Yellow, 650, 50, 50, 50);
            }
            if (count == 71)
            {
                BackColor = Color.DarkSlateBlue;
                g.FillEllipse(Brushes.DarkSlateBlue, 650, 50, 50, 50);
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = CreateGraphics();
            
            //земля
            g.FillRectangle(Brushes.Green, 0, 350, 800, 120);

            //дом
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

            //окно
            g.FillPolygon(Brushes.LightSteelBlue, window);
            g.DrawPolygon(Pens.DarkSlateBlue, window);
        }
    }
}
