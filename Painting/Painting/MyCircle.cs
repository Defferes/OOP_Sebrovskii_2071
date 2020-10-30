using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painting
{
    class MyCircle : Draw
    {
        private int width,heigth;
        public override int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public override int Heigth
        {
            get
            {
                return heigth;
            }
            set
            {
                heigth = value;
            }
        }
        public override int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public override int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public MyCircle(int x,int y,int width,int heigth)
        {
            Width = width;
            Heigth = heigth;
            X = x;
            Y = y;
        }
        public override void Drawer(Graphics graphics)
        {
            graphics.DrawEllipse(new Pen(new SolidBrush(Color.Black)), X - width / 2, Y - heigth / 2, width, heigth);
        }
        public override void Move(int StartX, int StartY, int eX, int eY)
        {
            base.Move(StartX, StartY, eX, eY);
        }
        public override bool IsPointInside(int Ex, int Ey)
        {
            if(Math.Pow((Ex - this.X ),2) + Math.Pow((Ey - this.Y), 2) <= Math.Pow(width/2,2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
