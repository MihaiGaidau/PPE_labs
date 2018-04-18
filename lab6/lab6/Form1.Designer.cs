namespace lab6
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
            this.NameLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProffTB = new System.Windows.Forms.TextBox();
            this.HobbyTB = new System.Windows.Forms.TextBox();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.OutTB = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DataLB = new System.Windows.Forms.ListBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.BackColor = System.Drawing.Color.Transparent;
            this.NameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameLb.Location = new System.Drawing.Point(34, 49);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(94, 31);
            this.NameLb.TabIndex = 0;
            this.NameLb.Text = "Name:";
            this.NameLb.Click += new System.EventHandler(this.NameLb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // NameTB
            // 
            this.NameTB.BackColor = System.Drawing.SystemColors.HotTrack;
            this.NameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTB.Location = new System.Drawing.Point(206, 42);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(138, 38);
            this.NameTB.TabIndex = 2;
            this.NameTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NameTB_MouseClick);
            this.NameTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hobby:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Profession:";
            // 
            // ProffTB
            // 
            this.ProffTB.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ProffTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProffTB.Location = new System.Drawing.Point(206, 174);
            this.ProffTB.Name = "ProffTB";
            this.ProffTB.Size = new System.Drawing.Size(138, 38);
            this.ProffTB.TabIndex = 5;
            // 
            // HobbyTB
            // 
            this.HobbyTB.BackColor = System.Drawing.SystemColors.HotTrack;
            this.HobbyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HobbyTB.Location = new System.Drawing.Point(206, 129);
            this.HobbyTB.Name = "HobbyTB";
            this.HobbyTB.Size = new System.Drawing.Size(138, 38);
            this.HobbyTB.TabIndex = 6;
            // 
            // SurnameTB
            // 
            this.SurnameTB.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SurnameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTB.Location = new System.Drawing.Point(206, 86);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(138, 38);
            this.SurnameTB.TabIndex = 7;
            this.SurnameTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SurnameTB_MouseClick);
            this.SurnameTB.TextChanged += new System.EventHandler(this.SurnameTB_TextChanged);
            // 
            // OutTB
            // 
            this.OutTB.BackColor = System.Drawing.SystemColors.HotTrack;
            this.OutTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutTB.Location = new System.Drawing.Point(25, 280);
            this.OutTB.Multiline = true;
            this.OutTB.Name = "OutTB";
            this.OutTB.ReadOnly = true;
            this.OutTB.Size = new System.Drawing.Size(343, 214);
            this.OutTB.TabIndex = 8;
            this.OutTB.Visible = false;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddBtn.Location = new System.Drawing.Point(238, 235);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DataLB
            // 
            this.DataLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataLB.FormattingEnabled = true;
            this.DataLB.ItemHeight = 31;
            this.DataLB.Location = new System.Drawing.Point(681, 49);
            this.DataLB.Name = "DataLB";
            this.DataLB.Size = new System.Drawing.Size(297, 407);
            this.DataLB.TabIndex = 10;
            this.DataLB.SelectedIndexChanged += new System.EventHandler(this.DataLB_SelectedIndexChanged);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClearBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearBtn.Location = new System.Drawing.Point(903, 492);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 11;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(681, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lab6.Properties.Resources.wall1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1035, 582);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DataLB);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.OutTB);
            this.Controls.Add(this.SurnameTB);
            this.Controls.Add(this.HobbyTB);
            this.Controls.Add(this.ProffTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameLb);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProffTB;
        private System.Windows.Forms.TextBox HobbyTB;
        private System.Windows.Forms.TextBox SurnameTB;
        private System.Windows.Forms.TextBox OutTB;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ListBox DataLB;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button button2;
    }
}

