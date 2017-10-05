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
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPb)).BeginInit();
            this.isometricPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isometricPb)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPanel
            // 
            this.gridPanel.AutoScroll = true;
            this.gridPanel.Controls.Add(this.gridPb);
            this.gridPanel.Location = new System.Drawing.Point(0, 0);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(632, 681);
            this.gridPanel.TabIndex = 0;
            // 
            // gridPb
            // 
            this.gridPb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridPb.Location = new System.Drawing.Point(257, 262);
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
            this.isometricPanel.Location = new System.Drawing.Point(632, 0);
            this.isometricPanel.Name = "isometricPanel";
            this.isometricPanel.Size = new System.Drawing.Size(632, 681);
            this.isometricPanel.TabIndex = 1;
            // 
            // isometricPb
            // 
            this.isometricPb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isometricPb.BackColor = System.Drawing.SystemColors.Control;
            this.isometricPb.Location = new System.Drawing.Point(278, 262);
            this.isometricPb.Name = "isometricPb";
            this.isometricPb.Size = new System.Drawing.Size(100, 100);
            this.isometricPb.TabIndex = 1;
            this.isometricPb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.Panel isometricPanel;
        private System.Windows.Forms.PictureBox gridPb;
        private System.Windows.Forms.PictureBox isometricPb;
    }
}

