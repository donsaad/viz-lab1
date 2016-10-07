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
            Init();
        }

        private void Init()
        {
            simpleOpenGlControl1.InitializeContexts();

            Glu.gluOrtho2D(0, 500, 0, 500); // description https://www.opengl.org/sdk/docs/man2/xhtml/gluOrtho2D.xml

            Gl.glViewport(0, 0, this.simpleOpenGlControl1.Width, this.simpleOpenGlControl1.Height);// http://learnopengl.com/#!Getting-started/Coordinate-Systems
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            Gl.glClearColor(0f, 0f, 0f, 0);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            ////////////////////////////////////

            Gl.glColor3d(1f, 0f, 0f);
            Gl.glBegin(Gl.GL_LINES);

            Gl.glVertex2d(10, 10);
            Gl.glVertex2d(50, 100);

            Gl.glColor3d(1f, 1f, 0f);

            Gl.glVertex2d(50, 100);
            Gl.glVertex2d(100, 300);

            Gl.glEnd();
            ////////////////////////////////////
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            g.FillRectangle(Brushes.White, 0, 0, panel1.Width, panel1.Height);
            return;
            g = panel1.CreateGraphics();
            //g.DrawLine(Pens.Black, new Point(0, 0), new Point(30, 30));
            ///////////////////////////////////////////////////////////////
            g.FillRectangle(Brushes.Yellow, 30.0f, 30.0f, 500.0f, 500.0f);
            ///////////////////////////////////////////////////////////////
            Brush b = new LinearGradientBrush(
                new Rectangle(0, 0, 500, 500),
                Color.Red,
                Color.Blue,
                LinearGradientMode.Horizontal);

            g.FillRectangle(b, 0.0f, 0.0f, 500.0f, 500.0f);
            // /////////////////////////////////////////////////////////////////
        }
    }
}
