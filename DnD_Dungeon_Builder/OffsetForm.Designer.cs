namespace DnD_Dungeon_Builder
{
    partial class OffsetForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nupOffsetX = new System.Windows.Forms.NumericUpDown();
            this.nupOffsetY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetOffset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupOffsetY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Offset X:";
            // 
            // nupOffsetX
            // 
            this.nupOffsetX.Location = new System.Drawing.Point(66, 7);
            this.nupOffsetX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nupOffsetX.Name = "nupOffsetX";
            this.nupOffsetX.Size = new System.Drawing.Size(120, 20);
            this.nupOffsetX.TabIndex = 1;
            // 
            // nupOffsetY
            // 
            this.nupOffsetY.Location = new System.Drawing.Point(66, 33);
            this.nupOffsetY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nupOffsetY.Name = "nupOffsetY";
            this.nupOffsetY.Size = new System.Drawing.Size(120, 20);
            this.nupOffsetY.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Offset Y:";
            // 
            // btnSetOffset
            // 
            this.btnSetOffset.Location = new System.Drawing.Point(12, 59);
            this.btnSetOffset.Name = "btnSetOffset";
            this.btnSetOffset.Size = new System.Drawing.Size(173, 45);
            this.btnSetOffset.TabIndex = 4;
            this.btnSetOffset.Text = "Set offset";
            this.btnSetOffset.UseVisualStyleBackColor = true;
            this.btnSetOffset.Click += new System.EventHandler(this.btnSetOffset_Click);
            // 
            // OffsetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(197, 114);
            this.Controls.Add(this.btnSetOffset);
            this.Controls.Add(this.nupOffsetY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nupOffsetX);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OffsetForm";
            this.Text = "Offset";
            ((System.ComponentModel.ISupportInitialize)(this.nupOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupOffsetY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupOffsetX;
        private System.Windows.Forms.NumericUpDown nupOffsetY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetOffset;
    }
}