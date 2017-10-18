﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Dungeon_Builder
{
    public partial class ComponentManagerForm : Form
    {
        ComponentManager componentManager;

        public ComponentManagerForm(ComponentManager componentManager)
        {
            InitializeComponent();

            this.componentManager = componentManager;

            lbComponents.DataSource = componentManager.Components;
            lbComponents.DisplayMember = "Name";
        }

        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            /*using (ObjectDrawFrom form = new ObjectDrawFrom(componentManager))
            {
                form.Parent = this.Parent;
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }*/
        }

        private void btnRemoveComponent_Click(object sender, EventArgs e)
        {
            if (lbComponents.SelectedItem is Component)
            {
                componentManager.RemoveComponent(lbComponents.SelectedItem as Component);
            }
        }
    }
}