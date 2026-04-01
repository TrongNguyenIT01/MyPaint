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
        Bitmap canvas;
        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = new Bitmap(panelPaint.Width, panelPaint.Height);
            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.Clear(Color.White);
            }
            btnColorBorder.BackColor = BorderColor;
            btnColorFill.BackColor = FillColor;
            cbType.SelectedIndex = 0;
        }

        private void panelPaint_Paint(object sender, PaintEventArgs e)
        {
            if (canvas != null)
            {
                e.Graphics.DrawImage(canvas, 0, 0);
            }
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
            Pen pen = new Pen(BorderColor, (int)numSize.Value);
            SolidBrush brush = new SolidBrush(FillColor);
            var width = Math.Abs(e.X - strartPoint.X);
            var height = Math.Abs(e.Y - strartPoint.Y);
            var x = Math.Min(e.X, strartPoint.X);
            var y = Math.Min(e.Y, strartPoint.Y);
            using (Graphics g = Graphics.FromImage(canvas))
                switch (cbType.SelectedIndex) {
                case 1:
                    g.DrawLine(new Pen(BorderColor, (int)numSize.Value), strartPoint, e.Location);
                    break;
                case 2:
                    g.DrawRectangle(pen, x, y, width, height);
                   
                    break;
                case 3:
                    g.DrawEllipse(pen, x, y, width, height); break;
                case 4:
                    g.FillRectangle(brush, x, y, width, height);
                    break;
                case 5:
                    g.FillEllipse(brush, x, y, width, height);
                    break;
                case 6:
                    g.DrawString("Hello", new Font("Arial", 20), brush, e.Location);
                    break;
                case 7:
                    Point p1 = strartPoint;
                    Point p2 = new Point(e.X, strartPoint.Y);
                    Point p3 = new Point(strartPoint.X, e.Y);
                    
                    Point[] tri = { p1, p2, p3 };
                    g.DrawPolygon(pen, tri);
                    break;
                case 8:
                    var x1 = Math.Min(e.X, strartPoint.X);
                    var y1 = Math.Min(e.Y, strartPoint.Y);
                    var width1 = Math.Abs(e.X - strartPoint.X);
                    var height1 = Math.Abs(e.Y - strartPoint.Y);

                    Point top = new Point(x1 + width1 / 2, y1);
                    Point right = new Point(x1+ width1, y1 + height1 / 2);
                    Point bottom = new Point(x1 + width1 / 2, y1 + height1);
                    Point left = new Point(x1, y1 + height1 / 2);

                    Point[] diamond = { top, right, bottom, left };

                  
                    g.DrawPolygon(pen, diamond);
                    break;
            }

            panelPaint.Invalidate();
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg";
            sfd.Title = "Save Image";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string ext = System.IO.Path.GetExtension(sfd.FileName).ToLower();

                    if (ext == ".jpg")
                    {
                        canvas.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    else
                    {
                        canvas.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    }

                    MessageBox.Show("Lưu ảnh thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void panelPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing) {
                if (cbType.SelectedIndex == 0)
                {
                    using (Graphics g = Graphics.FromImage(canvas)  )
                    {
                        g.DrawLine(new Pen(BorderColor, (int)numSize.Value), strartPoint, e.Location);
                    }
                    strartPoint = e.Location;
                    panelPaint.Invalidate();
                }
   

            }
        }      
    }
}
