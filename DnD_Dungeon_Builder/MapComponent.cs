using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Dungeon_Builder
{
    public class MapComponent
    {
        public ComponentVariant Component { get; private set; }
        Position position;

        public MapComponent(ComponentVariant component, Position position = Position.North)
        {
            Component = component;
            this.position = position;
        }

        public void SetPosition(Position position)
        {
            if (position != Position.NotSet)
                this.position = position;
        }

        public void SetComponent(ComponentVariant component)
        {
            if (component!=null)
            {
                Component = component;
            }
        }

        public Drawing GetDrawing()
        {
            return Component?.GetDrawing(position);
        }
    }
}
