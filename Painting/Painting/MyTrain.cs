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
        private int l, length, cargoSum;
        private List<MyWagon> Wagons = new List<MyWagon>();
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
        public int Length
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
            foreach (MyWagon item in Wagons)
            {
                item.Drawer(graphics);
            }
        }
        public void WagonsAdding(int x, int y)
        {
            MyWagon Wagon;
            Random rndCargo = new Random();
            Random rnd = new Random();
            for (int i = 1; i <= Length; i++)
            {
                int action = rnd.Next(2);
                if ( action == 0 )
                {
                    Wagon = new MyWagonCoal(x, y, L);
                    Wagon.Cargo = rndCargo.Next(100);
                    Wagons.Add(Wagon);
                    x += (Wagon.Width + 4);
                }
                if ( action == 1 )
                {
                    Wagon = new MyWagonSand(x, y, L);
                    Wagons.Add(Wagon);
                    x += (Wagon.Width + 4);
                    Wagon.Cargo = rndCargo.Next(100);
                }
            }
        }
        public override void Move(int StartX, int StartY, int eX, int eY)
        {
            foreach (Draw item in Wagons)
            {
                if(item.IsPointInside(eX,eY))
                {
                    item.Move(StartX, StartY, eX, eY);
                    eX += item.Width + 4;
                }

            }
                
        }
        public int CargoSum()
        {
            foreach (MyWagon item in Wagons)
            {
                cargoSum += item.Cargo;
            }
            return cargoSum;
        }
        public override bool IsPointInside(int Ex, int Ey)
        {
            foreach (Draw item in Wagons)
            {
                return item.IsPointInside(Ex, Ey);
            }
            return false;
                
        }
    }
}
