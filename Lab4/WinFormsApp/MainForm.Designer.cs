namespace WinFormsApp
{
    partial class MainForm
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
            this.FigureDataGridView = new System.Windows.Forms.DataGridView();
            this.FigureTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parameters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FigureDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FigureDataGridView
            // 
            this.FigureDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FigureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FigureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FigureTypeColumn,
            this.Parameters,
            this.AreaColumn});
            this.FigureDataGridView.Location = new System.Drawing.Point(6, 22);
            this.FigureDataGridView.Name = "FigureDataGridView";
            this.FigureDataGridView.RowHeadersVisible = false;
            this.FigureDataGridView.RowTemplate.Height = 25;
            this.FigureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FigureDataGridView.Size = new System.Drawing.Size(406, 249);
            this.FigureDataGridView.TabIndex = 0;
            // 
            // FigureTypeColumn
            // 
            this.FigureTypeColumn.HeaderText = "FigureType";
            this.FigureTypeColumn.Name = "FigureTypeColumn";
            // 
            // Parameters
            // 
            this.Parameters.HeaderText = "ParametersColumn";
            this.Parameters.Name = "Parameters";
            // 
            // AreaColumn
            // 
            this.AreaColumn.HeaderText = "Area";
            this.AreaColumn.Name = "AreaColumn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FigureDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 277);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figure Info";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.loadToolStripMenuItem.Text = "Load...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 313);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(118, 313);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(100, 23);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(224, 313);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 23);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(330, 313);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(100, 23);
            this.FilterButton.TabIndex = 5;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 348);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(460, 387);
            this.MinimumSize = new System.Drawing.Size(460, 387);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.FigureDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView FigureDataGridView;
        private DataGridViewTextBoxColumn FigureTypeColumn;
        private DataGridViewTextBoxColumn Parameters;
        private DataGridViewTextBoxColumn AreaColumn;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Button AddButton;
        private Button RemoveButton;
        private Button ClearButton;
        private Button FilterButton;
    }
}
