using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.IO;
using log4net;
using System.Reflection;
using System.Drawing.Imaging;

namespace WFSC101trial
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap buf;
        int aniCountCli = 0, aniCountMo = 0, aniCountId = 0, aniCountMaxCli = 3, aniCountMaxIdMo = 11;
        static ILog Log = LogManager.GetLogger("Log");
        int ScreenWidth = 0, ScreenHeight = 0, pointX = 0, pointY = 0, pX = 0, pY = 0;
        
        public enum MotionTypes {idle, move, climb};
        public MotionTypes mType;
        Random random;
        bool captured = false;//Захвачена ли мышь
        Point Pos = Control.MousePosition;
        bool right = false, capFirst = true;
        int climbing = 0;
        public Form1()
        {
            InitializeComponent();
            buf = new Bitmap(smImageCont.Width, smImageCont.Height);//Определение буфера
            g = Graphics.FromImage(buf);//Определение графики из буфера
            ScreenWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            ScreenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            this.BackColor = Color.LimeGreen;//for transparent bg
            this.TransparencyKey = Color.LimeGreen;//transparent bg
            timer1 = new System.Windows.Forms.Timer();
            timer2 = new System.Windows.Forms.Timer();
            timer3 = new System.Windows.Forms.Timer();
            random = new Random(DateTime.Now.Millisecond);
            this.Location = new Point(0, 0);
            KeyUp += Esc_KeyUp;
            


        }
        private void Esc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Application.Exit();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (mType == MotionTypes.climb) 
            {
                climbing++;
                if (climbing > 5)
                {
                    climbing = 0;
                    mType = MotionTypes.move;
                }
            }
            if (this.Location.X == pointX && this.Location.Y != pointY) mType = MotionTypes.climb;
            if (!captured) capFirst = true;
            if((this.Location.X==pointX && this.Location.Y == pointY) || (captured && capFirst))
            {
                if (captured)
                {
                    capFirst = false;
                }
                int t = random.Next(1, ScreenWidth - smImageCont.Image.Width) / 10;
                pointX = t * 10;
                t = random.Next(1, ScreenHeight - smImageCont.Image.Height) / 10;
                pointY = t * 10;
                
            }
            if ((this.Location.X != pointX || this.Location.Y != pointY) && mType == MotionTypes.idle && !captured) mType = MotionTypes.move;
            
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!captured)
            {
                if (mType == MotionTypes.move && pX != pointX && pX >= 0 && pY >= 0 && pX < ScreenWidth - smImageCont.Image.Width && pY < ScreenHeight - smImageCont.Image.Height)
                {

                    pX += 10 * (pointX - pX) / Math.Abs(pointX - pX);
                    this.Location = new Point(pX, pY);
                }
                if (mType == MotionTypes.climb && pX == pointX && pY != pointY && pX >= 0 && pY >= 0 && pX < ScreenWidth - smImageCont.Image.Width && pY < ScreenHeight - smImageCont.Image.Height)
                {
                    pY += 10 * (pointY - pY) / Math.Abs(pointY - pY);
                    this.Location = new Point(pX, pY);
                }
                if (pX >= ScreenWidth - smImageCont.Image.Width) 
                {
                    pX -= 20;
                    
                    this.Location = new Point(pX, pY);
                    pointX = 0;
                    pointY = 0;
                }
                if(pY >= ScreenHeight - smImageCont.Image.Height)
                {
                    pY -= 20;
                    this.Location = new Point(pX, pY);
                    pointX = 0;
                    pointY = 0;
                }
                if (pX < 0)
                {
                    pX += 20;
                    this.Location = new Point(pX, pY);
                    pointX = 0;
                    pointY = 0;
                }
                if(pY < 0)
                {
                    pY += 20;
                    this.Location = new Point(pX, pY);
                    pointX = 0;
                    pointY = 0;
                }
            }
            //if (mType == MotionTypes.idle) imageList1.Draw
            
            if (((mType == MotionTypes.move || mType == MotionTypes.climb) && pX == pointX && pY == pointY && pX!=0 && pY!=0)|| captured)
            {
                this.Location = new Point(pX, pY);
                mType = MotionTypes.idle;
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (mType == MotionTypes.idle)
            {
                if (aniCountId < aniCountMaxIdMo)
                {
                    if (!right)
                    {
                        smImageCont.Image = idleImList.Images[aniCountId];
                        smImageCont.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        aniCountId++;
                    }
                    else
                    {
                        smImageCont.Image = idleImList.Images[aniCountId];
                        aniCountId++;
                    }
                }
                else
                {
                    aniCountId = 0;
                }
            }
            if (mType == MotionTypes.climb)
            {
                if (aniCountCli < aniCountMaxCli)
                {
                    if (!right)
                    {
                        smImageCont.Image = climbImList.Images[aniCountCli];
                        smImageCont.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        aniCountCli++;
                    }
                    else
                    {
                        smImageCont.Image = climbImList.Images[aniCountCli];
                        aniCountCli++;
                    }
                }
                else
                {
                    aniCountCli = 0;
                }
            }
            if (mType == MotionTypes.move)
            {
                if (this.Location.X < pointX && !right)
                {
                    right = true;
                }
                if (this.Location.X > pointX && right)
                {
                    right = false;
                }
                if (aniCountMo< aniCountMaxIdMo)
                {
                    if (!right)
                    {
                        smImageCont.Image = moveImList.Images[aniCountMo];
                        smImageCont.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        aniCountMo++;
                    }
                    else
                    {
                        smImageCont.Image = moveImList.Images[aniCountMo];
                        aniCountMo++;
                    }
                }
                else
                {
                    aniCountMo = 0;
                }

            }
            


        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void smImageCont_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
                captured = true;
            else
            {
                captured = false;
            }
                

            if (captured)
            {
                Pos.Offset(e.X - 30, e.Y - 30);
                int t = Convert.ToInt32(Pos.X) / 10;
                pX = t * 10;
                t = Convert.ToInt32(Pos.Y)/10;
                pY = t * 10;
                this.Location = new Point(pX, pY);
            }
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //smImageCont.Image=
        }
       
    }
}
