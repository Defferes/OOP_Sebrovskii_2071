﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painting
{
    class MyWagon : Draw
    {
        MyRectangle Body;
        MyCircle Wheel_1, Wheel_2;
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
        public MyWagon(int x, int y, int l)
        {
            L = l;
            heigth = l / 2;
            width = l;
            Body = new MyRectangle(x, y, heigth, width);
            Wheel_1 = new MyCircle(x - width / 4, y + heigth / 2 + (width / 5) / 2 + 2, width / 5, width / 5);
            Wheel_2 = new MyCircle(x + width / 4, y + heigth / 2 + (width / 5) / 2 + 2, width / 5, width / 5);
        }

        public override void Drawer(Graphics graphics)
        {
            Body.Drawer(graphics);
            Wheel_1.Drawer(graphics);
            Wheel_2.Drawer(graphics);

        }
        public override void Move(int StartX, int StartY, int eX, int eY)
        {
            Body.X = eX - x;
            Body.Y = eY - y;
            Wheel_1.X = eX - x - width / 4;
            Wheel_1.Y = eY - y + heigth / 2 + (width / 5) / 2 + 2;
            Wheel_2.X = eX - x + width / 4;
            Wheel_2.Y = eY - y + heigth / 2 + (width / 5) / 2 + 2;
        }
        public override bool IsPointInside(int Ex, int Ey)
        {
            if (Body.IsPointInside(Ex, Ey))
            {
                return true;
            }
            else { return false; }
        }
    }
}