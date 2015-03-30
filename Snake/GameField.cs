using System.Drawing;

namespace Snake
{
    public class GameField
    {
        private static Image img = Properties.Resources.grass;
        private Bitmap bmp = new Bitmap(img);

        public void Draw(Graphics buffGraph)
        {
            buffGraph.DrawImage(bmp, new Point(0,0));
        }
    }
}
