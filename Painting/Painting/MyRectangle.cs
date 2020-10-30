using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painting
{
    class MyRectangle : Draw
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
        public MyRectangle(int x, int y, int heigth, int width)
        {
            Width = width;
            Heigth = heigth;
            X = x;
            Y = y;
        }
        public override void Drawer(Graphics graphics)
        {
           graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), x - width / 2, y - heigth / 2, width, heigth);
        }
        public override void Move(int StartX, int StartY, int eX, int eY)
        {
            base.Move(StartX, StartY, eX, eY);
        }
        public override bool IsPointInside(int Ex, int Ey)
        {
            if ((Ex > this.x - width / 2) && (Ex < this.x + width / 2) && (Ey > this.y - heigth / 2) && (Ey < this.y + heigth / 2))
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
