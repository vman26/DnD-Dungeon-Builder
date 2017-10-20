using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DnD_Dungeon_Builder
{
    public class Component
    {
        public string Name { get; private set; }
        public BindingList<ComponentVariant> Components { get; private set; }

        public Component(string name)
        {
            Name = name;
            Components = new BindingList<ComponentVariant>();
        }

        public bool AddComponent(string name, Drawing[] drawing = null)
        {
            if (Components.Any(c => c.Name == name))
                return false;

            Components.Add(new ComponentVariant(name, drawing));
            return true;
        }

        public void ChangeDrawing(ComponentVariant componentVariant, Drawing drawing)
        {
            componentVariant.AddDrawing(drawing);
        }

        public ComponentVariant GetComponent(string name)
        {
            foreach (ComponentVariant cv in Components)
            {
                if (name == cv.Name)
                {
                    return cv;
                }
            }
            return null;
        }

        public Drawing GetDrawing(ComponentVariant componentVariant, Position position)
        {
            return componentVariant.GetDrawing(position);
        }

        public bool RemoveComponent(ComponentVariant component)
        {
            if (Components.Remove(component))
            {
                return true;
            }
            return false;
        }
    }
}
