namespace DnD_Dungeon_Builder
{
    partial class ObjectDrawFrom
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
            this.pbDrawing2D = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.pbGrid2D = new System.Windows.Forms.PictureBox();
            this.pbDrawingIsometric = new System.Windows.Forms.PictureBox();
            this.pbGridIsometric = new System.Windows.Forms.PictureBox();
            this.rbDraw = new System.Windows.Forms.RadioButton();
            this.rbFill = new System.Windows.Forms.RadioButton();
            this.cdFillColor = new System.Windows.Forms.ColorDialog();
            this.pbDrawColor = new System.Windows.Forms.PictureBox();
            this.pbFillColor = new System.Windows.Forms.PictureBox();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.btnUndo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawing2D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid2D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingIsometric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGridIsometric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFillColor)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDrawing2D
            // 
            this.pbDrawing2D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDrawing2D.Location = new System.Drawing.Point(299, 326);
            this.pbDrawing2D.Name = "pbDrawing2D";
            this.pbDrawing2D.Size = new System.Drawing.Size(50, 48);
            this.pbDrawing2D.TabIndex = 0;
            this.pbDrawing2D.TabStop = false;
            this.pbDrawing2D.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbDrawing_MouseDown);
            this.pbDrawing2D.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbDrawing_MouseMove);
            this.pbDrawing2D.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbDrawing_MouseUp);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 70);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // pbGrid2D
            // 
            this.pbGrid2D.Location = new System.Drawing.Point(12, 88);
            this.pbGrid2D.Name = "pbGrid2D";
            this.pbGrid2D.Size = new System.Drawing.Size(650, 524);
            this.pbGrid2D.TabIndex = 2;
            this.pbGrid2D.TabStop = false;
            // 
            // pbDrawingIsometric
            // 
            this.pbDrawingIsometric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDrawingIsometric.Location = new System.Drawing.Point(974, 326);
            this.pbDrawingIsometric.Name = "pbDrawingIsometric";
            this.pbDrawingIsometric.Size = new System.Drawing.Size(50, 48);
            this.pbDrawingIsometric.TabIndex = 3;
            this.pbDrawingIsometric.TabStop = false;
            this.pbDrawingIsometric.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbDrawing_MouseDown);
            this.pbDrawingIsometric.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbDrawing_MouseMove);
            this.pbDrawingIsometric.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbDrawing_MouseUp);
            // 
            // pbGridIsometric
            // 
            this.pbGridIsometric.Location = new System.Drawing.Point(668, 88);
            this.pbGridIsometric.Name = "pbGridIsometric";
            this.pbGridIsometric.Size = new System.Drawing.Size(650, 524);
            this.pbGridIsometric.TabIndex = 4;
            this.pbGridIsometric.TabStop = false;
            // 
            // rbDraw
            // 
            this.rbDraw.AutoSize = true;
            this.rbDraw.Checked = true;
            this.rbDraw.Location = new System.Drawing.Point(115, 12);
            this.rbDraw.Name = "rbDraw";
            this.rbDraw.Size = new System.Drawing.Size(50, 17);
            this.rbDraw.TabIndex = 5;
            this.rbDraw.TabStop = true;
            this.rbDraw.Text = "Draw";
            this.rbDraw.UseVisualStyleBackColor = true;
            // 
            // rbFill
            // 
            this.rbFill.AutoSize = true;
            this.rbFill.Location = new System.Drawing.Point(423, 12);
            this.rbFill.Name = "rbFill";
            this.rbFill.Size = new System.Drawing.Size(37, 17);
            this.rbFill.TabIndex = 6;
            this.rbFill.Text = "Fill";
            this.rbFill.UseVisualStyleBackColor = true;
            // 
            // cdFillColor
            // 
            this.cdFillColor.Color = System.Drawing.Color.White;
            // 
            // pbDrawColor
            // 
            this.pbDrawColor.BackColor = System.Drawing.Color.Black;
            this.pbDrawColor.Location = new System.Drawing.Point(115, 36);
            this.pbDrawColor.Name = "pbDrawColor";
            this.pbDrawColor.Size = new System.Drawing.Size(101, 46);
            this.pbDrawColor.TabIndex = 12;
            this.pbDrawColor.TabStop = false;
            this.pbDrawColor.Click += new System.EventHandler(this.pbColor_Click);
            // 
            // pbFillColor
            // 
            this.pbFillColor.BackColor = System.Drawing.Color.Black;
            this.pbFillColor.Location = new System.Drawing.Point(423, 36);
            this.pbFillColor.Name = "pbFillColor";
            this.pbFillColor.Size = new System.Drawing.Size(50, 46);
            this.pbFillColor.TabIndex = 13;
            this.pbFillColor.TabStop = false;
            this.pbFillColor.Click += new System.EventHandler(this.pbColor_Click);
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(171, 12);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(45, 17);
            this.rbLine.TabIndex = 14;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(1214, 12);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(103, 70);
            this.btnUndo.TabIndex = 15;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // ObjectDrawFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 616);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.rbLine);
            this.Controls.Add(this.pbFillColor);
            this.Controls.Add(this.pbDrawColor);
            this.Controls.Add(this.rbFill);
            this.Controls.Add(this.rbDraw);
            this.Controls.Add(this.pbDrawingIsometric);
            this.Controls.Add(this.pbGridIsometric);
            this.Controls.Add(this.pbDrawing2D);
            this.Controls.Add(this.pbGrid2D);
            this.Controls.Add(this.btnClear);
            this.Name = "ObjectDrawFrom";
            this.Text = "ObjectDraw";
            this.Load += new System.EventHandler(this.ObjectDrawFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawing2D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid2D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingIsometric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGridIsometric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFillColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDrawing2D;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pbGrid2D;
        private System.Windows.Forms.PictureBox pbDrawingIsometric;
        private System.Windows.Forms.PictureBox pbGridIsometric;
        private System.Windows.Forms.RadioButton rbDraw;
        private System.Windows.Forms.RadioButton rbFill;
        private System.Windows.Forms.ColorDialog cdFillColor;
        private System.Windows.Forms.PictureBox pbDrawColor;
        private System.Windows.Forms.PictureBox pbFillColor;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.Button btnUndo;
    }
}