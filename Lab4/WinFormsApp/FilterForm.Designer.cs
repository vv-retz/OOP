namespace WinFormsApp
{
    partial class FilterForm
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
            this.FigureTypeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpperBoundTextBox = new System.Windows.Forms.TextBox();
            this.LowerBoundTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FigureTypeCheckedListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figure type";
            // 
            // FigureTypeCheckedListBox
            // 
            this.FigureTypeCheckedListBox.CheckOnClick = true;
            this.FigureTypeCheckedListBox.FormattingEnabled = true;
            this.FigureTypeCheckedListBox.Location = new System.Drawing.Point(6, 22);
            this.FigureTypeCheckedListBox.Name = "FigureTypeCheckedListBox";
            this.FigureTypeCheckedListBox.Size = new System.Drawing.Size(188, 58);
            this.FigureTypeCheckedListBox.TabIndex = 3;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(12, 200);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(96, 23);
            this.FilterButton.TabIndex = 1;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(116, 200);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(96, 23);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UpperBoundTextBox);
            this.groupBox2.Controls.Add(this.LowerBoundTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 86);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Area range";
            // 
            // UpperBoundTextBox
            // 
            this.UpperBoundTextBox.Location = new System.Drawing.Point(50, 53);
            this.UpperBoundTextBox.Name = "UpperBoundTextBox";
            this.UpperBoundTextBox.Size = new System.Drawing.Size(144, 23);
            this.UpperBoundTextBox.TabIndex = 11;
            // 
            // LowerBoundTextBox
            // 
            this.LowerBoundTextBox.Location = new System.Drawing.Point(50, 24);
            this.LowerBoundTextBox.Name = "LowerBoundTextBox";
            this.LowerBoundTextBox.Size = new System.Drawing.Size(144, 23);
            this.LowerBoundTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "From:";
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 235);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(1200, 430);
            this.MaximumSize = new System.Drawing.Size(239, 274);
            this.MinimumSize = new System.Drawing.Size(239, 274);
            this.Name = "FilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private CheckedListBox FigureTypeCheckedListBox;
        private Button FilterButton;
        private Button ResetButton;
        private GroupBox groupBox2;
        private TextBox UpperBoundTextBox;
        private TextBox LowerBoundTextBox;
        private Label label4;
        private Label label3;
    }
}
