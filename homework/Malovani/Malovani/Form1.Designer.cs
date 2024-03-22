namespace Malovani
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
            this.trackBarThickness = new System.Windows.Forms.TrackBar();
            this.buttonFreehand = new System.Windows.Forms.Button();
            this.buttonDrawRectangle = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.paintBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarThickness
            // 
            this.trackBarThickness.Location = new System.Drawing.Point(434, 12);
            this.trackBarThickness.Maximum = 9;
            this.trackBarThickness.Minimum = 1;
            this.trackBarThickness.Name = "trackBarThickness";
            this.trackBarThickness.Size = new System.Drawing.Size(251, 45);
            this.trackBarThickness.TabIndex = 7;
            this.trackBarThickness.Value = 1;
            this.trackBarThickness.Scroll += new System.EventHandler(this.trackBarThickness_Scroll_1);
            // 
            // buttonFreehand
            // 
            this.buttonFreehand.BackgroundImage = global::Malovani.Properties.Resources.freehand_tool;
            this.buttonFreehand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFreehand.Location = new System.Drawing.Point(10, 12);
            this.buttonFreehand.Name = "buttonFreehand";
            this.buttonFreehand.Size = new System.Drawing.Size(100, 100);
            this.buttonFreehand.TabIndex = 6;
            this.buttonFreehand.UseVisualStyleBackColor = true;
            this.buttonFreehand.Click += new System.EventHandler(this.buttonFreehand_Click_1);
            // 
            // buttonDrawRectangle
            // 
            this.buttonDrawRectangle.BackgroundImage = global::Malovani.Properties.Resources.rectangle_tool;
            this.buttonDrawRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDrawRectangle.Location = new System.Drawing.Point(328, 12);
            this.buttonDrawRectangle.Name = "buttonDrawRectangle";
            this.buttonDrawRectangle.Size = new System.Drawing.Size(100, 100);
            this.buttonDrawRectangle.TabIndex = 5;
            this.buttonDrawRectangle.UseVisualStyleBackColor = true;
            this.buttonDrawRectangle.Click += new System.EventHandler(this.buttonRectangle_Click_1);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.BackgroundImage = global::Malovani.Properties.Resources.ellipse_tool;
            this.buttonEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEllipse.Location = new System.Drawing.Point(222, 12);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(100, 100);
            this.buttonEllipse.TabIndex = 4;
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click_1);
            // 
            // buttonEraser
            // 
            this.buttonEraser.BackgroundImage = global::Malovani.Properties.Resources.eraser_tool_icon_vector;
            this.buttonEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEraser.Location = new System.Drawing.Point(116, 12);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(100, 100);
            this.buttonEraser.TabIndex = 3;
            this.buttonEraser.UseVisualStyleBackColor = true;
            this.buttonEraser.Click += new System.EventHandler(this.buttonEraser_Click_1);
            // 
            // buttonClear
            // 
            this.buttonClear.BackgroundImage = global::Malovani.Properties.Resources.clear_tool;
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClear.Location = new System.Drawing.Point(1792, 12);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 100);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click_1);
            // 
            // buttonColor
            // 
            this.buttonColor.BackgroundImage = global::Malovani.Properties.Resources.colorChange_tool;
            this.buttonColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonColor.Location = new System.Drawing.Point(691, 12);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(100, 100);
            this.buttonColor.TabIndex = 1;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click_1);
            // 
            // paintBox
            // 
            this.paintBox.BackColor = System.Drawing.SystemColors.Control;
            this.paintBox.Location = new System.Drawing.Point(10, 145);
            this.paintBox.Margin = new System.Windows.Forms.Padding(10);
            this.paintBox.Name = "paintBox";
            this.paintBox.Size = new System.Drawing.Size(1900, 900);
            this.paintBox.TabIndex = 0;
            this.paintBox.TabStop = false;
            this.paintBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintBox_MouseDown);
            this.paintBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintBox_MouseMove);
            this.paintBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintBox_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "FREEHAND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ERASER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ELLIPSE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "RECTANGLE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "PEN SIZE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(699, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "CHANGE COLOR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1802, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "NEW CANVAS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "1       2       3       4       5       6       7       8        9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarThickness);
            this.Controls.Add(this.buttonFreehand);
            this.Controls.Add(this.buttonDrawRectangle);
            this.Controls.Add(this.buttonEllipse);
            this.Controls.Add(this.buttonEraser);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.paintBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paintBox;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonEraser;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonDrawRectangle;
        private System.Windows.Forms.Button buttonFreehand;
        private System.Windows.Forms.TrackBar trackBarThickness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

