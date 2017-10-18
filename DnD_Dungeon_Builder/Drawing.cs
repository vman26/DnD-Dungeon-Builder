using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Dungeon_Builder
{
    public enum Position
    {
        North,
        East,
        South,
        West,
        NotSet
    }

    public class Drawing
    {
        public Bitmap TwoDView { get; private set; }
        public Bitmap ThreeDView { get; private set; }
        public Position Position { get; private set; }

        public Drawing(Bitmap twoDView, Bitmap threeDView, Position position = Position.NotSet)
        {
            TwoDView = twoDView;
            ThreeDView = threeDView;
            Position = position;
        }

        public void SetPosition(Position position)
        {
            Position = position;
        }
    }
}
