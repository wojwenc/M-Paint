using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint {
    public partial class Form1 : Form {

        Graphics gfx;

        Pen pen = new Pen(Color.Black, 1.0f);
        
        Point start = new Point();
        Point end = new Point();
        Point prev = new Point();

        bool pressed = false;

        public Form1() {
            InitializeComponent();

            pictureBox2.Click += new EventHandler(color_change);
            pictureBox3.Click += new EventHandler(color_change);
            pictureBox4.Click += new EventHandler(color_change);
            pictureBox5.Click += new EventHandler(color_change);
            pictureBox6.Click += new EventHandler(color_change);
            pictureBox7.Click += new EventHandler(color_change);
            pictureBox8.Click += new EventHandler(color_change);
            pictureBox9.Click += new EventHandler(color_change);
            pictureBox10.Click += new EventHandler(color_change);
            pictureBox11.Click += new EventHandler(color_change);
            pictureBox12.Click += new EventHandler(color_change);
            pictureBox13.Click += new EventHandler(color_change);
            pictureBox14.Click += new EventHandler(color_change);
            pictureBox15.Click += new EventHandler(color_change);

            trackBar1.ValueChanged += new EventHandler(size_change);



        }

        private void size_change(object sender, System.EventArgs e) {
            TrackBar tb = (TrackBar)sender;
            pen.Width = tb.Value + 1;
        }

        private void color_change(object sender, System.EventArgs e) {
            PictureBox pb = (PictureBox)sender;
            pen.Color = pb.BackColor;
            pictureBox1.BackColor = pb.BackColor;
        }

        private void pictureBox2_Click(object sender, EventArgs e) {
        }

        private void label1_Click(object sender, EventArgs e) {
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            start = e.Location;
            if(e.Button == MouseButtons.Left) {
                pressed = true;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                pressed = false;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) {

            if (pressed) {
                end = e.Location;
                gfx = this.CreateGraphics();
                gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                gfx.DrawLine(pen, start, end);
            }
            start = end;
        }
    }
}
