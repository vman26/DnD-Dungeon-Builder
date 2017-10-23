using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Dungeon_Builder
{
    [Serializable]
    public class ComponentVariant
    {
        public string Name { get; private set; }
        public Drawing[] Drawings { get; private set; }
        public Position DrawPosition { get; private set; }
        public Component Parent { get; private set; }

        public ComponentVariant(string name, Component parent, Drawing[] drawing = null)
        {
            Name = name;
            Parent = parent;
            Drawings = new Drawing[4] { null, null, null, null };
            if (drawing != null)
            {
                foreach (Drawing d in drawing)
                {
                    AddDrawing(d?.Clone());
                }
            }
            DrawPosition = Position.North;
        }

        public void RotateDrawPosition(Rotate rotate = Rotate.Clockwise)
        {
            int rotation = (int)DrawPosition;
            rotation += (int)rotate;

            if (rotation > 360)
            {
                rotation -= 360;
            }
            if (rotation < 0)
            {
                rotation += 360;
            }

            DrawPosition = (Position)rotation;
        }

        public void AddDrawing(Drawing drawing)
        {
            if (drawing != null)
            {
                switch (drawing.Position)
                {
                    case Position.North:
                        Drawings[0] = drawing;
                        break;
                    case Position.East:
                        Drawings[1] = drawing;
                        break;
                    case Position.South:
                        Drawings[2] = drawing;
                        break;
                    case Position.West:
                        Drawings[3] = drawing;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Given position does not exist in the Drawing context.");
                }
            }
        }

        public Drawing GetDrawing(Position position)
        {
            Drawing drawing = null;
            switch (position)
            {
                case Position.North:
                    drawing = Drawings[0];
                    break;
                case Position.East:
                    drawing = Drawings[1];
                    break;
                case Position.South:
                    drawing = Drawings[2];
                    break;
                case Position.West:
                    drawing = Drawings[3];
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Given position does not exist in the Drawing context.");
            }
            return drawing;
        }
    }
}
