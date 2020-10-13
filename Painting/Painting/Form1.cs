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
        Train,
        None
    }
    public partial class Form1 : Form
    {
        Graphics graphics;
        Draw draw,MoveItem;
        List<Draw> Figure = new List<Draw>();
        Action action = Action.None;
        private int StartX, StartY,height,width,l, length;
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
            WagonPanel.Visible = false;
            TrainPanel.Visible = false;
        }
        private void CreatRecBtn_Click(object sender, EventArgs e)
        {
            draw = new MyRectangle(0, 0, 0, 0);
            action = Action.Rect;
            RecPanel.Visible = true; 
            CirPanel.Visible = false;
            WagonPanel.Visible = false;
            TrainPanel.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            draw = new MyTrain(0, 0, 0, 0);
            action = Action.Train;
            TrainPanel.Visible = true;
            WagonPanel.Visible = false;
            CirPanel.Visible = false;
            RecPanel.Visible = false;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            switch (action)
            {
                case Action.Circle:
                    if (Int32.TryParse(SizeBox.Text, out height))
                    {
                        draw.Heigth = height;
                        draw.Width = height;
                        draw = new MyCircle(e.X, e.Y, draw.Heigth, draw.Width);
                        draw.Drawer(graphics);
                        Figure.Add(draw);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Неверные значения");
                        break;
                    }

                case Action.Rect:
                    if (Int32.TryParse(HeigthBox.Text, out height) && Int32.TryParse(WidthBox.Text, out width))
                    {
                        draw.Width = width;
                        draw.Heigth = height;
                        draw = new MyRectangle(e.X, e.Y, draw.Heigth, draw.Width);
                        draw.Drawer(graphics);
                        Figure.Add(draw);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Неверные значения");
                        break;
                    }
            
                case Action.Move:
                    break;
                case Action.Vagon:
                    if (Int32.TryParse(SizeWagonBox.Text, out l))
                    {
                        draw = new MyWagon(e.X, e.Y, l);
                        draw.Drawer(graphics);
                        Figure.Add(draw);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Неверные значения");
                        break;
                    }
                case Action.Train:
                    if ((Int32.TryParse(SizeTrainBox.Text, out l)) && (Int32.TryParse(LengthTrainBox.Text, out length)))
                        {
                        draw.L = l;
                        draw.Length = length;
                        draw = new MyTrain(e.X, e.Y, l, length);
                        draw.Drawer(graphics);
                        Figure.Add(draw);
                        CargoSumBox.Text = Convert.ToString(draw.CargoSum());
                        break;
                    }

                    else
                    {
                        MessageBox.Show("Неверные значения");
                        break;
                    }

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

        private void WagonCreatBtn_Click(object sender, EventArgs e)
        {
            draw = new MyWagon(0, 0, 0);
            action = Action.Vagon;
            WagonPanel.Visible = true;
            CirPanel.Visible = false; 
            RecPanel.Visible = false;
            TrainPanel.Visible = false;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if(action == Action.Move)
            {
                IsClicked = false;
            }

            
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
