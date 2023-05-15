namespace WinFormsApp
{
    partial class InputForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rectangleUserControl1 = new WinFormsApp.RectangleUserControl();
            this.circleUserControl1 = new WinFormsApp.CircleUserControl();
            this.ComboBoxFigureTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.AddRandomObjectButton = new System.Windows.Forms.Button();
            this.triangleUserControl1 = new WinFormsApp.TriangleUserControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.triangleUserControl1);
            this.groupBox1.Controls.Add(this.rectangleUserControl1);
            this.groupBox1.Controls.Add(this.circleUserControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 193);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters:";
            // 
            // rectangleUserControl1
            // 
            this.rectangleUserControl1.Location = new System.Drawing.Point(6, 22);
            this.rectangleUserControl1.Name = "rectangleUserControl1";
            this.rectangleUserControl1.Size = new System.Drawing.Size(150, 150);
            this.rectangleUserControl1.TabIndex = 1;
            this.rectangleUserControl1.Visible = false;
            // 
            // circleUserControl1
            // 
            this.circleUserControl1.Location = new System.Drawing.Point(6, 22);
            this.circleUserControl1.Name = "circleUserControl1";
            this.circleUserControl1.Size = new System.Drawing.Size(150, 150);
            this.circleUserControl1.TabIndex = 0;
            this.circleUserControl1.Visible = false;
            // 
            // ComboBoxFigureTypes
            // 
            this.ComboBoxFigureTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFigureTypes.FormattingEnabled = true;
            this.ComboBoxFigureTypes.Location = new System.Drawing.Point(12, 31);
            this.ComboBoxFigureTypes.Name = "ComboBoxFigureTypes";
            this.ComboBoxFigureTypes.Size = new System.Drawing.Size(175, 23);
            this.ComboBoxFigureTypes.TabIndex = 7;
            this.ComboBoxFigureTypes.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFigureTypes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select figure type:";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 317);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(175, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 288);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(175, 23);
            this.OKButton.TabIndex = 10;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AddRandomObjectButton
            // 
            this.AddRandomObjectButton.Location = new System.Drawing.Point(12, 259);
            this.AddRandomObjectButton.Name = "AddRandomObjectButton";
            this.AddRandomObjectButton.Size = new System.Drawing.Size(175, 23);
            this.AddRandomObjectButton.TabIndex = 9;
            this.AddRandomObjectButton.Text = "Add a random figure";
            this.AddRandomObjectButton.UseVisualStyleBackColor = true;
            this.AddRandomObjectButton.Visible = false;
            this.AddRandomObjectButton.Click += new System.EventHandler(this.AddRandomObjectButton_Click);
            // 
            // triangleUserControl1
            // 
            this.triangleUserControl1.Location = new System.Drawing.Point(6, 22);
            this.triangleUserControl1.Name = "triangleUserControl1";
            this.triangleUserControl1.Size = new System.Drawing.Size(150, 150);
            this.triangleUserControl1.TabIndex = 2;
            this.triangleUserControl1.Visible = false;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 352);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComboBoxFigureTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.AddRandomObjectButton);
            this.Location = new System.Drawing.Point(450, 320);
            this.MaximumSize = new System.Drawing.Size(217, 391);
            this.MinimumSize = new System.Drawing.Size(217, 391);
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox ComboBoxFigureTypes;
        private Label label1;
        private Button CancelButton;
        private Button OKButton;
        private Button AddRandomObjectButton;
        private RectangleUserControl rectangleUserControl1;
        private CircleUserControl circleUserControl1;
        private TriangleUserControl triangleUserControl1;
    }
}
