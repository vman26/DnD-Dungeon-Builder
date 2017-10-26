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
        public Position Position { get; private set; }

        public MapComponent(ComponentVariant component, Position position = Position.North)
        {
            Component = component;
            Position = position;
        }

        public void SetPosition(Position position)
        {
            if (position != Position.NotSet)
                Position = position;
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
            return Component?.GetDrawing(Position);
        }
    }
}
