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
        Color BorderColor = Color.Blue, FillColor = Color.Red, FillColor2 = Color.Green;

        private void panelPaint_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            strartPoint = e.Location;


        }

        private void panelPaint_MouseUp(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(BorderColor, (int)numSize.Value);
            
            var width = Math.Abs(e.X - strartPoint.X);
            var height = Math.Abs(e.Y - strartPoint.Y);
            var x = Math.Min(e.X, strartPoint.X);
            var y = Math.Min(e.Y, strartPoint.Y);
            Rectangle rect = new Rectangle(x, y, width, height);
            using (Graphics g = Graphics.FromImage(canvas))
            {
                Brush brush = GetBrush(rect);
                switch (cbType.SelectedIndex)
                {
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
                        txtText.Font = Font;
                        txtText.ForeColor = FillColor;
                        txtText.Location = e.Location; // Hiện ngay chỗ thả chuột
                        txtText.Visible = true;
                        txtText.Focus();
                        // Lưu lại vị trí để tí nữa vẽ vào canvas
                        strartPoint = e.Location;
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
                        Point right = new Point(x1 + width1, y1 + height1 / 2);
                        Point bottom = new Point(x1 + width1 / 2, y1 + height1);
                        Point left = new Point(x1, y1 + height1 / 2);

                        Point[] diamond = { top, right, bottom, left };


                        g.DrawPolygon(pen, diamond);
                        break;
                }
                brush.Dispose();
            }

            panelPaint.Invalidate();
            isDrawing = false;
        }

        private void btnColorBorder_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                BorderColor = cd.Color;
                btnColorBorder.BackColor = BorderColor;
            }
        }

        private void btnColorFill_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                FillColor = cd.Color;
                btnColorFill.BackColor = FillColor;
            }
        }

        private void btnColorFill2_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                FillColor2 = cd.Color;
                btnColorFill2.BackColor = FillColor2;
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
            if (isDrawing)
            {
                if (cbType.SelectedIndex == 0)
                {
                    using (Graphics g = Graphics.FromImage(canvas))
                    {
                        g.DrawLine(new Pen(BorderColor, (int)numSize.Value), strartPoint, e.Location);
                    }
                    strartPoint = e.Location;
                    panelPaint.Invalidate();
                }


            }
        }

        Font Font = new Font("Arial", 20);
        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = Font;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Font = fd.Font;
                btnFont.Text = Font.Name + ", " + Font.Size + "pt";

            }
        }

        private void txtText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtText.Text))
                {
                    using (Graphics g = Graphics.FromImage(canvas))
                    {
                        g.DrawString(txtText.Text, Font, new SolidBrush(FillColor), strartPoint);
                    }
                    panelPaint.Invalidate();
                }
                txtText.Text = "";
                txtText.Visible = false; // Ẩn đi sau khi vẽ xong
            }
        }

        Image textureImage = null;

        private void btnPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Chọn hình ảnh làm Texture";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Giải phóng ảnh cũ nếu có để tránh tràn bộ nhớ
                    if (textureImage != null) textureImage.Dispose();

                    // Tải ảnh mới từ file
                    textureImage = Image.FromFile(ofd.FileName);

                    // Thông báo cho người dùng biết đã chọn thành công
                    MessageBox.Show("Đã tải ảnh mẫu thành công! Hãy chọn Brush là Texture để vẽ.");
                }
            }
        }


        private void cbBrush_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBrush.SelectedIndex == 3)
            {
                label7.Visible = true;  // Hiện label hướng dẫn
                btnPicture.Visible = true;  // Hiện nút chọn ảnh
            }
            else
            {
                label7.Visible = false; // Ẩn label hướng dẫn
                btnPicture.Visible = false; // Ẩn nút chọn ảnh
            }

            if (cbBrush.SelectedIndex == 1 || cbBrush.SelectedIndex == 2 || cbBrush.SelectedIndex == 4)
            {
                label6.Visible = true; // Hiện label hướng dẫn
                btnColorFill2.Visible = true; // Hiện nút chọn màu Fill2
            }
            else
            {
                label6.Visible = false; // Ẩn label hướng dẫn
                btnColorFill2.Visible = false; // Ẩn nút chọn màu Fill2
            }
        }

        private Brush GetBrush(Rectangle rect)
        {
            // Tránh lỗi nếu Rectangle có kích thước 0
            if (rect.Width <= 0) rect.Width = 1;
            if (rect.Height <= 0) rect.Height = 1;

            switch (cbBrush.SelectedIndex)
            {
                case 1: // LinearGradientBrush
                    return new System.Drawing.Drawing2D.LinearGradientBrush(
                        rect, BorderColor, FillColor, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);

                case 2: // PathGradientBrush (Tô từ tâm ra)
                    System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                    path.AddEllipse(rect);
                    var pgb = new System.Drawing.Drawing2D.PathGradientBrush(path);
                    pgb.CenterColor = FillColor;
                    pgb.SurroundColors = new Color[] { FillColor2 };
                    return pgb;

                case 3: // TextureBrush
                    if (textureImage != null)
                    {
                        TextureBrush tb = new TextureBrush(textureImage);
                        // Giúp ảnh lặp lại đều đặn (Tile) bên trong khối vẽ
                        //tb.WrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
                        return tb;
                    }
                    else
                        return new SolidBrush(FillColor); // Trả về mặc định nếu chưa có ảnh

                case 4: // HatchBrush
                    return new System.Drawing.Drawing2D.HatchBrush(
                        System.Drawing.Drawing2D.HatchStyle.Cross, FillColor2, FillColor);

                default: // SolidBrush (Case 0)
                    return new SolidBrush(FillColor2);
            }
        }

    }
}
