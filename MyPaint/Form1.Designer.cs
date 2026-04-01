namespace MyPaint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelTool = new System.Windows.Forms.Panel();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.grbFill = new System.Windows.Forms.GroupBox();
            this.btnColorFill = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grbBorder = new System.Windows.Forms.GroupBox();
            this.btnColorBorder = new System.Windows.Forms.Button();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPaint = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.cbBrush = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnColorFill2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelTool.SuspendLayout();
            this.grbFill.SuspendLayout();
            this.grbBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.panelPaint.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelTool);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelPaint);
            this.splitContainer1.Size = new System.Drawing.Size(1022, 567);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelTool
            // 
            this.panelTool.BackColor = System.Drawing.SystemColors.Info;
            this.panelTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTool.Controls.Add(this.btnFont);
            this.panelTool.Controls.Add(this.btnsave);
            this.panelTool.Controls.Add(this.grbFill);
            this.panelTool.Controls.Add(this.grbBorder);
            this.panelTool.Controls.Add(this.cbType);
            this.panelTool.Controls.Add(this.label1);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTool.Location = new System.Drawing.Point(0, 0);
            this.panelTool.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(203, 567);
            this.panelTool.TabIndex = 0;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(2, 4);
            this.txtText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(172, 78);
            this.txtText.TabIndex = 6;
            this.txtText.Visible = false;
            this.txtText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtText_KeyDown);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(12, 474);
            this.btnFont.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(172, 38);
            this.btnFont.TabIndex = 5;
            this.btnFont.Text = "Text Format";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Red;
            this.btnsave.Location = new System.Drawing.Point(12, 516);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(171, 39);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save Image";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // grbFill
            // 
            this.grbFill.Controls.Add(this.btnPicture);
            this.grbFill.Controls.Add(this.label7);
            this.grbFill.Controls.Add(this.label6);
            this.grbFill.Controls.Add(this.btnColorFill2);
            this.grbFill.Controls.Add(this.label5);
            this.grbFill.Controls.Add(this.cbBrush);
            this.grbFill.Controls.Add(this.btnColorFill);
            this.grbFill.Controls.Add(this.label4);
            this.grbFill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFill.Location = new System.Drawing.Point(11, 248);
            this.grbFill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbFill.Name = "grbFill";
            this.grbFill.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbFill.Size = new System.Drawing.Size(172, 158);
            this.grbFill.TabIndex = 3;
            this.grbFill.TabStop = false;
            this.grbFill.Text = "Fill";
            // 
            // btnColorFill
            // 
            this.btnColorFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorFill.Location = new System.Drawing.Point(58, 34);
            this.btnColorFill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColorFill.Name = "btnColorFill";
            this.btnColorFill.Size = new System.Drawing.Size(90, 19);
            this.btnColorFill.TabIndex = 1;
            this.btnColorFill.UseVisualStyleBackColor = true;
            this.btnColorFill.Click += new System.EventHandler(this.btnColorFill_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Color";
            // 
            // grbBorder
            // 
            this.grbBorder.Controls.Add(this.btnColorBorder);
            this.grbBorder.Controls.Add(this.numSize);
            this.grbBorder.Controls.Add(this.label3);
            this.grbBorder.Controls.Add(this.label2);
            this.grbBorder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBorder.Location = new System.Drawing.Point(11, 99);
            this.grbBorder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbBorder.Name = "grbBorder";
            this.grbBorder.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbBorder.Size = new System.Drawing.Size(172, 131);
            this.grbBorder.TabIndex = 2;
            this.grbBorder.TabStop = false;
            this.grbBorder.Text = "Border";
            // 
            // btnColorBorder
            // 
            this.btnColorBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorBorder.Location = new System.Drawing.Point(58, 24);
            this.btnColorBorder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColorBorder.Name = "btnColorBorder";
            this.btnColorBorder.Size = new System.Drawing.Size(90, 19);
            this.btnColorBorder.TabIndex = 3;
            this.btnColorBorder.UseVisualStyleBackColor = true;
            this.btnColorBorder.Click += new System.EventHandler(this.btnColorBorder_Click);
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(58, 70);
            this.numSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(90, 26);
            this.numSize.TabIndex = 2;
            this.numSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Color";
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Pen",
            "Draw Line",
            "Draw Rectangle",
            "Draw Ellipse",
            "Fill Rectangle",
            "Fill Ellipse",
            "Draw String",
            "Draw Triangle",
            "Draw Diamond"});
            this.cbType.Location = new System.Drawing.Point(11, 55);
            this.cbType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(173, 26);
            this.cbType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // panelPaint
            // 
            this.panelPaint.Controls.Add(this.txtText);
            this.panelPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPaint.Location = new System.Drawing.Point(0, 0);
            this.panelPaint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPaint.Name = "panelPaint";
            this.panelPaint.Size = new System.Drawing.Size(816, 567);
            this.panelPaint.TabIndex = 0;
            this.panelPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPaint_Paint);
            this.panelPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPaint_MouseDown);
            this.panelPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPaint_MouseMove);
            this.panelPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelPaint_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbBrush
            // 
            this.cbBrush.FormattingEnabled = true;
            this.cbBrush.Items.AddRange(new object[] {
            "Solid",
            "Linear",
            "Path",
            "Texture",
            "Hatch"});
            this.cbBrush.Location = new System.Drawing.Point(58, 77);
            this.cbBrush.Name = "cbBrush";
            this.cbBrush.Size = new System.Drawing.Size(90, 26);
            this.cbBrush.TabIndex = 6;
            this.cbBrush.SelectedIndexChanged += new System.EventHandler(this.cbBrush_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Brush";
            // 
            // btnColorFill2
            // 
            this.btnColorFill2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorFill2.Location = new System.Drawing.Point(58, 119);
            this.btnColorFill2.Margin = new System.Windows.Forms.Padding(2);
            this.btnColorFill2.Name = "btnColorFill2";
            this.btnColorFill2.Size = new System.Drawing.Size(90, 19);
            this.btnColorFill2.TabIndex = 8;
            this.btnColorFill2.UseVisualStyleBackColor = true;
            this.btnColorFill2.Visible = false;
            this.btnColorFill2.Click += new System.EventHandler(this.btnColorFill2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Color";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Picture";
            this.label7.Visible = false;
            // 
            // btnPicture
            // 
            this.btnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicture.Location = new System.Drawing.Point(69, 120);
            this.btnPicture.Margin = new System.Windows.Forms.Padding(2);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(79, 19);
            this.btnPicture.TabIndex = 11;
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Visible = false;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 567);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelTool.ResumeLayout(false);
            this.panelTool.PerformLayout();
            this.grbFill.ResumeLayout(false);
            this.grbFill.PerformLayout();
            this.grbBorder.ResumeLayout(false);
            this.grbBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.panelPaint.ResumeLayout(false);
            this.panelPaint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.Panel panelPaint;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbBorder;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnColorBorder;
        private System.Windows.Forms.GroupBox grbFill;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnColorFill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.ComboBox cbBrush;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnColorFill2;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Label label7;
    }
}

