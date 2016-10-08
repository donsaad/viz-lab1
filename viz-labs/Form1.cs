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
using Tao.OpenGl;

namespace viz_labs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float sMin;
        float sMax;
        float ds;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            // FilleRectangle: x,y >> upper left corner of the rectangle

            Brush b1 = new LinearGradientBrush(
                     new Rectangle(0, 70, 55, 50),
                     Color.Blue,
                     Color.Green,
                     LinearGradientMode.Horizontal);
            g.FillRectangle(b1, 0, 70.0f, 55, 50.0f);

            Brush b2 = new LinearGradientBrush(
                new Rectangle(55, 70, 55, 50),
                Color.Green,
                Color.Yellow,
                LinearGradientMode.Horizontal);
            g.FillRectangle(b2, 55, 70.0f, 55, 50.0f);

            Brush b3 = new LinearGradientBrush(
                   new Rectangle(110, 70, 55, 50),
                   Color.Yellow,
                   Color.Orange,
                   LinearGradientMode.Horizontal);
            g.FillRectangle(b3, 110, 70.0f, 55, 50.0f);

            Brush b4 = new LinearGradientBrush(
                       new Rectangle(165, 70, 55, 50),
                       Color.Orange,
                       Color.Red,
                       LinearGradientMode.Horizontal);
            g.FillRectangle(b4, 165, 70.0f, 55, 50.0f);
            ////////////////////
            // discrete colors
            Brush b5 = new LinearGradientBrush(
                    new Rectangle(300, 70, 30, 50), // new x = x + width
                Color.Blue,
                Color.Blue,
                LinearGradientMode.Horizontal);

            g.FillRectangle(b4, 300f, 70f, 30f, 50f);


            Brush b6 = new LinearGradientBrush(
                    new Rectangle(330, 70, 30, 50),
                Color.Yellow,
                Color.Yellow,
                LinearGradientMode.Horizontal);

            g.FillRectangle(b5, 330f, 70f, 30f, 50f);


            Brush b7 = new LinearGradientBrush(
                    new Rectangle(360, 70, 30, 50),
                Color.Red,
                Color.Red,
                LinearGradientMode.Horizontal);

            g.FillRectangle(b6, 360f, 70f, 30f, 50f);

            radioButton1.Checked = true; // select discrete radio button by default
        }

        public Color ValueToColor(float val)
        {
            if (radioButton1.Checked) // discrete
            {
                ds = (sMax - sMin) / 3;
                if (val >= sMin && val < sMin + ds)
                    return Color.Red;
                else if (val >= sMin + ds && val < (sMin + (2 * ds)))
                    return Color.Blue;
                else if (val >= sMin + (2 * ds) && val < (sMin + (3 * ds)))
                    return Color.Yellow;
                else
                    return Color.Black;
            }
            else // continuous
            {
                return Color.Aqua;
            }
        }

        private void convert_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0 || textBox2.Text.Length == 0
                || textBox3.Text.Length == 0)
            {
                MessageBox.Show("You need to Enter sMin, sMax and val",
                    "Input Data Missing");
            }
            else
            {
                sMin = float.Parse(textBox2.Text);
                sMax = float.Parse(textBox3.Text);
                if (sMin > sMax)
                {
                    MessageBox.Show("sMin must be < sMax", "Error");
                    textBox2.Clear();
                    textBox3.Clear();
                    return;
                }
               panel2.BackColor = ValueToColor(float.Parse(textBox1.Text)); ; 
            }
        }

    }
}