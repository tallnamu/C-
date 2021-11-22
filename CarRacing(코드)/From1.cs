using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CarRacing
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }

      
        
        int carSpeed = 0;
        int collectedcoin = 0;

        void coinsCollection()
        {
            if (pictureBox_Car.Bounds.IntersectsWith(pictureBox_money1.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins" + collectedcoin.ToString();

                x = r.Next(0, 200);
                pictureBox_money1.Location = new Point(x, 0);
            }
            else if (pictureBox_Car.Bounds.IntersectsWith(pictureBox_money2.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins" + collectedcoin.ToString();

                x = r.Next(100, 300);
                pictureBox_money2.Location = new Point(x, 0);
            }
            else if (pictureBox_Car.Bounds.IntersectsWith(pictureBox_money3.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins" + collectedcoin.ToString();

                x = r.Next(200, 400);
                pictureBox_money3.Location = new Point(x, 0);
            }
        }
        void gameover()
        {
            label_gameOver.Visible = false;
            if (pictureBox_Car.Bounds.IntersectsWith(pictureBox_redCar.Bounds))
            {

                timer1.Enabled = false;
                label_gameOver.Visible = true;

            }

            if (pictureBox_Car.Bounds.IntersectsWith(pictureBox_WhiteCar.Bounds))
            {
                timer1.Enabled = false;
                label_gameOver.Visible = true;

            }
        }


        void coins(int speed)
        {
            if (pictureBox_money1.Top >= 500)
            {
                x = r.Next(0, 200);
                pictureBox_money1.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_money1.Top += speed;
            }

            if (pictureBox_money2.Top >= 500)
            {
                x = r.Next(100, 300);
                pictureBox_money2.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_money2.Top += speed;
            }
            if (pictureBox_money3.Top >= 500)
            {
                x = r.Next(200, 400);
                pictureBox_money3.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_money3.Top += speed;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //moveline(5);
            moveline(carSpeed);
            redCar(carSpeed);
            WhiteCar(carSpeed);
            gameover();
            coins(carSpeed);
            coinsCollection();
        }

        Random r = new Random();
        int x;

        void WhiteCar(int speed)
        {
            if (pictureBox_WhiteCar.Top >= 500)
            {
                x = r.Next(200, 400);
                pictureBox_WhiteCar.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_WhiteCar.Top += speed;
            }
        }
        void redCar(int speed)
        {
            if (pictureBox_redCar.Top >= 500)
            {
                x = r.Next(0, 400);
                pictureBox_redCar.Location = new Point(x,0);
            }
            else
            {
                pictureBox_redCar.Top += speed;
            }
        }

      
        void moveline(int speed)
        {
            pictureBox1.Top += speed;
            pictureBox2.Top += speed;
            pictureBox3.Top += speed;
            pictureBox4.Top += speed;



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
        }

      

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pictureBox_Car.Left > 0)
                    pictureBox_Car.Left += -5;
            }
            if (e.KeyCode == Keys.Right)
            {
                if(pictureBox_Car.Right<400-pictureBox_Car.Width/2)
                pictureBox_Car.Left += 5;
            }

            if (e.KeyCode == Keys.Up)
            {
                if(carSpeed<15)
                { carSpeed++; }
            }

            if(e.KeyCode==Keys.Down)
            {
                if(carSpeed>0)
                { carSpeed--; }
            }
        }

        
    }
}
