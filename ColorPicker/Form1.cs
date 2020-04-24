using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Form1 : Form
    {
        int r, g, b;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            r = trackBar1.Value;
            this.button1.BackColor = Color.FromArgb(r, g, b);
            label2.Text = r.ToString();
            Clipboard.SetText("#" + r.ToString("X") + g.ToString("X") + b.ToString("X"));
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            g = trackBar2.Value;
            this.button1.BackColor = Color.FromArgb(r, g, b);
            label3.Text = g.ToString();
            Clipboard.SetText("#" + r.ToString("X") + g.ToString("X") + b.ToString("X"));
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            b = trackBar3.Value;
            this.button1.BackColor = Color.FromArgb(r, g, b);
            label4.Text = b.ToString();
            Clipboard.SetText("#" + r.ToString("X") + g.ToString("X") + b.ToString("X"));
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("#" + r.ToString("X") + g.ToString("X") + b.ToString("X"), button1, new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y - 30));
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(button1);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            r = 125;
            g = 125;
            b = 125;
            trackBar1.Value = r;
            trackBar2.Value = g;
            trackBar3.Value = b;
            label2.Text = r.ToString();
            label3.Text = g.ToString();
            label4.Text = b.ToString();
            this.button1.BackColor = System.Drawing.Color.FromArgb(r,g,b);
            
        }
    }
}
