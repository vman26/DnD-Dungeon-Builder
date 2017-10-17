using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Dungeon_Builder
{
    class ComponentManager
    {
        // Delegate type for the event handler
        public delegate void OnChangeEventHandler();

        // Declare the event.
        public event OnChangeEventHandler OnChangeEvent;

        public List<Component> Components { get; private set; }

        public ComponentManager()
        {
            Components = new List<Component>();
        }

        public bool AddNewComponent(string name)
        {
            if (Components.Any(c => c.Name == name))
                return false;

            Components.Add(new Component(name));

            if (OnChangeEvent != null)
                OnChangeEvent();

            return true;
        }

        public bool RemoveComponent(Component component)
        {
            if(Components.Remove(component))
            {
                if (OnChangeEvent != null)
                    OnChangeEvent();
                return true;
            }
            return false;
        }

        public Component GetComponent(string name)
        {
            foreach (Component c in Components)
            {
                if (c.Name == name)
                {
                    return c;
                }
            }
            return null;
        }
    }
}
