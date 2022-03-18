using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MatrixGridProgram
{
    public partial class Form1 : Form
    {
        public int width;
        public int height;
        public int noOfRows;
        public int noOfCols;
        public int xofSet;
        public int yofSet;
        public int counter = 2;
        public int size = 8;
        public const int DEFAULTXOFFSET = 100;
        public const int DEFAULTYOFFSET = 50;
        public const int DEFAULTNOROWS = 2;
        public const int DEFAULTNOCOLS = 2;
        public const int DEFAULTHEIGHT = 50;
        public const int DEFAULTWIDTH = 50;
        public Thread t;
        public Form1()
        {
            Initialize();
            InitializeComponent();
        }

       

        private void PaintEvent(object sender, EventArgs e)
        {
            DrawGrid();
        }
        public void Initialize()
        {
            noOfRows = DEFAULTNOROWS;

            width = DEFAULTWIDTH;
            height = DEFAULTHEIGHT;
            xofSet = DEFAULTXOFFSET;
            yofSet = DEFAULTYOFFSET;

        }
        public void DrawGrid()
        {
            //row
            Graphics layout = this.CreateGraphics();
            Pen penLayout = new Pen(Color.GreenYellow);
            penLayout.Width = 4;

            int x = DEFAULTXOFFSET;
            int y = DEFAULTYOFFSET;
            for (int i = 0; i <= counter; i++)
            {
                layout.DrawLine(penLayout, x, y, x + this.width * this.counter, y);
                y = y + height;
            }
            x = DEFAULTXOFFSET;
            y = DEFAULTYOFFSET;
            for (int j = 0; j <= counter; j++)
            {
                layout.DrawLine(penLayout, x, y, x, y + this.height * this.counter);
                x = x + this.width;
            }
        }
        public void CounterThread()
        {
            while (true)
            {
                counter++;

                if (counter > size)
                {
                    counter = 2;
                }
                Invalidate();
                Thread.Sleep(1000);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            t = new Thread(new ThreadStart(CounterThread));
            t.Start();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            size = 3;
            this.Refresh();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            size = 4;
            this.Refresh();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            size = 5;
            this.Refresh();

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            size = 6;
            this.Refresh();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            size = 7;
            this.Refresh();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            size = 8;
            this.Refresh();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            size = 9;
            this.Refresh();
        }

       
    }
}