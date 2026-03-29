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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelTool.SuspendLayout();
            this.grbFill.SuspendLayout();
            this.grbBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelTool);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelPaint);
            this.splitContainer1.Size = new System.Drawing.Size(1362, 698);
            this.splitContainer1.SplitterDistance = 364;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelTool
            // 
            this.panelTool.BackColor = System.Drawing.SystemColors.Info;
            this.panelTool.Controls.Add(this.grbFill);
            this.panelTool.Controls.Add(this.grbBorder);
            this.panelTool.Controls.Add(this.cbType);
            this.panelTool.Controls.Add(this.label1);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTool.Location = new System.Drawing.Point(0, 0);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(364, 698);
            this.panelTool.TabIndex = 0;
            // 
            // grbFill
            // 
            this.grbFill.Controls.Add(this.btnColorFill);
            this.grbFill.Controls.Add(this.label4);
            this.grbFill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFill.Location = new System.Drawing.Point(15, 305);
            this.grbFill.Name = "grbFill";
            this.grbFill.Size = new System.Drawing.Size(230, 180);
            this.grbFill.TabIndex = 3;
            this.grbFill.TabStop = false;
            this.grbFill.Text = "Fill";
            // 
            // btnColorFill
            // 
            this.btnColorFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorFill.Location = new System.Drawing.Point(70, 42);
            this.btnColorFill.Name = "btnColorFill";
            this.btnColorFill.Size = new System.Drawing.Size(75, 23);
            this.btnColorFill.TabIndex = 1;
            this.btnColorFill.UseVisualStyleBackColor = true;
            this.btnColorFill.Click += new System.EventHandler(this.btnColorFill_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
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
            this.grbBorder.Location = new System.Drawing.Point(15, 122);
            this.grbBorder.Name = "grbBorder";
            this.grbBorder.Size = new System.Drawing.Size(229, 161);
            this.grbBorder.TabIndex = 2;
            this.grbBorder.TabStop = false;
            this.grbBorder.Text = "Border";
            // 
            // btnColorBorder
            // 
            this.btnColorBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorBorder.Location = new System.Drawing.Point(77, 29);
            this.btnColorBorder.Name = "btnColorBorder";
            this.btnColorBorder.Size = new System.Drawing.Size(120, 23);
            this.btnColorBorder.TabIndex = 3;
            this.btnColorBorder.UseVisualStyleBackColor = true;
            this.btnColorBorder.Click += new System.EventHandler(this.btnColorBorder_Click);
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(77, 86);
            this.numSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(120, 30);
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
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
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
            this.cbType.Location = new System.Drawing.Point(15, 68);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(229, 31);
            this.cbType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // panelPaint
            // 
            this.panelPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPaint.Location = new System.Drawing.Point(0, 0);
            this.panelPaint.Name = "panelPaint";
            this.panelPaint.Size = new System.Drawing.Size(994, 698);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 698);
            this.Controls.Add(this.splitContainer1);
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
    }
}

