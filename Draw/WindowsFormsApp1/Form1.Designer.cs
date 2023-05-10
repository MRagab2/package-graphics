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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.LineTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputLineY2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputLineY1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBresenham = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputLineX1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputLineX2 = new System.Windows.Forms.TextBox();
            this.btnDDA = new System.Windows.Forms.Button();
            this.CircleTab = new System.Windows.Forms.TabPage();
            this.btnCircle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.inputCircleR = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.inputCircleY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.inputCircleX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EllipseTab = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.inputEllipseRY = new System.Windows.Forms.TextBox();
            this.inputEllipseRX = new System.Windows.Forms.TextBox();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.inputEllipseY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.inputEllipseX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClr = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.LineTab.SuspendLayout();
            this.CircleTab.SuspendLayout();
            this.EllipseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.LineTab);
            this.tabControl2.Controls.Add(this.CircleTab);
            this.tabControl2.Controls.Add(this.EllipseTab);
            this.tabControl2.Location = new System.Drawing.Point(21, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(187, 415);
            this.tabControl2.TabIndex = 13;
            // 
            // LineTab
            // 
            this.LineTab.AccessibleName = "Line";
            this.LineTab.BackColor = System.Drawing.Color.Transparent;
            this.LineTab.Controls.Add(this.label6);
            this.LineTab.Controls.Add(this.label5);
            this.LineTab.Controls.Add(this.inputLineY2);
            this.LineTab.Controls.Add(this.label4);
            this.LineTab.Controls.Add(this.inputLineY1);
            this.LineTab.Controls.Add(this.label3);
            this.LineTab.Controls.Add(this.btnBresenham);
            this.LineTab.Controls.Add(this.label2);
            this.LineTab.Controls.Add(this.inputLineX1);
            this.LineTab.Controls.Add(this.label1);
            this.LineTab.Controls.Add(this.inputLineX2);
            this.LineTab.Controls.Add(this.btnDDA);
            this.LineTab.Location = new System.Drawing.Point(4, 25);
            this.LineTab.Name = "LineTab";
            this.LineTab.Padding = new System.Windows.Forms.Padding(3);
            this.LineTab.Size = new System.Drawing.Size(179, 386);
            this.LineTab.TabIndex = 0;
            this.LineTab.Text = "Line";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ending Point (X2, Y2)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Starting Point (X1, Y1)";
            // 
            // inputLineY2
            // 
            this.inputLineY2.Location = new System.Drawing.Point(21, 257);
            this.inputLineY2.Name = "inputLineY2";
            this.inputLineY2.Size = new System.Drawing.Size(104, 22);
            this.inputLineY2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "X2";
            // 
            // inputLineY1
            // 
            this.inputLineY1.Location = new System.Drawing.Point(22, 128);
            this.inputLineY1.Name = "inputLineY1";
            this.inputLineY1.Size = new System.Drawing.Size(104, 22);
            this.inputLineY1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y2";
            // 
            // btnBresenham
            // 
            this.btnBresenham.Location = new System.Drawing.Point(22, 343);
            this.btnBresenham.Name = "btnBresenham";
            this.btnBresenham.Size = new System.Drawing.Size(103, 23);
            this.btnBresenham.TabIndex = 0;
            this.btnBresenham.Text = "Bresenham";
            this.btnBresenham.UseVisualStyleBackColor = true;
            this.btnBresenham.Click += new System.EventHandler(this.btnBresenham_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y1";
            // 
            // inputLineX1
            // 
            this.inputLineX1.AccessibleName = "inputLineX1";
            this.inputLineX1.Location = new System.Drawing.Point(22, 73);
            this.inputLineX1.Name = "inputLineX1";
            this.inputLineX1.Size = new System.Drawing.Size(104, 22);
            this.inputLineX1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "X1";
            // 
            // inputLineX2
            // 
            this.inputLineX2.Location = new System.Drawing.Point(21, 212);
            this.inputLineX2.Name = "inputLineX2";
            this.inputLineX2.Size = new System.Drawing.Size(104, 22);
            this.inputLineX2.TabIndex = 4;
            // 
            // btnDDA
            // 
            this.btnDDA.AccessibleName = "btnDDA";
            this.btnDDA.Location = new System.Drawing.Point(22, 305);
            this.btnDDA.Name = "btnDDA";
            this.btnDDA.Size = new System.Drawing.Size(103, 23);
            this.btnDDA.TabIndex = 5;
            this.btnDDA.Text = "DDA";
            this.btnDDA.UseVisualStyleBackColor = true;
            this.btnDDA.Click += new System.EventHandler(this.button2_Click);
            // 
            // CircleTab
            // 
            this.CircleTab.AccessibleName = "Circle";
            this.CircleTab.BackColor = System.Drawing.Color.Transparent;
            this.CircleTab.Controls.Add(this.btnCircle);
            this.CircleTab.Controls.Add(this.label11);
            this.CircleTab.Controls.Add(this.inputCircleR);
            this.CircleTab.Controls.Add(this.label10);
            this.CircleTab.Controls.Add(this.inputCircleY);
            this.CircleTab.Controls.Add(this.label9);
            this.CircleTab.Controls.Add(this.inputCircleX);
            this.CircleTab.Controls.Add(this.label8);
            this.CircleTab.Controls.Add(this.label7);
            this.CircleTab.Location = new System.Drawing.Point(4, 25);
            this.CircleTab.Name = "CircleTab";
            this.CircleTab.Padding = new System.Windows.Forms.Padding(3);
            this.CircleTab.Size = new System.Drawing.Size(179, 386);
            this.CircleTab.TabIndex = 1;
            this.CircleTab.Text = "Circle";
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(22, 345);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(104, 23);
            this.btnCircle.TabIndex = 5;
            this.btnCircle.Text = "Draw Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Radius of Circle";
            // 
            // inputCircleR
            // 
            this.inputCircleR.Location = new System.Drawing.Point(22, 265);
            this.inputCircleR.Name = "inputCircleR";
            this.inputCircleR.Size = new System.Drawing.Size(102, 22);
            this.inputCircleR.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Center of Circle (X, Y)";
            // 
            // inputCircleY
            // 
            this.inputCircleY.Location = new System.Drawing.Point(22, 139);
            this.inputCircleY.Name = "inputCircleY";
            this.inputCircleY.Size = new System.Drawing.Size(102, 22);
            this.inputCircleY.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "R";
            // 
            // inputCircleX
            // 
            this.inputCircleX.Location = new System.Drawing.Point(22, 81);
            this.inputCircleX.Name = "inputCircleX";
            this.inputCircleX.Size = new System.Drawing.Size(102, 22);
            this.inputCircleX.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "X";
            // 
            // EllipseTab
            // 
            this.EllipseTab.AccessibleName = "Ellipse";
            this.EllipseTab.BackColor = System.Drawing.Color.Transparent;
            this.EllipseTab.Controls.Add(this.label17);
            this.EllipseTab.Controls.Add(this.inputEllipseRY);
            this.EllipseTab.Controls.Add(this.inputEllipseRX);
            this.EllipseTab.Controls.Add(this.btnEllipse);
            this.EllipseTab.Controls.Add(this.inputEllipseY);
            this.EllipseTab.Controls.Add(this.label12);
            this.EllipseTab.Controls.Add(this.inputEllipseX);
            this.EllipseTab.Controls.Add(this.label13);
            this.EllipseTab.Controls.Add(this.label16);
            this.EllipseTab.Controls.Add(this.label14);
            this.EllipseTab.Controls.Add(this.label15);
            this.EllipseTab.Location = new System.Drawing.Point(4, 25);
            this.EllipseTab.Name = "EllipseTab";
            this.EllipseTab.Padding = new System.Windows.Forms.Padding(3);
            this.EllipseTab.Size = new System.Drawing.Size(179, 386);
            this.EllipseTab.TabIndex = 2;
            this.EllipseTab.Text = "Ellipse";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(55, 279);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 16);
            this.label17.TabIndex = 13;
            this.label17.Text = "R-Y";
            // 
            // inputEllipseRY
            // 
            this.inputEllipseRY.Location = new System.Drawing.Point(19, 298);
            this.inputEllipseRY.Name = "inputEllipseRY";
            this.inputEllipseRY.Size = new System.Drawing.Size(107, 22);
            this.inputEllipseRY.TabIndex = 12;
            // 
            // inputEllipseRX
            // 
            this.inputEllipseRX.Location = new System.Drawing.Point(19, 232);
            this.inputEllipseRX.Name = "inputEllipseRX";
            this.inputEllipseRX.Size = new System.Drawing.Size(107, 22);
            this.inputEllipseRX.TabIndex = 4;
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(19, 346);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(107, 23);
            this.btnEllipse.TabIndex = 5;
            this.btnEllipse.Text = "Draw Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // inputEllipseY
            // 
            this.inputEllipseY.Location = new System.Drawing.Point(19, 142);
            this.inputEllipseY.Name = "inputEllipseY";
            this.inputEllipseY.Size = new System.Drawing.Size(107, 22);
            this.inputEllipseY.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Radii of Ellipse";
            // 
            // inputEllipseX
            // 
            this.inputEllipseX.Location = new System.Drawing.Point(19, 80);
            this.inputEllipseX.Name = "inputEllipseX";
            this.inputEllipseX.Size = new System.Drawing.Size(107, 22);
            this.inputEllipseX.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "Center of Ellipse (X, Y)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(70, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 16);
            this.label16.TabIndex = 6;
            this.label16.Text = "X";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(56, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "R-X";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(69, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 16);
            this.label15.TabIndex = 7;
            this.label15.Text = "Y";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(895, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(191, 438);
            this.dataGridView1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(225, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 438);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnClr
            // 
            this.btnClr.AccessibleName = "btnClr";
            this.btnClr.Location = new System.Drawing.Point(47, 433);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(104, 23);
            this.btnClr.TabIndex = 17;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 479);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl2.ResumeLayout(false);
            this.LineTab.ResumeLayout(false);
            this.LineTab.PerformLayout();
            this.CircleTab.ResumeLayout(false);
            this.CircleTab.PerformLayout();
            this.EllipseTab.ResumeLayout(false);
            this.EllipseTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage LineTab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputLineY2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputLineY1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBresenham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputLineX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputLineX2;
        private System.Windows.Forms.Button btnDDA;
        private System.Windows.Forms.TabPage CircleTab;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox inputCircleR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox inputCircleY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inputCircleX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage EllipseTab;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox inputEllipseRY;
        private System.Windows.Forms.TextBox inputEllipseRX;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.TextBox inputEllipseY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox inputEllipseX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClr;
    }
}

