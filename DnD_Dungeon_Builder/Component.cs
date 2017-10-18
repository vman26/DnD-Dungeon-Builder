using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Dungeon_Builder
{
    public class Component
    {
        public string Name { get; private set; }
        public Drawing[] Drawings { get; private set; }

        public Component(string name)
        {
            Name = name;
            Drawings = new Drawing[4] { null, null, null, null };
        }

        public void AddDrawing(Drawing drawing)
        {
            if (drawing == null) throw new ArgumentNullException("The drawing cannot be null.");

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

        public Drawing GetDrawing(Position position)
        {
            Drawing drawing = null;
            switch (drawing.Position)
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
