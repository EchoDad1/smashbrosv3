using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSmashBrosv3
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

        Boolean p1UpKey;
        Boolean p1DownKey;
        Boolean p1LeftKey;
        Boolean p1RightKey;

        Point p1Location;
        Point p2Location;

        int p1Jump;
        int p2Jump;

        int p1JumpVal;
        int p2JumpVal;


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.W)
            {
                p1UpKey = true;
            }

            else if (e.KeyCode == Keys.S)
            {
                p1DownKey = true;
            }

            else if (e.KeyCode == Keys.A)
            {
                p1LeftKey = true;
            }

            else if (e.KeyCode == Keys.D)
            {
                p1RightKey = true;
            }
        }



        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                p1UpKey = false;
            }

            else if (e.KeyCode == Keys.S)
            {
                p1DownKey = false;
            }

            else if (e.KeyCode == Keys.A)
            {
                p1LeftKey = false;
            }

            else if (e.KeyCode == Keys.D)
            {
                p1RightKey = false;
            }
        }

        private void jumpTimer1_Tick(object sender, EventArgs e)
        {
            p1Jumper();
        }

        private void jumpTimer2_Tick(object sender, EventArgs e)
        {
            p2Jump++;

            p2Location.Y += 20;
            p1Box.Location = p1Location;

            if (p2Jump == 10)
            {
                jumpTimer2.Enabled = false;
                p2Jump = 0;
            }
        }

        private void gravityTimer_Tick(object sender, EventArgs e)
        {
            p1Location.Y += 8;
            p1Box.Location = p1Location;
        }

        private void stageCollisionTimer_Tick(object sender, EventArgs e)
        {
            if (p1Box.Bounds.IntersectsWith(stageBoxup.Bounds))
            {
                p1Location.Y -= 5;
                p1Box.Location = p1Location;
                gravityTimer.Enabled = false;
            }

            else if (p1Box.Bounds.IntersectsWith(stageBoxLeft.Bounds))
            {
                p1Location.X -= 5;

            }

            else if (p1Box.Bounds.IntersectsWith(stageBoxRight.Bounds))
            {
                p1Location.X += 5;

            }

            else
            {
                gravityTimer.Enabled = true;
            }
        }

        private void p1LocationTimer_Tick(object sender, EventArgs e)
        {
            p1Location = new Point(p1Box.Location.X, p1Box.Location.Y);
            p1Box.Location = p1Location;

            p2Location = new Point(p2Box.Location.X, p2Box.Location.Y);
            p2Box.Location = p2Location;
        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
            if (p1UpKey == true)
            {
                jumpTimer1.Enabled = true;


                /*if (p1JumpVal < 3)
                {
                    jumpTimer1.Enabled = true;
                    p1JumpVal++;
                    testLabel.Text = p1JumpVal.ToString();
                }
                else if (p1JumpVal >= 3)
                {
                    jumpTimer1.Enabled = false;
                    p1JumpVal = 0;
                    testLabel.Text = p1JumpVal.ToString();
                    p1UpKey = false;
                }

                if (p1Jump == 0)
                {
                    p1JumpVal++;
                    jumpTimer1.Enabled = true;
                    p2Moveup = false;
                }

                else if (up69 == 1)
                {
                    up69 = 2;
                    timer5.Enabled = true;

                }
                */
            }

            else if (p1DownKey == true)
            {
                p1MoveDown();
            }

            else if (p1LeftKey == true)
            {
                p1MoveLeft();
            }

            else if (p1RightKey == true)
            {
                p1MoveRight();
            }
        }




        private void p1PunchUp()
        {

        }

        private void p1PunchDown()
        {

        }

        private void p1PunchLeft()
        {

        }

        private void p1PunchRight()
        {

        }


        private void p1Jumper()
        {
            p1Jump++;

            p1Location.Y -= 20;
            p1Box.Location = p1Location;

            if (p1Jump >= 10)
            {
                jumpTimer1.Enabled = false;
                p1Jump = 0;
            }
        }

        private void p1MoveLeft()
        {
            
            p1Location.X -= 5;
            p1Box.Location = p1Location;
        }

        private void p1MoveRight()
        {
            p1Location.X += 5;
            p1Box.Location = p1Location;
        }

        private void p1MoveDown()
        {
            p1Location.Y += 5;
            p1Box.Location = p1Location;
        }
    }
}
