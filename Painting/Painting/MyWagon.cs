using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painting
{
    class MyWagon : MyCircle
    {
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
        public int L
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
    public MyWagon(int x, int y, int width, int heigth, int l) : base(x,y,width,heigth)
    {
            L = l;
            heigth = l / 2;
            width = l;
    }

    public override void Drawer(Graphics graphics)
    {
        base.Drawer(graphics);
    }
}
}
