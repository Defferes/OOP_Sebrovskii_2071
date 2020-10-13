using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painting
{
    class MyWagonCoal : MyWagon
    {
        MyRectangle Body;
        MyCircle Wheel_1, Wheel_2;
        Rectangle rect;
        private int l, width, heigth, x, y;
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
        public override int L
        {
            get
            {
                return l;
            }
            set
            {
                l = value;
            }
        }
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
        public MyWagonCoal(int x, int y, int l) : base(x, y, l)
        {
            L = l;
            heigth = l / 2;
            width = l;
            Body = new MyRectangle(x, y, heigth, width);
            Wheel_1 = new MyCircle(x - width / 4, y + heigth / 2 + (width / 5) / 2 + 2, width / 5, width / 5);
            Wheel_2 = new MyCircle(x + width / 4, y + heigth / 2 + (width / 5) / 2 + 2, width / 5, width / 5);
            rect = new Rectangle(x - width / 2, y - heigth, width, 3 * heigth / 6);
        }
        public override void Drawer(Graphics graphics)
        {
            base.Drawer(graphics);
            graphics.FillRectangle(new SolidBrush(Color.Black), rect);
        }
        public override void Move(int StartX, int StartY, int eX, int eY)
        {
            base.Move(StartX, StartY, eX, eY);
            rect.X = eX - x - width / 2;
            rect.Y = eY - y - heigth;
        }
        public override bool IsPointInside(int Ex, int Ey)
        {
            return base.IsPointInside(Ex, Ey);
        }
    }
}

