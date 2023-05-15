namespace WinFormsApp
{
    partial class TriangleUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sideA = new System.Windows.Forms.TextBox();
            this.sideB = new System.Windows.Forms.TextBox();
            this.sideC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sideA
            // 
            this.sideA.Location = new System.Drawing.Point(38, 35);
            this.sideA.Name = "textBox1";
            this.sideA.Size = new System.Drawing.Size(100, 23);
            this.sideA.TabIndex = 0;
            // 
            // sideB
            // 
            this.sideB.Location = new System.Drawing.Point(38, 64);
            this.sideB.Name = "textBox2";
            this.sideB.Size = new System.Drawing.Size(100, 23);
            this.sideB.TabIndex = 1;
            // 
            // sideC
            // 
            this.sideC.Location = new System.Drawing.Point(38, 93);
            this.sideC.Name = "textBox3";
            this.sideC.Size = new System.Drawing.Size(100, 23);
            this.sideC.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "C:";
            // 
            // TriangleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sideC);
            this.Controls.Add(this.sideB);
            this.Controls.Add(this.sideA);
            this.Name = "TriangleUserControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox sideA;
        private TextBox sideB;
        private TextBox sideC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
