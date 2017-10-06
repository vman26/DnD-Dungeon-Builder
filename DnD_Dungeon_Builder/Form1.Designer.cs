namespace DnD_Dungeon_Builder
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
            this.gridPanel = new System.Windows.Forms.Panel();
            this.gridPb = new System.Windows.Forms.PictureBox();
            this.isometricPanel = new System.Windows.Forms.Panel();
            this.isometricPb = new System.Windows.Forms.PictureBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.btnClearMap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nupTileSize = new System.Windows.Forms.NumericUpDown();
            this.btnNewMap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nupYtiles = new System.Windows.Forms.NumericUpDown();
            this.nupXtiles = new System.Windows.Forms.NumericUpDown();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPb)).BeginInit();
            this.isometricPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isometricPb)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTileSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupYtiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupXtiles)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPanel
            // 
            this.gridPanel.AutoScroll = true;
            this.gridPanel.Controls.Add(this.gridPb);
            this.gridPanel.Location = new System.Drawing.Point(0, 75);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(632, 613);
            this.gridPanel.TabIndex = 0;
            // 
            // gridPb
            // 
            this.gridPb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridPb.Location = new System.Drawing.Point(257, 228);
            this.gridPb.Name = "gridPb";
            this.gridPb.Size = new System.Drawing.Size(100, 100);
            this.gridPb.TabIndex = 0;
            this.gridPb.TabStop = false;
            this.gridPb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridPb_MouseDown);
            // 
            // isometricPanel
            // 
            this.isometricPanel.AutoScroll = true;
            this.isometricPanel.Controls.Add(this.isometricPb);
            this.isometricPanel.Location = new System.Drawing.Point(632, 75);
            this.isometricPanel.Name = "isometricPanel";
            this.isometricPanel.Size = new System.Drawing.Size(632, 613);
            this.isometricPanel.TabIndex = 1;
            // 
            // isometricPb
            // 
            this.isometricPb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isometricPb.BackColor = System.Drawing.SystemColors.Control;
            this.isometricPb.Location = new System.Drawing.Point(278, 228);
            this.isometricPb.Name = "isometricPb";
            this.isometricPb.Size = new System.Drawing.Size(100, 100);
            this.isometricPb.TabIndex = 1;
            this.isometricPb.TabStop = false;
            // 
            // controlPanel
            // 
            this.controlPanel.AutoScroll = true;
            this.controlPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.controlPanel.Controls.Add(this.btnAddRow);
            this.controlPanel.Controls.Add(this.btnAddColumn);
            this.controlPanel.Controls.Add(this.btnClearMap);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.nupTileSize);
            this.controlPanel.Controls.Add(this.btnNewMap);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.nupYtiles);
            this.controlPanel.Controls.Add(this.nupXtiles);
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1264, 75);
            this.controlPanel.TabIndex = 2;
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(389, 33);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(96, 36);
            this.btnAddRow.TabIndex = 8;
            this.btnAddRow.Text = "Add Row";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(287, 33);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(96, 36);
            this.btnAddColumn.TabIndex = 7;
            this.btnAddColumn.Text = "Add column";
            this.btnAddColumn.UseVisualStyleBackColor = true;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // btnClearMap
            // 
            this.btnClearMap.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearMap.Location = new System.Drawing.Point(1093, 0);
            this.btnClearMap.Name = "btnClearMap";
            this.btnClearMap.Size = new System.Drawing.Size(171, 75);
            this.btnClearMap.TabIndex = 6;
            this.btnClearMap.Text = "Clear map";
            this.btnClearMap.UseVisualStyleBackColor = true;
            this.btnClearMap.Click += new System.EventHandler(this.btnClearMap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tile size:";
            // 
            // nupTileSize
            // 
            this.nupTileSize.Location = new System.Drawing.Point(338, 7);
            this.nupTileSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupTileSize.Name = "nupTileSize";
            this.nupTileSize.Size = new System.Drawing.Size(147, 20);
            this.nupTileSize.TabIndex = 4;
            this.nupTileSize.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nupTileSize.ValueChanged += new System.EventHandler(this.nupTileSize_ValueChanged);
            // 
            // btnNewMap
            // 
            this.btnNewMap.Location = new System.Drawing.Point(12, 33);
            this.btnNewMap.Name = "btnNewMap";
            this.btnNewMap.Size = new System.Drawing.Size(266, 36);
            this.btnNewMap.TabIndex = 3;
            this.btnNewMap.Text = "Create new map";
            this.btnNewMap.UseVisualStyleBackColor = true;
            this.btnNewMap.Click += new System.EventHandler(this.btnNewMap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // nupYtiles
            // 
            this.nupYtiles.Location = new System.Drawing.Point(158, 7);
            this.nupYtiles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupYtiles.Name = "nupYtiles";
            this.nupYtiles.Size = new System.Drawing.Size(120, 20);
            this.nupYtiles.TabIndex = 1;
            this.nupYtiles.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nupXtiles
            // 
            this.nupXtiles.Location = new System.Drawing.Point(12, 7);
            this.nupXtiles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupXtiles.Name = "nupXtiles";
            this.nupXtiles.Size = new System.Drawing.Size(120, 20);
            this.nupXtiles.TabIndex = 0;
            this.nupXtiles.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.isometricPanel);
            this.Controls.Add(this.gridPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPb)).EndInit();
            this.isometricPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.isometricPb)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTileSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupYtiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupXtiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.Panel isometricPanel;
        private System.Windows.Forms.PictureBox gridPb;
        private System.Windows.Forms.PictureBox isometricPb;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupYtiles;
        private System.Windows.Forms.NumericUpDown nupXtiles;
        private System.Windows.Forms.Button btnNewMap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupTileSize;
        private System.Windows.Forms.Button btnClearMap;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnAddColumn;
    }
}

