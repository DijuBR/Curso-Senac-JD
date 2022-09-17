using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBall
{
    public partial class Form1 : Form
    {
        private Timer t;
        public Brush brush = Brushes.Green;
        int x = 10, incX = 1;
        int y = 10, incY = 1;

        public Form1()
        {
            InitializeComponent();
        }
        private void GameLoop(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(brush, x, y, 40, 40);

            x = x + incX;
            y = y + incY;

            if (x > this.ClientRectangle.Width - 40)
            {
                brush = Brushes.Red;
                incX = -1;
            }
            if (y > this.ClientRectangle.Height - 40)
            {
                brush = Brushes.Red;
                incY = -1;
                
            }
            if (y < 0)
            {
                brush = Brushes.Red;
                incY = 1;
            }
            if (x < 0)
            {
                brush = Brushes.Red;
                incX = 1;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(GameLoop);
            t = new Timer();
            t.Interval = 10;
            t.Tick += new EventHandler(t_Ticket);
            t.Start();
        }
        private void t_Ticket(object sender, EventArgs e)
        {
            this.Refresh();
        }

    }
}
