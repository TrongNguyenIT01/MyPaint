using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnColorBorder.BackColor = BorderColor;
            btnColorFill.BackColor = FillColor;
        }

        private void panelPaint_Paint(object sender, PaintEventArgs e)
        {

        }
        bool isDrawing = false;
        Point strartPoint;
        Color BorderColor = Color.Blue, FillColor = Color.Red;

        private void panelPaint_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            strartPoint = e.Location;


        }

        private void panelPaint_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void btnColorBorder_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK) {
                BorderColor = cd.Color;
                btnColorBorder.BackColor = BorderColor;
            }
        }

        private void btnColorFill_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK) {
                FillColor = cd.Color;
                btnColorFill.BackColor = FillColor;
            } 
        }

        private void panelPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing) {
                Graphics g = panelPaint.CreateGraphics();
                g.DrawLine(Pens.Black, strartPoint, e.Location);
                strartPoint = e.Location;
            }
        }      
    }
}
