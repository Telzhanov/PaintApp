namespace PaintPencil
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mouseLocationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lineBtn = new System.Windows.Forms.Button();
            this.freeBtn = new System.Windows.Forms.Button();
            this.rectanglebtn = new System.Windows.Forms.Button();
            this.trianglebtn = new System.Windows.Forms.Button();
            this.ellipsebtn = new System.Windows.Forms.Button();
            this.sizetext = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizetext)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(76, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 207);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // colorBtn
            // 
            this.colorBtn.Location = new System.Drawing.Point(14, 23);
            this.colorBtn.Margin = new System.Windows.Forms.Padding(2);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(40, 31);
            this.colorBtn.TabIndex = 1;
            this.colorBtn.Text = "color";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseLocationLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 302);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.statusStrip1.Size = new System.Drawing.Size(403, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mouseLocationLabel
            // 
            this.mouseLocationLabel.Name = "mouseLocationLabel";
            this.mouseLocationLabel.Size = new System.Drawing.Size(89, 17);
            this.mouseLocationLabel.Text = "mouseLocation";
            // 
            // lineBtn
            // 
            this.lineBtn.Location = new System.Drawing.Point(14, 58);
            this.lineBtn.Margin = new System.Windows.Forms.Padding(2);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(40, 28);
            this.lineBtn.TabIndex = 3;
            this.lineBtn.Text = "line";
            this.lineBtn.UseVisualStyleBackColor = true;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // freeBtn
            // 
            this.freeBtn.Location = new System.Drawing.Point(14, 90);
            this.freeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.freeBtn.Name = "freeBtn";
            this.freeBtn.Size = new System.Drawing.Size(40, 28);
            this.freeBtn.TabIndex = 4;
            this.freeBtn.Text = "free";
            this.freeBtn.UseVisualStyleBackColor = true;
            this.freeBtn.Click += new System.EventHandler(this.freeBtn_Click);
            // 
            // rectanglebtn
            // 
            this.rectanglebtn.Location = new System.Drawing.Point(14, 123);
            this.rectanglebtn.Name = "rectanglebtn";
            this.rectanglebtn.Size = new System.Drawing.Size(59, 26);
            this.rectanglebtn.TabIndex = 5;
            this.rectanglebtn.Text = "rectangle";
            this.rectanglebtn.UseVisualStyleBackColor = true;
            this.rectanglebtn.Click += new System.EventHandler(this.rectanglebtn_Click);
            // 
            // trianglebtn
            // 
            this.trianglebtn.Location = new System.Drawing.Point(12, 155);
            this.trianglebtn.Name = "trianglebtn";
            this.trianglebtn.Size = new System.Drawing.Size(59, 26);
            this.trianglebtn.TabIndex = 6;
            this.trianglebtn.Text = "triangle";
            this.trianglebtn.UseVisualStyleBackColor = true;
            this.trianglebtn.Click += new System.EventHandler(this.trianglebtn_Click);
            // 
            // ellipsebtn
            // 
            this.ellipsebtn.Location = new System.Drawing.Point(12, 187);
            this.ellipsebtn.Name = "ellipsebtn";
            this.ellipsebtn.Size = new System.Drawing.Size(59, 26);
            this.ellipsebtn.TabIndex = 7;
            this.ellipsebtn.Text = "ellipse";
            this.ellipsebtn.UseVisualStyleBackColor = true;
            this.ellipsebtn.Click += new System.EventHandler(this.ellipsebtn_Click);
            // 
            // sizetext
            // 
            this.sizetext.Location = new System.Drawing.Point(11, 238);
            this.sizetext.Name = "sizetext";
            this.sizetext.Size = new System.Drawing.Size(59, 20);
            this.sizetext.TabIndex = 8;
            this.sizetext.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizetext.ValueChanged += new System.EventHandler(this.sizetext_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 19);
            this.button1.TabIndex = 9;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Open file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(342, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 33);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(342, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 46);
            this.button4.TabIndex = 12;
            this.button4.Text = "FloodFIll";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 324);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sizetext);
            this.Controls.Add(this.ellipsebtn);
            this.Controls.Add(this.trianglebtn);
            this.Controls.Add(this.rectanglebtn);
            this.Controls.Add(this.freeBtn);
            this.Controls.Add(this.lineBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.colorBtn);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizetext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mouseLocationLabel;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button freeBtn;
        private System.Windows.Forms.Button rectanglebtn;
        private System.Windows.Forms.Button trianglebtn;
        private System.Windows.Forms.Button ellipsebtn;
        private System.Windows.Forms.NumericUpDown sizetext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

