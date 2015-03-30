using System.Drawing;

namespace Snake
{
    public class SnakeSegment
    {
        public int X { get; set; }
        public int Y { get; set; }

        private static Image _segment = Properties.Resources.segment;
        private static Image _headRight = Properties.Resources.headRight;
        private static Image _headLeft = Properties.Resources.headLeft;
        private static Image _headUp = Properties.Resources.headUp;
        private static Image _headDown = Properties.Resources.headDown;

        private Bitmap _segmentBitmap = new Bitmap(_segment, 30,30);
        private Bitmap _headLeftBitmap = new Bitmap(_headLeft, 30, 30);
        private Bitmap _headRightBitmap = new Bitmap(_headRight, 30, 30);
        private Bitmap _headUpBitmap = new Bitmap(_headUp, 30, 30);
        private Bitmap _headDownBitmap = new Bitmap(_headDown, 30, 30);

        public void Draw(Graphics buffGraph, bool isHead, int direction)
        {
            if (isHead)
            {
                Bitmap head = _segmentBitmap;
                switch (direction)
                {
                    case 3:
                        head = _headLeftBitmap;
                        break;
                    case 0:
                        head = _headUpBitmap;
                        break;
                    case 1:
                        head = _headRightBitmap;
                        break;
                    case 2:
                        head = _headDownBitmap;
                        break;
                }
                buffGraph.DrawImage(head, X * Configuration.Scale + 2, Y * Configuration.Scale + 2);
            }
            else
            {
                buffGraph.DrawImage(_segmentBitmap, X * Configuration.Scale + 2, Y * Configuration.Scale + 2);
            }
        }
    }
}
