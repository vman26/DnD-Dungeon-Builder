namespace DnD_Dungeon_Builder
{
    partial class CreateMapForm
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
            this.nupXtiles = new System.Windows.Forms.NumericUpDown();
            this.nupYtiles = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMapName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateMap = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupXtiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupYtiles)).BeginInit();
            this.SuspendLayout();
            // 
            // nupXtiles
            // 
            this.nupXtiles.Location = new System.Drawing.Point(13, 13);
            this.nupXtiles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupXtiles.Name = "nupXtiles";
            this.nupXtiles.Size = new System.Drawing.Size(120, 20);
            this.nupXtiles.TabIndex = 0;
            this.nupXtiles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupYtiles
            // 
            this.nupYtiles.Location = new System.Drawing.Point(159, 13);
            this.nupYtiles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupYtiles.Name = "nupYtiles";
            this.nupYtiles.Size = new System.Drawing.Size(120, 20);
            this.nupYtiles.TabIndex = 1;
            this.nupYtiles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // tbMapName
            // 
            this.tbMapName.Location = new System.Drawing.Point(58, 40);
            this.tbMapName.Name = "tbMapName";
            this.tbMapName.Size = new System.Drawing.Size(221, 20);
            this.tbMapName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // btnCreateMap
            // 
            this.btnCreateMap.Location = new System.Drawing.Point(12, 66);
            this.btnCreateMap.Name = "btnCreateMap";
            this.btnCreateMap.Size = new System.Drawing.Size(267, 58);
            this.btnCreateMap.TabIndex = 5;
            this.btnCreateMap.Text = "Create map";
            this.btnCreateMap.UseVisualStyleBackColor = true;
            this.btnCreateMap.Click += new System.EventHandler(this.btnCreateMap_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(267, 31);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CreateMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(295, 173);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateMap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMapName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupYtiles);
            this.Controls.Add(this.nupXtiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateMapForm";
            this.ShowInTaskbar = false;
            this.Text = "Create Map";
            ((System.ComponentModel.ISupportInitialize)(this.nupXtiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupYtiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nupXtiles;
        private System.Windows.Forms.NumericUpDown nupYtiles;
        private System.Windows.Forms.TextBox tbMapName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateMap;
    }
}