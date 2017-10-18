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
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbNorth2D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNorthIsometric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSouthIsometric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSouth2D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWestIsometric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWest2D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEastIsometric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEast2D)).BeginInit();
            this.SuspendLayout();
            // 
            // lbComponents
            // 
            this.lbComponents.FormattingEnabled = true;
            this.lbComponents.Location = new System.Drawing.Point(13, 13);
            this.lbComponents.Name = "lbComponents";
            this.lbComponents.Size = new System.Drawing.Size(161, 459);
            this.lbComponents.TabIndex = 0;
            // 
            // btnAddComponent
            // 
            this.btnAddComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComponent.Location = new System.Drawing.Point(13, 478);
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
            this.btnRemoveComponent.Location = new System.Drawing.Point(93, 478);
            this.btnRemoveComponent.Name = "btnRemoveComponent";
            this.btnRemoveComponent.Size = new System.Drawing.Size(81, 44);
            this.btnRemoveComponent.TabIndex = 2;
            this.btnRemoveComponent.Text = "-";
            this.btnRemoveComponent.UseVisualStyleBackColor = true;
            this.btnRemoveComponent.Click += new System.EventHandler(this.btnRemoveComponent_Click);
            // 
            // pbNorth2D
            // 
            this.pbNorth2D.Location = new System.Drawing.Point(180, 70);
            this.pbNorth2D.Name = "pbNorth2D";
            this.pbNorth2D.Size = new System.Drawing.Size(200, 200);
            this.pbNorth2D.TabIndex = 3;
            this.pbNorth2D.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "No component selected";
            // 
            // pbNorthIsometric
            // 
            this.pbNorthIsometric.Location = new System.Drawing.Point(386, 70);
            this.pbNorthIsometric.Name = "pbNorthIsometric";
            this.pbNorthIsometric.Size = new System.Drawing.Size(200, 200);
            this.pbNorthIsometric.TabIndex = 5;
            this.pbNorthIsometric.TabStop = false;
            // 
            // pbSouthIsometric
            // 
            this.pbSouthIsometric.Location = new System.Drawing.Point(386, 322);
            this.pbSouthIsometric.Name = "pbSouthIsometric";
            this.pbSouthIsometric.Size = new System.Drawing.Size(200, 200);
            this.pbSouthIsometric.TabIndex = 7;
            this.pbSouthIsometric.TabStop = false;
            // 
            // pbSouth2D
            // 
            this.pbSouth2D.Location = new System.Drawing.Point(180, 322);
            this.pbSouth2D.Name = "pbSouth2D";
            this.pbSouth2D.Size = new System.Drawing.Size(200, 200);
            this.pbSouth2D.TabIndex = 6;
            this.pbSouth2D.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "North";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "South";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(609, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "West";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(609, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "East";
            // 
            // pbWestIsometric
            // 
            this.pbWestIsometric.Location = new System.Drawing.Point(818, 322);
            this.pbWestIsometric.Name = "pbWestIsometric";
            this.pbWestIsometric.Size = new System.Drawing.Size(200, 200);
            this.pbWestIsometric.TabIndex = 13;
            this.pbWestIsometric.TabStop = false;
            // 
            // pbWest2D
            // 
            this.pbWest2D.Location = new System.Drawing.Point(612, 322);
            this.pbWest2D.Name = "pbWest2D";
            this.pbWest2D.Size = new System.Drawing.Size(200, 200);
            this.pbWest2D.TabIndex = 12;
            this.pbWest2D.TabStop = false;
            // 
            // pbEastIsometric
            // 
            this.pbEastIsometric.Location = new System.Drawing.Point(818, 70);
            this.pbEastIsometric.Name = "pbEastIsometric";
            this.pbEastIsometric.Size = new System.Drawing.Size(200, 200);
            this.pbEastIsometric.TabIndex = 11;
            this.pbEastIsometric.TabStop = false;
            // 
            // pbEast2D
            // 
            this.pbEast2D.Location = new System.Drawing.Point(612, 70);
            this.pbEast2D.Name = "pbEast2D";
            this.pbEast2D.Size = new System.Drawing.Size(200, 200);
            this.pbEast2D.TabIndex = 10;
            this.pbEast2D.TabStop = false;
            // 
            // btnNorthEdit
            // 
            this.btnNorthEdit.Location = new System.Drawing.Point(511, 49);
            this.btnNorthEdit.Name = "btnNorthEdit";
            this.btnNorthEdit.Size = new System.Drawing.Size(75, 23);
            this.btnNorthEdit.TabIndex = 16;
            this.btnNorthEdit.Text = "Edit";
            this.btnNorthEdit.UseVisualStyleBackColor = true;
            // 
            // btnEastEdit
            // 
            this.btnEastEdit.Location = new System.Drawing.Point(943, 48);
            this.btnEastEdit.Name = "btnEastEdit";
            this.btnEastEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEastEdit.TabIndex = 17;
            this.btnEastEdit.Text = "Edit";
            this.btnEastEdit.UseVisualStyleBackColor = true;
            // 
            // btnSouthEdit
            // 
            this.btnSouthEdit.Location = new System.Drawing.Point(511, 300);
            this.btnSouthEdit.Name = "btnSouthEdit";
            this.btnSouthEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSouthEdit.TabIndex = 18;
            this.btnSouthEdit.Text = "Edit";
            this.btnSouthEdit.UseVisualStyleBackColor = true;
            // 
            // btnWestEdit
            // 
            this.btnWestEdit.Location = new System.Drawing.Point(943, 301);
            this.btnWestEdit.Name = "btnWestEdit";
            this.btnWestEdit.Size = new System.Drawing.Size(75, 23);
            this.btnWestEdit.TabIndex = 19;
            this.btnWestEdit.Text = "Edit";
            this.btnWestEdit.UseVisualStyleBackColor = true;
            // 
            // ComponentManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 534);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbNorth2D);
            this.Controls.Add(this.btnRemoveComponent);
            this.Controls.Add(this.btnAddComponent);
            this.Controls.Add(this.lbComponents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComponentManagerForm";
            this.Text = "ComponentManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbNorth2D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNorthIsometric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSouthIsometric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSouth2D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWestIsometric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWest2D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEastIsometric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEast2D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbComponents;
        private System.Windows.Forms.Button btnAddComponent;
        private System.Windows.Forms.Button btnRemoveComponent;
        private System.Windows.Forms.PictureBox pbNorth2D;
        private System.Windows.Forms.Label label1;
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
    }
}