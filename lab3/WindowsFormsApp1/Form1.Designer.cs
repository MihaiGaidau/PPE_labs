namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnColor = new System.Windows.Forms.Button();
            this.FillColorBox = new System.Windows.Forms.ComboBox();
            this.txtLineWidth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.LineBtn = new System.Windows.Forms.Button();
            this.RecBtn = new System.Windows.Forms.Button();
            this.ElipseBtn = new System.Windows.Forms.Button();
            this.EraserBtn = new System.Windows.Forms.Button();
            this.BezierBtn = new System.Windows.Forms.Button();
            this.LTPBtn = new System.Windows.Forms.Button();
            this.backgroundBtn = new System.Windows.Forms.Button();
            this.GetColorBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(-1, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 536);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In                    +";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out                  -";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(761, 4);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(58, 23);
            this.btnColor.TabIndex = 9;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // FillColorBox
            // 
            this.FillColorBox.FormattingEnabled = true;
            this.FillColorBox.Location = new System.Drawing.Point(343, 1);
            this.FillColorBox.Name = "FillColorBox";
            this.FillColorBox.Size = new System.Drawing.Size(121, 21);
            this.FillColorBox.TabIndex = 6;
            this.FillColorBox.Text = "Unfilled";
            this.FillColorBox.SelectedIndexChanged += new System.EventHandler(this.FillColorBox_SelectedIndexChanged);
            // 
            // txtLineWidth
            // 
            this.txtLineWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLineWidth.Location = new System.Drawing.Point(470, 2);
            this.txtLineWidth.Name = "txtLineWidth";
            this.txtLineWidth.Size = new System.Drawing.Size(40, 21);
            this.txtLineWidth.TabIndex = 3;
            this.txtLineWidth.SelectedIndexChanged += new System.EventHandler(this.txtLineWidth_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width";
            // 
            // LineBtn
            // 
            this.LineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LineBtn.Location = new System.Drawing.Point(0, 0);
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(35, 23);
            this.LineBtn.TabIndex = 10;
            this.LineBtn.Text = "Line";
            this.LineBtn.UseVisualStyleBackColor = true;
            this.LineBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RecBtn
            // 
            this.RecBtn.Location = new System.Drawing.Point(181, 2);
            this.RecBtn.Name = "RecBtn";
            this.RecBtn.Size = new System.Drawing.Size(75, 23);
            this.RecBtn.TabIndex = 1;
            this.RecBtn.Text = "Rectangle";
            this.RecBtn.UseVisualStyleBackColor = true;
            this.RecBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // ElipseBtn
            // 
            this.ElipseBtn.Location = new System.Drawing.Point(262, 2);
            this.ElipseBtn.Name = "ElipseBtn";
            this.ElipseBtn.Size = new System.Drawing.Size(75, 23);
            this.ElipseBtn.TabIndex = 11;
            this.ElipseBtn.Text = "Elipse";
            this.ElipseBtn.UseVisualStyleBackColor = true;
            this.ElipseBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // EraserBtn
            // 
            this.EraserBtn.Location = new System.Drawing.Point(825, 2);
            this.EraserBtn.Name = "EraserBtn";
            this.EraserBtn.Size = new System.Drawing.Size(47, 23);
            this.EraserBtn.TabIndex = 12;
            this.EraserBtn.Text = "Eraser";
            this.EraserBtn.UseVisualStyleBackColor = true;
            this.EraserBtn.Click += new System.EventHandler(this.EraserBtn_Click);
            // 
            // BezierBtn
            // 
            this.BezierBtn.Location = new System.Drawing.Point(41, 2);
            this.BezierBtn.Name = "BezierBtn";
            this.BezierBtn.Size = new System.Drawing.Size(47, 23);
            this.BezierBtn.TabIndex = 13;
            this.BezierBtn.Text = "Bezier";
            this.BezierBtn.UseVisualStyleBackColor = true;
            this.BezierBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // LTPBtn
            // 
            this.LTPBtn.Location = new System.Drawing.Point(94, 4);
            this.LTPBtn.Name = "LTPBtn";
            this.LTPBtn.Size = new System.Drawing.Size(81, 23);
            this.LTPBtn.TabIndex = 14;
            this.LTPBtn.Text = "LineToPoint";
            this.LTPBtn.UseVisualStyleBackColor = true;
            this.LTPBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // backgroundBtn
            // 
            this.backgroundBtn.Location = new System.Drawing.Point(611, 4);
            this.backgroundBtn.Name = "backgroundBtn";
            this.backgroundBtn.Size = new System.Drawing.Size(75, 23);
            this.backgroundBtn.TabIndex = 15;
            this.backgroundBtn.Text = "background";
            this.backgroundBtn.UseVisualStyleBackColor = true;
            this.backgroundBtn.Click += new System.EventHandler(this.backgroundBtn_Click);
            // 
            // GetColorBtn
            // 
            this.GetColorBtn.Location = new System.Drawing.Point(692, 4);
            this.GetColorBtn.Name = "GetColorBtn";
            this.GetColorBtn.Size = new System.Drawing.Size(63, 23);
            this.GetColorBtn.TabIndex = 1;
            this.GetColorBtn.Text = "GetColor";
            this.GetColorBtn.UseVisualStyleBackColor = true;
            this.GetColorBtn.Click += new System.EventHandler(this.GetColorBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.GetColorBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLineWidth);
            this.Controls.Add(this.backgroundBtn);
            this.Controls.Add(this.LTPBtn);
            this.Controls.Add(this.BezierBtn);
            this.Controls.Add(this.EraserBtn);
            this.Controls.Add(this.ElipseBtn);
            this.Controls.Add(this.RecBtn);
            this.Controls.Add(this.LineBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.FillColorBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LW_3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtLineWidth;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox FillColorBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.Button LineBtn;
        private System.Windows.Forms.Button RecBtn;
        private System.Windows.Forms.Button ElipseBtn;
        private System.Windows.Forms.Button EraserBtn;
        private System.Windows.Forms.Button BezierBtn;
        private System.Windows.Forms.Button LTPBtn;
        private System.Windows.Forms.Button backgroundBtn;
        private System.Windows.Forms.Button GetColorBtn;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
    }
}

