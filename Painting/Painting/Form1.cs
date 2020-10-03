using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painting
{
    enum Action
    {
        Rect,
        Circle,
        Move,
        Vagon,
        None
    }
    public partial class Form1 : Form
    {
        Graphics graphics;
        Draw draw,MoveItem;
        List<Draw> Figure = new List<Draw>();
        Action action = Action.None;
        private int StartX, StartY;
        private bool IsClicked;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = panel1.CreateGraphics();
        }

        private void CreatCirclBtn_Click(object sender, EventArgs e)
        {
            draw = new MyCircle(0, 0, 0, 0);
            action = Action.Circle;
            CirPanel.Visible = true;
            RecPanel.Visible = false;
        }
        private void CreatRecBtn_Click(object sender, EventArgs e)
        {
            draw = new MyRectangle(0, 0, 0, 0);
            action = Action.Rect;
            RecPanel.Visible = true; 
            CirPanel.Visible = false;
        }

        private void ParametersBtn_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case Action.Circle:
                    draw.Heigth = Convert.ToInt32(SizeBox.Text);
                    draw.Width = Convert.ToInt32(SizeBox.Text);
                    break;
                case Action.Rect:
                    draw.Width = Convert.ToInt32(WidthBox.Text);
                    draw.Heigth = Convert.ToInt32(HeigthBox.Text);
                    break;
            }

        }


        private void MoveBtn_Click(object sender, EventArgs e)
        {
            action = Action.Move;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Draw item in Figure)
            {
                item.Drawer(graphics);
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            switch(action)
            {
                case Action.Circle:
                    draw = new MyCircle(e.X, e.Y, draw.Heigth, draw.Width);
                    draw.Drawer(graphics);
                    Figure.Add(draw);
                    break;
                case Action.Rect:
                    draw = new MyRectangle(e.X, e.Y, draw.Heigth, draw.Width);
                    draw.Drawer(graphics);
                    Figure.Add(draw);
                    break;
                case Action.Move:
                    break;
                case Action.Vagon:
                    draw = new MyWagon(e.X, e.Y, 150);
                    draw.Drawer(graphics);
                    Figure.Add(draw);
                    break;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Draw item in Figure)
            {
                if (item.IsPointInside(e.X, e.Y) == true && action == Action.Move)
                {
                    IsClicked = true;
                    StartX = e.X - item.X;
                    StartY = e.Y - item.Y;
                    MoveItem = item;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            action = Action.Vagon;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            IsClicked = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked && action == Action.Move)
            {
                MoveItem.Move(StartX,StartY,e.X, e.Y);
                panel1.Invalidate();
            }
        }
    }
}
