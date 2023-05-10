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
            xUpDown = new NumericUpDown();
            xLabel = new Label();
            yLabel = new Label();
            yUpDown = new NumericUpDown();
            transformLabel = new Label();
            rotationRd = new RadioButton();
            scaleRd = new RadioButton();
            translationRd = new RadioButton();
            testButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            angleUpDown = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)xUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)angleUpDown).BeginInit();
            SuspendLayout();
            // 
            // xUpDown
            // 
            xUpDown.DecimalPlaces = 2;
            xUpDown.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            xUpDown.Location = new Point(190, 250);
            xUpDown.Maximum = new decimal(new int[] { int.MinValue, 0, 0, 0 });
            xUpDown.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            xUpDown.Name = "xUpDown";
            xUpDown.Size = new Size(83, 27);
            xUpDown.TabIndex = 0;
            xUpDown.TabStop = false;
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Location = new Point(97, 252);
            xLabel.Name = "xLabel";
            xLabel.Size = new Size(18, 20);
            xLabel.TabIndex = 1;
            xLabel.Text = "X";
            // 
            // yLabel
            // 
            yLabel.AutoSize = true;
            yLabel.Location = new Point(97, 301);
            yLabel.Name = "yLabel";
            yLabel.Size = new Size(17, 20);
            yLabel.TabIndex = 3;
            yLabel.Text = "Y";
            // 
            // yUpDown
            // 
            yUpDown.DecimalPlaces = 2;
            yUpDown.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            yUpDown.Location = new Point(190, 299);
            yUpDown.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            yUpDown.Name = "yUpDown";
            yUpDown.Size = new Size(83, 27);
            yUpDown.TabIndex = 2;
            yUpDown.TabStop = false;
            // 
            // transformLabel
            // 
            transformLabel.AutoSize = true;
            transformLabel.Location = new Point(110, 24);
            transformLabel.Name = "transformLabel";
            transformLabel.Size = new Size(110, 20);
            transformLabel.TabIndex = 4;
            transformLabel.Text = "Transform Type";
            // 
            // rotationRd
            // 
            rotationRd.AutoSize = true;
            rotationRd.Location = new Point(120, 184);
            rotationRd.Name = "rotationRd";
            rotationRd.Size = new Size(83, 24);
            rotationRd.TabIndex = 5;
            rotationRd.Text = "rotation";
            rotationRd.UseVisualStyleBackColor = true;
            rotationRd.CheckedChanged += rotationRd_CheckedChanged;
            // 
            // scaleRd
            // 
            scaleRd.AutoSize = true;
            scaleRd.Location = new Point(120, 81);
            scaleRd.Name = "scaleRd";
            scaleRd.Size = new Size(63, 24);
            scaleRd.TabIndex = 6;
            scaleRd.Text = "scale";
            scaleRd.UseVisualStyleBackColor = true;
            scaleRd.CheckedChanged += scaleRd_CheckedChanged;
            // 
            // translationRd
            // 
            translationRd.AutoSize = true;
            translationRd.Location = new Point(120, 133);
            translationRd.Name = "translationRd";
            translationRd.Size = new Size(100, 24);
            translationRd.TabIndex = 7;
            translationRd.Text = "translation";
            translationRd.UseVisualStyleBackColor = true;
            translationRd.CheckedChanged += translationRd_CheckedChanged;
            // 
            // testButton
            // 
            testButton.Location = new Point(97, 463);
            testButton.Name = "testButton";
            testButton.Size = new Size(141, 38);
            testButton.TabIndex = 9;
            testButton.Text = "Test!";
            testButton.UseVisualStyleBackColor = true;
            testButton.Click += testButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(380, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 600);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 410);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 12;
            label1.Text = "Angle";
            // 
            // angleUpDown
            // 
            angleUpDown.DecimalPlaces = 2;
            angleUpDown.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            angleUpDown.Location = new Point(190, 408);
            angleUpDown.Maximum = new decimal(new int[] { int.MinValue, 0, 0, 0 });
            angleUpDown.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            angleUpDown.Name = "angleUpDown";
            angleUpDown.Size = new Size(83, 27);
            angleUpDown.TabIndex = 11;
            angleUpDown.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 532);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 13;
            label2.Text = "P1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 592);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 14;
            label3.Text = "P2:";
            // 
            // Transformations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 633);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(angleUpDown);
            Controls.Add(panel1);
            Controls.Add(testButton);
            Controls.Add(translationRd);
            Controls.Add(scaleRd);
            Controls.Add(rotationRd);
            Controls.Add(transformLabel);
            Controls.Add(yLabel);
            Controls.Add(yUpDown);
            Controls.Add(xLabel);
            Controls.Add(xUpDown);
            Name = "Transformations";
            Text = "Transformations";
            Paint += Transformations_Paint;
            ((System.ComponentModel.ISupportInitialize)xUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)yUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)angleUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
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