using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Painting
{
    class Draw
    {
        public virtual int X { get; set; }
        public virtual int Y { get; set; }
        public virtual int Width { get; set; }
        public virtual int Heigth { get; set; }
        public virtual int L { get; set; }

        public string Output(int x, int y)
        {
            return Convert.ToString("X - Координата " + x + ", Y - Координата " + y);
        }
        public virtual void Drawer(Graphics graphics)
        {
            
        }
        public virtual void Move(int StartX, int StartY,int eX, int eY)
        {
            X = eX - StartX;
            Y = eY - StartY;
        }

        public virtual bool IsPointInside(int Ex, int Ey)
        {
            return false;
        }

    }
}
