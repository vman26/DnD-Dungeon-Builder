namespace DnD_Dungeon_Builder
{
    partial class ComponentManagerForm
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
            this.lbComponents = new System.Windows.Forms.ListBox();
            this.btnAddComponent = new System.Windows.Forms.Button();
            this.btnRemoveComponent = new System.Windows.Forms.Button();
            this.pbNorth2D = new System.Windows.Forms.PictureBox();
            this.lblComponentName = new System.Windows.Forms.Label();
            this.pbNorthIsometric = new System.Windows.Forms.PictureBox();
            this.pbSouthIsometric = new System.Windows.Forms.PictureBox();
            this.pbSouth2D = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbWestIsometric = new System.Windows.Forms.PictureBox();
            this.pbWest2D = new System.Windows.Forms.PictureBox();
            this.pbEastIsometric = new System.Windows.Forms.PictureBox();
            this.pbEast2D = new System.Windows.Forms.PictureBox();
            this.btnNorthEdit = new System.Windows.Forms.Button();
            this.btnEastEdit = new System.Windows.Forms.Button();
            this.btnSouthEdit = new System.Windows.Forms.Button();
            this.btnWestEdit = new System.Windows.Forms.Button();
            this.btnNorthToWest = new System.Windows.Forms.Button();
            this.btnWestToNorth = new System.Windows.Forms.Button();
            this.btnEastToSouth = new System.Windows.Forms.Button();
            this.btnSouthToEast = new System.Windows.Forms.Button();
            this.lbComponentVariants = new System.Windows.Forms.ListBox();
            this.btnRemoveVariant = new System.Windows.Forms.Button();
            this.btnAddVariant = new System.Windows.Forms.Button();
            this.btnCloneVariant = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbNorth2D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNorthIsometric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSouthIsometric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSouth2D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWestIsometric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWest2D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEastIsometric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEast2D)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbComponents
            // 
            this.lbComponents.FormattingEnabled = true;
            this.lbComponents.Location = new System.Drawing.Point(12, 27);
            this.lbComponents.Name = "lbComponents";
            this.lbComponents.Size = new System.Drawing.Size(161, 199);
            this.lbComponents.TabIndex = 0;
            this.lbComponents.SelectedIndexChanged += new System.EventHandler(this.lbComponents_SelectedIndexChanged);
            // 
            // btnAddComponent
            // 
            this.btnAddComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComponent.Location = new System.Drawing.Point(11, 233);
            this.btnAddComponent.Name = "btnAddComponent";
            this.btnAddComponent.Size = new System.Drawing.Size(80, 44);
            this.btnAddComponent.TabIndex = 1;
            this.btnAddComponent.Text = "+";
            this.btnAddComponent.UseVisualStyleBackColor = true;
            this.btnAddComponent.Click += new System.EventHandler(this.btnAddComponent_Click);
            // 
            // btnRemoveComponent
            // 
            this.btnRemoveComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveComponent.Location = new System.Drawing.Point(91, 233);
            this.btnRemoveComponent.Name = "btnRemoveComponent";
            this.btnRemoveComponent.Size = new System.Drawing.Size(81, 44);
            this.btnRemoveComponent.TabIndex = 2;
            this.btnRemoveComponent.Text = "-";
            this.btnRemoveComponent.UseVisualStyleBackColor = true;
            this.btnRemoveComponent.Click += new System.EventHandler(this.btnRemoveComponent_Click);
            // 
            // pbNorth2D
            // 
            this.pbNorth2D.Location = new System.Drawing.Point(179, 85);
            this.pbNorth2D.Name = "pbNorth2D";
            this.pbNorth2D.Size = new System.Drawing.Size(200, 200);
            this.pbNorth2D.TabIndex = 3;
            this.pbNorth2D.TabStop = false;
            // 
            // lblComponentName
            // 
            this.lblComponentName.AutoSize = true;
            this.lblComponentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponentName.Location = new System.Drawing.Point(180, 28);
            this.lblComponentName.Name = "lblComponentName";
            this.lblComponentName.Size = new System.Drawing.Size(217, 25);
            this.lblComponentName.TabIndex = 4;
            this.lblComponentName.Text = "No component selected";
            // 
            // pbNorthIsometric
            // 
            this.pbNorthIsometric.Location = new System.Drawing.Point(385, 85);
            this.pbNorthIsometric.Name = "pbNorthIsometric";
            this.pbNorthIsometric.Size = new System.Drawing.Size(200, 200);
            this.pbNorthIsometric.TabIndex = 5;
            this.pbNorthIsometric.TabStop = false;
            // 
            // pbSouthIsometric
            // 
            this.pbSouthIsometric.Location = new System.Drawing.Point(385, 337);
            this.pbSouthIsometric.Name = "pbSouthIsometric";
            this.pbSouthIsometric.Size = new System.Drawing.Size(200, 200);
            this.pbSouthIsometric.TabIndex = 7;
            this.pbSouthIsometric.TabStop = false;
            // 
            // pbSouth2D
            // 
            this.pbSouth2D.Location = new System.Drawing.Point(179, 337);
            this.pbSouth2D.Name = "pbSouth2D";
            this.pbSouth2D.Size = new System.Drawing.Size(200, 200);
            this.pbSouth2D.TabIndex = 6;
            this.pbSouth2D.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "North";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "South";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(678, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "West";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(678, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "East";
            // 
            // pbWestIsometric
            // 
            this.pbWestIsometric.Location = new System.Drawing.Point(887, 85);
            this.pbWestIsometric.Name = "pbWestIsometric";
            this.pbWestIsometric.Size = new System.Drawing.Size(200, 200);
            this.pbWestIsometric.TabIndex = 13;
            this.pbWestIsometric.TabStop = false;
            // 
            // pbWest2D
            // 
            this.pbWest2D.Location = new System.Drawing.Point(681, 85);
            this.pbWest2D.Name = "pbWest2D";
            this.pbWest2D.Size = new System.Drawing.Size(200, 200);
            this.pbWest2D.TabIndex = 12;
            this.pbWest2D.TabStop = false;
            // 
            // pbEastIsometric
            // 
            this.pbEastIsometric.Location = new System.Drawing.Point(887, 337);
            this.pbEastIsometric.Name = "pbEastIsometric";
            this.pbEastIsometric.Size = new System.Drawing.Size(200, 200);
            this.pbEastIsometric.TabIndex = 11;
            this.pbEastIsometric.TabStop = false;
            // 
            // pbEast2D
            // 
            this.pbEast2D.Location = new System.Drawing.Point(681, 337);
            this.pbEast2D.Name = "pbEast2D";
            this.pbEast2D.Size = new System.Drawing.Size(200, 200);
            this.pbEast2D.TabIndex = 10;
            this.pbEast2D.TabStop = false;
            // 
            // btnNorthEdit
            // 
            this.btnNorthEdit.Location = new System.Drawing.Point(510, 64);
            this.btnNorthEdit.Name = "btnNorthEdit";
            this.btnNorthEdit.Size = new System.Drawing.Size(75, 23);
            this.btnNorthEdit.TabIndex = 16;
            this.btnNorthEdit.Text = "Edit";
            this.btnNorthEdit.UseVisualStyleBackColor = true;
            this.btnNorthEdit.Click += new System.EventHandler(this.btnNorthEdit_Click);
            // 
            // btnEastEdit
            // 
            this.btnEastEdit.Location = new System.Drawing.Point(1012, 315);
            this.btnEastEdit.Name = "btnEastEdit";
            this.btnEastEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEastEdit.TabIndex = 17;
            this.btnEastEdit.Text = "Edit";
            this.btnEastEdit.UseVisualStyleBackColor = true;
            this.btnEastEdit.Click += new System.EventHandler(this.btnEastEdit_Click);
            // 
            // btnSouthEdit
            // 
            this.btnSouthEdit.Location = new System.Drawing.Point(510, 315);
            this.btnSouthEdit.Name = "btnSouthEdit";
            this.btnSouthEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSouthEdit.TabIndex = 18;
            this.btnSouthEdit.Text = "Edit";
            this.btnSouthEdit.UseVisualStyleBackColor = true;
            this.btnSouthEdit.Click += new System.EventHandler(this.btnSouthEdit_Click);
            // 
            // btnWestEdit
            // 
            this.btnWestEdit.Location = new System.Drawing.Point(1012, 64);
            this.btnWestEdit.Name = "btnWestEdit";
            this.btnWestEdit.Size = new System.Drawing.Size(75, 23);
            this.btnWestEdit.TabIndex = 19;
            this.btnWestEdit.Text = "Edit";
            this.btnWestEdit.UseVisualStyleBackColor = true;
            this.btnWestEdit.Click += new System.EventHandler(this.btnWestEdit_Click);
            // 
            // btnNorthToWest
            // 
            this.btnNorthToWest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNorthToWest.Location = new System.Drawing.Point(591, 85);
            this.btnNorthToWest.Name = "btnNorthToWest";
            this.btnNorthToWest.Size = new System.Drawing.Size(84, 96);
            this.btnNorthToWest.TabIndex = 20;
            this.btnNorthToWest.Text = ">>";
            this.btnNorthToWest.UseVisualStyleBackColor = true;
            this.btnNorthToWest.Click += new System.EventHandler(this.btnNorthToWest_Click);
            // 
            // btnWestToNorth
            // 
            this.btnWestToNorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWestToNorth.Location = new System.Drawing.Point(591, 189);
            this.btnWestToNorth.Name = "btnWestToNorth";
            this.btnWestToNorth.Size = new System.Drawing.Size(84, 96);
            this.btnWestToNorth.TabIndex = 21;
            this.btnWestToNorth.Text = "<<";
            this.btnWestToNorth.UseVisualStyleBackColor = true;
            this.btnWestToNorth.Click += new System.EventHandler(this.btnWestToNorth_Click);
            // 
            // btnEastToSouth
            // 
            this.btnEastToSouth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEastToSouth.Location = new System.Drawing.Point(588, 441);
            this.btnEastToSouth.Name = "btnEastToSouth";
            this.btnEastToSouth.Size = new System.Drawing.Size(84, 96);
            this.btnEastToSouth.TabIndex = 23;
            this.btnEastToSouth.Text = "<<";
            this.btnEastToSouth.UseVisualStyleBackColor = true;
            this.btnEastToSouth.Click += new System.EventHandler(this.btnEastToSouth_Click);
            // 
            // btnSouthToEast
            // 
            this.btnSouthToEast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSouthToEast.Location = new System.Drawing.Point(588, 337);
            this.btnSouthToEast.Name = "btnSouthToEast";
            this.btnSouthToEast.Size = new System.Drawing.Size(84, 96);
            this.btnSouthToEast.TabIndex = 22;
            this.btnSouthToEast.Text = ">>";
            this.btnSouthToEast.UseVisualStyleBackColor = true;
            this.btnSouthToEast.Click += new System.EventHandler(this.btnSouthToEast_Click);
            // 
            // lbComponentVariants
            // 
            this.lbComponentVariants.FormattingEnabled = true;
            this.lbComponentVariants.Location = new System.Drawing.Point(11, 283);
            this.lbComponentVariants.Name = "lbComponentVariants";
            this.lbComponentVariants.Size = new System.Drawing.Size(161, 160);
            this.lbComponentVariants.TabIndex = 24;
            this.lbComponentVariants.SelectedIndexChanged += new System.EventHandler(this.lbComponentVariants_SelectedIndexChanged);
            // 
            // btnRemoveVariant
            // 
            this.btnRemoveVariant.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveVariant.Location = new System.Drawing.Point(92, 493);
            this.btnRemoveVariant.Name = "btnRemoveVariant";
            this.btnRemoveVariant.Size = new System.Drawing.Size(81, 44);
            this.btnRemoveVariant.TabIndex = 26;
            this.btnRemoveVariant.Text = "-";
            this.btnRemoveVariant.UseVisualStyleBackColor = true;
            this.btnRemoveVariant.Click += new System.EventHandler(this.btnRemoveVariant_Click);
            // 
            // btnAddVariant
            // 
            this.btnAddVariant.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVariant.Location = new System.Drawing.Point(11, 493);
            this.btnAddVariant.Name = "btnAddVariant";
            this.btnAddVariant.Size = new System.Drawing.Size(80, 44);
            this.btnAddVariant.TabIndex = 25;
            this.btnAddVariant.Text = "+";
            this.btnAddVariant.UseVisualStyleBackColor = true;
            this.btnAddVariant.Click += new System.EventHandler(this.btnAddVariant_Click);
            // 
            // btnCloneVariant
            // 
            this.btnCloneVariant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloneVariant.Location = new System.Drawing.Point(11, 449);
            this.btnCloneVariant.Name = "btnCloneVariant";
            this.btnCloneVariant.Size = new System.Drawing.Size(161, 38);
            this.btnCloneVariant.TabIndex = 27;
            this.btnCloneVariant.Text = "Clone selected";
            this.btnCloneVariant.UseVisualStyleBackColor = true;
            this.btnCloneVariant.Click += new System.EventHandler(this.btnCloneVariant_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // ComponentManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 546);
            this.Controls.Add(this.btnCloneVariant);
            this.Controls.Add(this.btnRemoveVariant);
            this.Controls.Add(this.btnAddVariant);
            this.Controls.Add(this.lbComponentVariants);
            this.Controls.Add(this.btnEastToSouth);
            this.Controls.Add(this.btnSouthToEast);
            this.Controls.Add(this.btnWestToNorth);
            this.Controls.Add(this.btnNorthToWest);
            this.Controls.Add(this.btnWestEdit);
            this.Controls.Add(this.btnSouthEdit);
            this.Controls.Add(this.btnEastEdit);
            this.Controls.Add(this.btnNorthEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbWestIsometric);
            this.Controls.Add(this.pbWest2D);
            this.Controls.Add(this.pbEastIsometric);
            this.Controls.Add(this.pbEast2D);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbSouthIsometric);
            this.Controls.Add(this.pbSouth2D);
            this.Controls.Add(this.pbNorthIsometric);
            this.Controls.Add(this.lblComponentName);
            this.Controls.Add(this.pbNorth2D);
            this.Controls.Add(this.btnRemoveComponent);
            this.Controls.Add(this.btnAddComponent);
            this.Controls.Add(this.lbComponents);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComponentManagerForm";
            this.Text = "ComponentManagerForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComponentManagerForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbNorth2D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNorthIsometric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSouthIsometric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSouth2D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWestIsometric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWest2D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEastIsometric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEast2D)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbComponents;
        private System.Windows.Forms.Button btnAddComponent;
        private System.Windows.Forms.Button btnRemoveComponent;
        private System.Windows.Forms.PictureBox pbNorth2D;
        private System.Windows.Forms.Label lblComponentName;
        private System.Windows.Forms.PictureBox pbNorthIsometric;
        private System.Windows.Forms.PictureBox pbSouthIsometric;
        private System.Windows.Forms.PictureBox pbSouth2D;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbWestIsometric;
        private System.Windows.Forms.PictureBox pbWest2D;
        private System.Windows.Forms.PictureBox pbEastIsometric;
        private System.Windows.Forms.PictureBox pbEast2D;
        private System.Windows.Forms.Button btnNorthEdit;
        private System.Windows.Forms.Button btnEastEdit;
        private System.Windows.Forms.Button btnSouthEdit;
        private System.Windows.Forms.Button btnWestEdit;
        private System.Windows.Forms.Button btnNorthToWest;
        private System.Windows.Forms.Button btnWestToNorth;
        private System.Windows.Forms.Button btnEastToSouth;
        private System.Windows.Forms.Button btnSouthToEast;
        private System.Windows.Forms.ListBox lbComponentVariants;
        private System.Windows.Forms.Button btnRemoveVariant;
        private System.Windows.Forms.Button btnAddVariant;
        private System.Windows.Forms.Button btnCloneVariant;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}