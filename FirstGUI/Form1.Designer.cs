namespace FirstGUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnArea = new System.Windows.Forms.Button();
            this.textboxFirst = new System.Windows.Forms.TextBox();
            this.textboxSecond = new System.Windows.Forms.TextBox();
            this.labelSecond = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFirst = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Shape_Areas = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textboxThird = new System.Windows.Forms.TextBox();
            this.labelThird = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(17, 222);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(100, 32);
            this.btnArea.TabIndex = 0;
            this.btnArea.Text = "Calculate Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxFirst
            // 
            this.textboxFirst.Location = new System.Drawing.Point(127, 112);
            this.textboxFirst.Name = "textboxFirst";
            this.textboxFirst.Size = new System.Drawing.Size(100, 20);
            this.textboxFirst.TabIndex = 5;
            this.textboxFirst.Text = "textboxFirst";
            this.textboxFirst.Visible = false;
            this.textboxFirst.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textboxSecond
            // 
            this.textboxSecond.Location = new System.Drawing.Point(127, 138);
            this.textboxSecond.Name = "textboxSecond";
            this.textboxSecond.Size = new System.Drawing.Size(100, 20);
            this.textboxSecond.TabIndex = 6;
            this.textboxSecond.Text = "textboxSecond";
            this.textboxSecond.Visible = false;
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecond.Location = new System.Drawing.Point(24, 142);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(85, 16);
            this.labelSecond.TabIndex = 7;
            this.labelSecond.Text = "labelSecond";
            this.labelSecond.Visible = false;
            this.labelSecond.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblArea
            // 
            this.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(127, 267);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(100, 27);
            this.lblArea.TabIndex = 8;
            this.lblArea.Click += new System.EventHandler(this.lblArea_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Calculate Areas of Shapes";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirst.Location = new System.Drawing.Point(24, 113);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelFirst.Size = new System.Drawing.Size(63, 16);
            this.labelFirst.TabIndex = 10;
            this.labelFirst.Text = "labelFirst";
            this.labelFirst.Visible = false;
            this.labelFirst.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Area";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(127, 222);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 32);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Shape";
            this.label1.Click += new System.EventHandler(this.label5_Click);
            // 
            // Shape_Areas
            // 
            this.Shape_Areas.AutoSize = true;
            this.Shape_Areas.Image = ((System.Drawing.Image)(resources.GetObject("Shape_Areas.Image")));
            this.Shape_Areas.Location = new System.Drawing.Point(302, 73);
            this.Shape_Areas.MinimumSize = new System.Drawing.Size(624, 431);
            this.Shape_Areas.Name = "Shape_Areas";
            this.Shape_Areas.Size = new System.Drawing.Size(624, 431);
            this.Shape_Areas.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Square",
            "Rectangle",
            "Trapezoid",
            "Triangle",
            "Ellipse",
            "Circle"});
            this.listBox1.Location = new System.Drawing.Point(127, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(117, 43);
            this.listBox1.TabIndex = 14;
            this.listBox1.Tag = "listBox1Tag";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textboxThird
            // 
            this.textboxThird.Location = new System.Drawing.Point(127, 164);
            this.textboxThird.Name = "textboxThird";
            this.textboxThird.Size = new System.Drawing.Size(100, 20);
            this.textboxThird.TabIndex = 16;
            this.textboxThird.Text = "textboxThird";
            this.textboxThird.Visible = false;
            // 
            // labelThird
            // 
            this.labelThird.AutoSize = true;
            this.labelThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThird.Location = new System.Drawing.Point(24, 168);
            this.labelThird.Name = "labelThird";
            this.labelThird.Size = new System.Drawing.Size(69, 16);
            this.labelThird.TabIndex = 17;
            this.labelThird.Text = "labelThird";
            this.labelThird.Visible = false;
            this.labelThird.Click += new System.EventHandler(this.labelThird_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(950, 524);
            this.Controls.Add(this.labelThird);
            this.Controls.Add(this.textboxThird);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Shape_Areas);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.textboxSecond);
            this.Controls.Add(this.textboxFirst);
            this.Controls.Add(this.btnArea);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.TextBox textboxFirst;
        private System.Windows.Forms.TextBox textboxSecond;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Shape_Areas;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textboxThird;
        private System.Windows.Forms.Label labelThird;
    }
}

