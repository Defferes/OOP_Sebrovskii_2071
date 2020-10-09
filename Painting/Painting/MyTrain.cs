using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painting
{
    class MyTrain : Draw
    {
        private int x, y, l, length;
        private MyWagon Wagon;
        private List<MyWagon> Wagons = new List<MyWagon>();
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
        public override int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public MyTrain(int x, int y, int l, int length)
        {
            L = l;
            Length = length;
            WagonsAdding(x, y);
        }
        public override void Drawer(Graphics graphics)
        {
            int cargo = 0;
            foreach (MyWagon item in Wagons)
            {
                item.Drawer(graphics);
                cargo += item.Cargo;
            }
            graphics.DrawString("Масса груза: " + Convert.ToString(cargo), new Font("Arial", 10), Brushes.Black, 10, 10);
        }
        public override void WagonsAdding(int x, int y)
        {
           Random rnd = new Random();
            for (int i = 1; i <= Length; i++)
            {
                Wagon = new MyWagon(x, y, L, rnd.Next(100));
                Wagons.Add(Wagon);
                x += (Wagon.Width + 4);
            }
        }
    }
}
