using System.Drawing;

namespace DnD_Dungeon_Builder
{
    public enum Position
    {
        North = 0,
        East = 90,
        South = 180,
        West = 270,
        NotSet = -1
    }

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

        public void SetPosition(Position position)
        {
            Position = position;
        }
    }
}
