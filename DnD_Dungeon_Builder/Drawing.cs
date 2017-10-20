using System;
using System.Drawing;

namespace DnD_Dungeon_Builder
{
    [Serializable]
    public class Drawing
    {
        public Bitmap TwoDView { get; private set; }
        public Bitmap ThreeDView { get; private set; }
        public Position Position { get; private set; }

        public Drawing(Bitmap twoDView = null, Bitmap threeDView = null, Position position = Position.NotSet)
        {
            TwoDView = twoDView;
            ThreeDView = threeDView;
            Position = position;
        }

        public Drawing Clone()
        {
            return new Drawing((Bitmap)TwoDView?.Clone(), (Bitmap)ThreeDView?.Clone(), Position);
        }

        public void SetPosition(Position position)
        {
            Position = position;
        }
    }
}
