using System;
using System.Drawing;

namespace Snake
{
    public class Fruit
    {
        public Fruit()
        {
            Random rand = new Random();
            X = 0;
            Y = 0;
            while (X == 0 && Y == 0)
            {
                X = rand.Next(20);
                Y = rand.Next(20);
            }
        }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw(Graphics buffGraph)
        {
            Image img = Properties.Resources.apple;
            buffGraph.DrawImage(new Bitmap(img, 27, 27), X * Configuration.Scale + 2, Y * Configuration.Scale + 2);
        }
    }
}
