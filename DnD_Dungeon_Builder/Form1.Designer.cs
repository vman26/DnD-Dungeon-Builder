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
            this.lblVariantSelected = new System.Windows.Forms.Label();
            this.lblComponentSelected = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNoneComponent = new System.Windows.Forms.Button();
            this.cbVariants = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbComponents = new System.Windows.Forms.ComboBox();
            this.btnComponentManager = new System.Windows.Forms.Button();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.btnAddColumnAndRow = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.btnClearMap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nupTileSize = new System.Windows.Forms.NumericUpDown();
            this.btnNewMap = new System.Windows.Forms.Button();
            this.cdBackgroud = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPb)).BeginInit();
            this.isometricPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isometricPb)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTileSize)).BeginInit();
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
            this.controlPanel.Controls.Add(this.button1);
            this.controlPanel.Controls.Add(this.lblVariantSelected);
            this.controlPanel.Controls.Add(this.lblComponentSelected);
            this.controlPanel.Controls.Add(this.label3);
            this.controlPanel.Controls.Add(this.btnNoneComponent);
            this.controlPanel.Controls.Add(this.cbVariants);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.cbComponents);
            this.controlPanel.Controls.Add(this.btnComponentManager);
            this.controlPanel.Controls.Add(this.btnBackgroundColor);
            this.controlPanel.Controls.Add(this.btnAddColumnAndRow);
            this.controlPanel.Controls.Add(this.btnAddRow);
            this.controlPanel.Controls.Add(this.btnAddColumn);
            this.controlPanel.Controls.Add(this.btnClearMap);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.nupTileSize);
            this.controlPanel.Controls.Add(this.btnNewMap);
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1264, 75);
            this.controlPanel.TabIndex = 2;
            // 
            // lblVariantSelected
            // 
            this.lblVariantSelected.AutoSize = true;
            this.lblVariantSelected.Location = new System.Drawing.Point(824, 51);
            this.lblVariantSelected.Name = "lblVariantSelected";
            this.lblVariantSelected.Size = new System.Drawing.Size(33, 13);
            this.lblVariantSelected.TabIndex = 18;
            this.lblVariantSelected.Text = "None";
            // 
            // lblComponentSelected
            // 
            this.lblComponentSelected.AutoSize = true;
            this.lblComponentSelected.Location = new System.Drawing.Point(824, 26);
            this.lblComponentSelected.Name = "lblComponentSelected";
            this.lblComponentSelected.Size = new System.Drawing.Size(33, 13);
            this.lblComponentSelected.TabIndex = 17;
            this.lblComponentSelected.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(824, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Current component selected tile:";
            // 
            // btnNoneComponent
            // 
            this.btnNoneComponent.Location = new System.Drawing.Point(769, 23);
            this.btnNoneComponent.Name = "btnNoneComponent";
            this.btnNoneComponent.Size = new System.Drawing.Size(49, 46);
            this.btnNoneComponent.TabIndex = 15;
            this.btnNoneComponent.Text = "None";
            this.btnNoneComponent.UseVisualStyleBackColor = true;
            this.btnNoneComponent.Click += new System.EventHandler(this.btnNoneComponent_Click);
            // 
            // cbVariants
            // 
            this.cbVariants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVariants.FormattingEnabled = true;
            this.cbVariants.Location = new System.Drawing.Point(641, 48);
            this.cbVariants.Name = "cbVariants";
            this.cbVariants.Size = new System.Drawing.Size(121, 21);
            this.cbVariants.TabIndex = 14;
            this.cbVariants.SelectedIndexChanged += new System.EventHandler(this.cbVariants_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Components:";
            // 
            // cbComponents
            // 
            this.cbComponents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComponents.FormattingEnabled = true;
            this.cbComponents.Location = new System.Drawing.Point(641, 23);
            this.cbComponents.Name = "cbComponents";
            this.cbComponents.Size = new System.Drawing.Size(121, 21);
            this.cbComponents.TabIndex = 12;
            this.cbComponents.SelectedIndexChanged += new System.EventHandler(this.cbComponents_SelectedIndexChanged);
            // 
            // btnComponentManager
            // 
            this.btnComponentManager.Location = new System.Drawing.Point(505, 7);
            this.btnComponentManager.Name = "btnComponentManager";
            this.btnComponentManager.Size = new System.Drawing.Size(127, 62);
            this.btnComponentManager.TabIndex = 11;
            this.btnComponentManager.Text = "Component manager";
            this.btnComponentManager.UseVisualStyleBackColor = true;
            this.btnComponentManager.Click += new System.EventHandler(this.btnComponentManager_Click);
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Location = new System.Drawing.Point(373, 7);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(127, 62);
            this.btnBackgroundColor.TabIndex = 10;
            this.btnBackgroundColor.Text = "Pick background color";
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // btnAddColumnAndRow
            // 
            this.btnAddColumnAndRow.Location = new System.Drawing.Point(297, 33);
            this.btnAddColumnAndRow.Name = "btnAddColumnAndRow";
            this.btnAddColumnAndRow.Size = new System.Drawing.Size(70, 36);
            this.btnAddColumnAndRow.TabIndex = 9;
            this.btnAddColumnAndRow.Text = "Add both";
            this.btnAddColumnAndRow.UseVisualStyleBackColor = true;
            this.btnAddColumnAndRow.Click += new System.EventHandler(this.btnAddColumnAndRow_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(221, 33);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(70, 36);
            this.btnAddRow.TabIndex = 8;
            this.btnAddRow.Text = "Add row";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(145, 33);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(70, 36);
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
            this.label2.Location = new System.Drawing.Point(142, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tile size:";
            // 
            // nupTileSize
            // 
            this.nupTileSize.Location = new System.Drawing.Point(196, 7);
            this.nupTileSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nupTileSize.Name = "nupTileSize";
            this.nupTileSize.Size = new System.Drawing.Size(171, 20);
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
            this.btnNewMap.Location = new System.Drawing.Point(12, 7);
            this.btnNewMap.Name = "btnNewMap";
            this.btnNewMap.Size = new System.Drawing.Size(127, 62);
            this.btnNewMap.TabIndex = 3;
            this.btnNewMap.Text = "Create new map";
            this.btnNewMap.UseVisualStyleBackColor = true;
            this.btnNewMap.Click += new System.EventHandler(this.btnNewMap_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1001, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.Panel isometricPanel;
        private System.Windows.Forms.PictureBox gridPb;
        private System.Windows.Forms.PictureBox isometricPb;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button btnNewMap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupTileSize;
        private System.Windows.Forms.Button btnClearMap;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.Button btnAddColumnAndRow;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.ColorDialog cdBackgroud;
        private System.Windows.Forms.Button btnComponentManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbComponents;
        private System.Windows.Forms.ComboBox cbVariants;
        private System.Windows.Forms.Button btnNoneComponent;
        private System.Windows.Forms.Label lblVariantSelected;
        private System.Windows.Forms.Label lblComponentSelected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

