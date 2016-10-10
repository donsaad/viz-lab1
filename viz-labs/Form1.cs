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
            Rectangle[] rects = new Rectangle[5];
            rects[0] = new Rectangle(30, 70, 50, 55);
            rects[1] = new Rectangle(60, 70, 50, 55);
            rects[2] = new Rectangle(90, 70, 50, 55);
            rects[3] = new Rectangle(120, 70, 50, 55);
            rects[4] = new Rectangle(150, 70, 50, 55);

            g.DrawRectangles(Pens.Transparent, rects);
            Brush b = new LinearGradientBrush(rects[0],
                Color.Red,
                Color.Green,
                LinearGradientMode.Horizontal);
            g.FillRectangle(b, rects[0]);

            b = new LinearGradientBrush(rects[1],
                Color.Green,
                Color.Blue,
                LinearGradientMode.Horizontal);
            g.FillRectangle(b, rects[1]);

            b = new LinearGradientBrush(rects[2],
                Color.Blue,
                Color.Yellow,
                LinearGradientMode.Horizontal);
            g.FillRectangle(b, rects[2]);
            b = new LinearGradientBrush(rects[2],
                Color.Yellow,
                Color.Orange,
                LinearGradientMode.Horizontal);
            g.FillRectangle(b, rects[2]);

            b = new LinearGradientBrush(rects[3],
                Color.Orange,
                Color.Tomato,
                LinearGradientMode.Horizontal);
            g.FillRectangle(b, rects[3]);

            b = new LinearGradientBrush(rects[4],
                Color.Tomato,
                Color.SkyBlue,
                LinearGradientMode.Horizontal);
            g.FillRectangle(b, rects[4]);

            ////////////////////
            // discrete colors
            Brush b5 = new LinearGradientBrush(
                    new Rectangle(300, 70, 30, 50), // new x = x + width
                Color.Blue,
                Color.Blue,
                LinearGradientMode.Horizontal);

            g.FillRectangle(b5, 300f, 70f, 30f, 50f);


            Brush b6 = new LinearGradientBrush(
                    new Rectangle(330, 70, 30, 50),
                Color.Green,
                Color.Green,
                LinearGradientMode.Horizontal);

            g.FillRectangle(b6, 330f, 70f, 30f, 50f);


            Brush b7 = new LinearGradientBrush(
                    new Rectangle(360, 70, 30, 50),
                Color.Red,
                Color.Red,
                LinearGradientMode.Horizontal);

            g.FillRectangle(b7, 360f, 70f, 30f, 50f);

            radioDiscrete.Checked = true; // select discrete radio button by default
        }

        public Color ValueToColor(float val)
        {
            if (radioDiscrete.Checked) // discrete
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

       
        private void btnValToColor_Click(object sender, EventArgs e)
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

        private void btnColorToVal_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0 || textBox3.Text.Length == 0
                || RBox.Text.Length == 0 || BBox.Text.Length == 0
                || GBox.Text.Length == 0)
            {
                MessageBox.Show("You need to enter all values for sMin, sMax, R, G, B.",
                    "Input Data Missing");
            }
            else
            {
                int cR = int.Parse(RBox.Text);
                int cG = int.Parse(GBox.Text);
                int cB = int.Parse(BBox.Text);
                sMin = float.Parse(textBox2.Text);
                sMax = float.Parse(textBox3.Text);
                int interval = (int) (sMax - sMin) / 3;
                if (radioDiscrete.Checked) // if discrete
                {
                    if (cR == Color.Blue.R && cG == Color.Blue.G && cB == Color.Blue.B)
                    {
                        outLabel.Text = sMin.ToString();
                        outLabel.ForeColor = Color.FromArgb(cR, cG, cB);
                    }
                    else if (cR == Color.Green.R && cG == Color.Green.G && cB == Color.Green.B)
                    {
                        outLabel.Text = (sMin + interval).ToString();
                        outLabel.ForeColor = Color.FromArgb(cR, cG, cB);
                    }
                    else if (cR == Color.Red.R && cG == Color.Red.G && cB == Color.Red.B)
                    {
                        outLabel.Text = (sMin + (interval * 2)).ToString();
                        outLabel.ForeColor = Color.FromArgb(cR, cG, cB);
                    }
                    else
                    {
                        outLabel.Text = "OUT";
                    }
                }
                else // continuous
                {

                }
            }
        }

    }
}