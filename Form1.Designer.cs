namespace ChemicalСompoundRecognition
{
    partial class Form1
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
            label1=new System.Windows.Forms.Label();
            textBox1=new System.Windows.Forms.TextBox();
            label2=new System.Windows.Forms.Label();
            pictureBox1=new System.Windows.Forms.PictureBox();
            button1=new System.Windows.Forms.Button();
            label4=new System.Windows.Forms.Label();
            textBox3=new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Font=new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location=new System.Drawing.Point(12, 9);
            label1.Name="label1";
            label1.Padding=new System.Windows.Forms.Padding(15, 0, 0, 0);
            label1.Size=new System.Drawing.Size(776, 23);
            label1.TabIndex=1;
            label1.Text="LOAD YOUR GRAPH BY DRAG&DROP IMAGE ON ANY PLACE";
            label1.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Location=new System.Drawing.Point(794, 38);
            textBox1.Multiline=true;
            textBox1.Name="textBox1";
            textBox1.ScrollBars=System.Windows.Forms.ScrollBars.Vertical;
            textBox1.Size=new System.Drawing.Size(290, 348);
            textBox1.TabIndex=2;
            // 
            // label2
            // 
            label2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Font=new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location=new System.Drawing.Point(794, 9);
            label2.Name="label2";
            label2.Size=new System.Drawing.Size(290, 23);
            label2.TabIndex=4;
            label2.Text="COORDINATES";
            label2.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location=new System.Drawing.Point(12, 38);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new System.Drawing.Size(776, 348);
            pictureBox1.SizeMode=System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex=6;
            pictureBox1.TabStop=false;
            // 
            // button1
            // 
            button1.Font=new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location=new System.Drawing.Point(12, 392);
            button1.Name="button1";
            button1.Size=new System.Drawing.Size(246, 71);
            button1.TabIndex=7;
            button1.Text="PARSE DATA FROM GRAPH";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // label4
            // 
            label4.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            label4.Font=new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location=new System.Drawing.Point(264, 392);
            label4.Name="label4";
            label4.Size=new System.Drawing.Size(158, 45);
            label4.TabIndex=8;
            label4.Text="Enter width step";
            label4.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            textBox3.Location=new System.Drawing.Point(264, 440);
            textBox3.Name="textBox3";
            textBox3.Size=new System.Drawing.Size(158, 23);
            textBox3.TabIndex=9;
            textBox3.Text="1";
            textBox3.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(1096, 472);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name="Form1";
            Text="Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
    }
}
