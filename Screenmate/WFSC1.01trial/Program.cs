using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WFSC101trial
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        //public static int[] GetCordinates1(int ScreenWidth, int ScreenHeight, int PointX, int PointY, int DirectionX, int DirectionY)
        //{
        //    int PointMove = 1;
        //    int ScreenOffset = 0;

        //    if (PointX == 0)
        //    {
        //        ScreenOffset = RandomNumber(10, 1500);
        //    }

        //    ScreenWidth = ScreenWidth + ScreenOffset;
        //    ScreenHeight = ScreenHeight + ScreenOffset;

        //    int[] values = new int[4];

        //    //PointX is the horizontal
        //    //PointY is the vertical

        //    if (PointX < ScreenWidth * 2)
        //    {
        //        PointX = PointX + RandomNumber(1, PointMove);
        //    }
        //    else
        //    {
        //        PointX = 0;

        //        if (DirectionX == 0)
        //        {
        //            DirectionX = 1;
        //        }
        //        else
        //        {
        //            DirectionX = 0;
        //        }

        //    }

        //    if (PointY < ScreenHeight)
        //    {
        //        PointY = PointY + RandomNumber(1, PointMove);
        //    }
        //    else
        //    {
        //        PointY = 0;

        //        if (DirectionY == 0)
        //        {
        //            DirectionY = 1;
        //        }
        //        else
        //        {
        //            DirectionY = 0;
        //        }

        //    }

        //    values[0] = PointX;
        //    values[1] = PointY;
        //    values[2] = DirectionX;
        //    values[3] = DirectionY;

        //    return values;

        //}
        public static int RandomNumber(int min, int max)
        {
            //for (int s=0; s < max; s++)
            //{
            //    if (s > prev)
            //    {
            //        prev = s;
            //        break;
            //    }
                    
            //}
            //http://www.c-sharpcorner.com/uploadfile/mahesh/randomnumber11232005010428am/randomnumber.aspx
            Random random = new Random(DateTime.Now.Millisecond);
            if (random == null) random = new Random();
            return random.Next(min, max);
        }
    }
}
