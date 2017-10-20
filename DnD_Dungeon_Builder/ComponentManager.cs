using System.ComponentModel;
using System.Linq;

namespace DnD_Dungeon_Builder
{
    public class ComponentManager
    {
        public BindingList<Component> Components { get; private set; }

        public ComponentManager()
        {
            Components = new BindingList<Component>();
        }

        public bool AddNewComponent(string name)
        {
            if (Components.Any(c => c.Name == name))
                return false;

            Components.Add(new Component(name));
            return true;
        }

        public bool RemoveComponent(Component component)
        {
            if(Components.Remove(component))
            {
                return true;
            }
            return false;
        }

        public void LoadComponents(BindingList<Component> components)
        {
            Components.Clear();
            foreach (Component component in components)
            {
                Components.Add(component);
            }
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
