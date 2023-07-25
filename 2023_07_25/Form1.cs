using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023_07_25
{   
    public partial class Form1 : Form
    {
        Point start;
        Point finish;
        Graphics g;
        Rectangle rectangle;
        List<Control> controlsLst = new List<Control>();

        bool MouseDown = false;
        public Form1()
        {
            InitializeComponent();
            /*var tmp = Controls.OfType<Button>().ToArray();
            string name = string.Empty;
            foreach(var item in tmp)
            {
                MessageBox.Show(((Control)item).Name);
                name += ((Control)item).Name + "\n";
            }
            MessageBox.Show(name);*/
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
            MouseDown = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            finish = e.Location;
            var size = new Size(Math.Abs((start.X - finish.X)),
                Math.Abs(start.Y - finish.Y));
            Point _start = new Point(start.X < finish.X ? start.X:finish.X, 
                start.Y < finish.Y? start.Y:finish.Y);
            Rectangle _rectangle = new Rectangle(start, size);
            this.rectangle = _rectangle;
            g = ((Form)sender).CreateGraphics();
            Brush brush = new SolidBrush(Color.Blue);
            //g.FillRectangle(brush, _rectangle);
            Pen pen = new Pen(Color.Blue, 2);
            g.DrawRectangle(pen, rectangle);
            listBox1.Items.Clear();
            string name = string.Empty;
            foreach(var item in controlsLst)
            {
                if(item is Button)
                {
                    listBox1.Items.Add(((Button)item).Text);                   
                }
            }
            //MessageBox.Show(name);
        }
        private void addButton(Point _location)
        {
            Button button = new Button();

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
             
        }
    }
}
