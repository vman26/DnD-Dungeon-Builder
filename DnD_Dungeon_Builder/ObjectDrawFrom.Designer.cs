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
            this.btnClear2D = new System.Windows.Forms.Button();
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
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nupBrushWidth = new System.Windows.Forms.NumericUpDown();
            this.btnClearIso = new System.Windows.Forms.Button();
            this.btnClearBoth = new System.Windows.Forms.Button();
            this.nupEraserWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rbEraser = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawing2D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid2D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingIsometric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGridIsometric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFillColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBrushWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupEraserWidth)).BeginInit();
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
            // btnClear2D
            // 
            this.btnClear2D.Location = new System.Drawing.Point(12, 12);
            this.btnClear2D.Name = "btnClear2D";
            this.btnClear2D.Size = new System.Drawing.Size(46, 41);
            this.btnClear2D.TabIndex = 1;
            this.btnClear2D.Text = "Clear left";
            this.btnClear2D.UseVisualStyleBackColor = true;
            this.btnClear2D.Click += new System.EventHandler(this.clearButton_Click);
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
            this.rbFill.Location = new System.Drawing.Point(359, 12);
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
            this.pbDrawColor.Size = new System.Drawing.Size(238, 17);
            this.pbDrawColor.TabIndex = 12;
            this.pbDrawColor.TabStop = false;
            this.pbDrawColor.Click += new System.EventHandler(this.pbColor_Click);
            // 
            // pbFillColor
            // 
            this.pbFillColor.BackColor = System.Drawing.Color.Black;
            this.pbFillColor.Location = new System.Drawing.Point(359, 36);
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
            this.btnUndo.Location = new System.Drawing.Point(1107, 12);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(103, 70);
            this.btnUndo.TabIndex = 15;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(222, 12);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(74, 17);
            this.rbRectangle.TabIndex = 16;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(302, 12);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(51, 17);
            this.rbCircle.TabIndex = 17;
            this.rbCircle.Text = "Circle";
            this.rbCircle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Brush width:";
            // 
            // nupBrushWidth
            // 
            this.nupBrushWidth.Location = new System.Drawing.Point(186, 62);
            this.nupBrushWidth.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nupBrushWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupBrushWidth.Name = "nupBrushWidth";
            this.nupBrushWidth.Size = new System.Drawing.Size(167, 20);
            this.nupBrushWidth.TabIndex = 19;
            this.nupBrushWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnClearIso
            // 
            this.btnClearIso.Location = new System.Drawing.Point(64, 12);
            this.btnClearIso.Name = "btnClearIso";
            this.btnClearIso.Size = new System.Drawing.Size(45, 41);
            this.btnClearIso.TabIndex = 20;
            this.btnClearIso.Text = "Clear right";
            this.btnClearIso.UseVisualStyleBackColor = true;
            this.btnClearIso.Click += new System.EventHandler(this.btnClearIso_Click);
            // 
            // btnClearBoth
            // 
            this.btnClearBoth.Location = new System.Drawing.Point(12, 59);
            this.btnClearBoth.Name = "btnClearBoth";
            this.btnClearBoth.Size = new System.Drawing.Size(97, 23);
            this.btnClearBoth.TabIndex = 21;
            this.btnClearBoth.Text = "Clear both";
            this.btnClearBoth.UseVisualStyleBackColor = true;
            this.btnClearBoth.Click += new System.EventHandler(this.btnClearBoth_Click);
            // 
            // nupEraserWidth
            // 
            this.nupEraserWidth.Location = new System.Drawing.Point(418, 62);
            this.nupEraserWidth.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nupEraserWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupEraserWidth.Name = "nupEraserWidth";
            this.nupEraserWidth.Size = new System.Drawing.Size(65, 20);
            this.nupEraserWidth.TabIndex = 23;
            this.nupEraserWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Eraser width:";
            // 
            // rbEraser
            // 
            this.rbEraser.AutoSize = true;
            this.rbEraser.Location = new System.Drawing.Point(418, 12);
            this.rbEraser.Name = "rbEraser";
            this.rbEraser.Size = new System.Drawing.Size(55, 17);
            this.rbEraser.TabIndex = 24;
            this.rbEraser.Text = "Eraser";
            this.rbEraser.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(988, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 70);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Location = new System.Drawing.Point(1216, 12);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(103, 70);
            this.btnRedo.TabIndex = 26;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // ObjectDrawFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 616);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbEraser);
            this.Controls.Add(this.nupEraserWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClearBoth);
            this.Controls.Add(this.btnClearIso);
            this.Controls.Add(this.nupBrushWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbCircle);
            this.Controls.Add(this.rbRectangle);
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
            this.Controls.Add(this.btnClear2D);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObjectDrawFrom";
            this.Text = "ObjectDraw";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ObjectDrawFrom_FormClosing);
            this.Load += new System.EventHandler(this.ObjectDrawFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawing2D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid2D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingIsometric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGridIsometric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFillColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBrushWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupEraserWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDrawing2D;
        private System.Windows.Forms.Button btnClear2D;
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
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupBrushWidth;
        private System.Windows.Forms.Button btnClearIso;
        private System.Windows.Forms.Button btnClearBoth;
        private System.Windows.Forms.NumericUpDown nupEraserWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbEraser;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRedo;
    }
}