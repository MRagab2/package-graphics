namespace _2DTransformations
{
    partial class Transformations
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xUpDown = new System.Windows.Forms.NumericUpDown();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.yUpDown = new System.Windows.Forms.NumericUpDown();
            this.transformLabel = new System.Windows.Forms.Label();
            this.rotationRd = new System.Windows.Forms.RadioButton();
            this.scaleRd = new System.Windows.Forms.RadioButton();
            this.translationRd = new System.Windows.Forms.RadioButton();
            this.testButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.angleUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // xUpDown
            // 
            this.xUpDown.DecimalPlaces = 2;
            this.xUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.xUpDown.Location = new System.Drawing.Point(906, 415);
            this.xUpDown.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.xUpDown.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.xUpDown.Name = "xUpDown";
            this.xUpDown.Size = new System.Drawing.Size(83, 27);
            this.xUpDown.TabIndex = 0;
            this.xUpDown.TabStop = false;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(882, 417);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(18, 20);
            this.xLabel.TabIndex = 1;
            this.xLabel.Text = "X";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(882, 461);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(17, 20);
            this.yLabel.TabIndex = 3;
            this.yLabel.Text = "Y";
            // 
            // yUpDown
            // 
            this.yUpDown.DecimalPlaces = 2;
            this.yUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.yUpDown.Location = new System.Drawing.Point(906, 459);
            this.yUpDown.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.yUpDown.Name = "yUpDown";
            this.yUpDown.Size = new System.Drawing.Size(83, 27);
            this.yUpDown.TabIndex = 2;
            this.yUpDown.TabStop = false;
            // 
            // transformLabel
            // 
            this.transformLabel.AutoSize = true;
            this.transformLabel.Location = new System.Drawing.Point(879, 260);
            this.transformLabel.Name = "transformLabel";
            this.transformLabel.Size = new System.Drawing.Size(110, 20);
            this.transformLabel.TabIndex = 4;
            this.transformLabel.Text = "Transform Type";
            // 
            // rotationRd
            // 
            this.rotationRd.AutoSize = true;
            this.rotationRd.Location = new System.Drawing.Point(906, 298);
            this.rotationRd.Name = "rotationRd";
            this.rotationRd.Size = new System.Drawing.Size(83, 24);
            this.rotationRd.TabIndex = 5;
            this.rotationRd.Text = "rotation";
            this.rotationRd.UseVisualStyleBackColor = true;
            this.rotationRd.CheckedChanged += new System.EventHandler(this.rotationRd_CheckedChanged);
            // 
            // scaleRd
            // 
            this.scaleRd.AutoSize = true;
            this.scaleRd.Location = new System.Drawing.Point(906, 328);
            this.scaleRd.Name = "scaleRd";
            this.scaleRd.Size = new System.Drawing.Size(63, 24);
            this.scaleRd.TabIndex = 6;
            this.scaleRd.Text = "scale";
            this.scaleRd.UseVisualStyleBackColor = true;
            this.scaleRd.CheckedChanged += new System.EventHandler(this.scaleRd_CheckedChanged);
            // 
            // translationRd
            // 
            this.translationRd.AutoSize = true;
            this.translationRd.Location = new System.Drawing.Point(906, 358);
            this.translationRd.Name = "translationRd";
            this.translationRd.Size = new System.Drawing.Size(100, 24);
            this.translationRd.TabIndex = 7;
            this.translationRd.Text = "translation";
            this.translationRd.UseVisualStyleBackColor = true;
            this.translationRd.CheckedChanged += new System.EventHandler(this.translationRd_CheckedChanged);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(882, 568);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(141, 38);
            this.testButton.TabIndex = 9;
            this.testButton.Text = "Test!";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(108, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 600);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(851, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Angle";
            // 
            // angleUpDown
            // 
            this.angleUpDown.DecimalPlaces = 2;
            this.angleUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.angleUpDown.Location = new System.Drawing.Point(906, 501);
            this.angleUpDown.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.angleUpDown.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.angleUpDown.Name = "angleUpDown";
            this.angleUpDown.Size = new System.Drawing.Size(83, 27);
            this.angleUpDown.TabIndex = 11;
            this.angleUpDown.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(728, 679);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "P1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(728, 713);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "P2:";
            // 
            // Transformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.angleUpDown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.translationRd);
            this.Controls.Add(this.scaleRd);
            this.Controls.Add(this.rotationRd);
            this.Controls.Add(this.transformLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.yUpDown);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.xUpDown);
            this.Name = "Transformations";
            this.Text = "Transformations";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Transformations_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.xUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown xUpDown;
        private Label xLabel;
        private Label yLabel;
        private NumericUpDown yUpDown;
        private Label transformLabel;
        private RadioButton rotationRd;
        private RadioButton scaleRd;
        private RadioButton translationRd;
        private Button testButton;
        private Panel panel1;
        private Label label1;
        private NumericUpDown angleUpDown;
        private Label label2;
        private Label label3;
    }
}