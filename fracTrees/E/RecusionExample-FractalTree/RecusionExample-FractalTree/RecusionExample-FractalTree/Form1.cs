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

namespace RecusionExample_FractalTree
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.LightCyan, 1);
            WindowState = FormWindowState.Maximized;
            //this.BackColor = Color.Black;
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            SimpleTree(e);
        }

        private void SimpleTree(PaintEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                float len = rnd.Next(50,300);
                e.Graphics.TranslateTransform(rnd.Next(0, this.Width), this.Height);
                Branch(e, len, Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255)));
                e.Graphics.ResetTransform();
            }
        }

        private void Branch(PaintEventArgs e, float len, Color treeColor)

        {
            float theata;
            Pen pen = new Pen(Brushes.LimeGreen);
            pen.Color = treeColor;
            //pen.Color = Color.FromArgb(255,rnd.Next(255), rnd.Next(255), rnd.Next(255));
            pen.Width = len * 1 / 20;
            GraphicsState graphicsState;
            e.Graphics.DrawLine(pen, 0, 0, 0, -len);
            pen.Width = pen.Width * 0.66F;
            e.Graphics.TranslateTransform(0, -len);
            len = len * 0.66F;
            if (len > 2.0F)
            {

                graphicsState = e.Graphics.Save();
                theata = rnd.Next(0, 60);
                e.Graphics.RotateTransform(theata);
                Branch(e, len, treeColor);
                e.Graphics.Restore(graphicsState);
                graphicsState = e.Graphics.Save();
                theata = rnd.Next(10, 60);
                e.Graphics.RotateTransform(-theata);
                Branch(e, len, treeColor);
                e.Graphics.Restore(graphicsState);

            }
        }
    }
}
