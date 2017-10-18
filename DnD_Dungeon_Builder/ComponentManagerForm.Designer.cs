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
            // ComponentManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 534);
            this.Controls.Add(this.btnRemoveComponent);
            this.Controls.Add(this.btnAddComponent);
            this.Controls.Add(this.lbComponents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComponentManagerForm";
            this.Text = "ComponentManagerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbComponents;
        private System.Windows.Forms.Button btnAddComponent;
        private System.Windows.Forms.Button btnRemoveComponent;
    }
}