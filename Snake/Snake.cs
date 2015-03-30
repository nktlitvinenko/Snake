using System.Collections.Generic;
using System.Drawing;

namespace Snake
{
    public class Snake
    {
        public Snake()
        {
            Segments = new List<SnakeSegment>();
            Segments.Add(new SnakeSegment(){X = 10, Y =10});
            Direction = 0;
        }
        public List<SnakeSegment> Segments { get; set; }
        public int Direction { get; set; }

        public void EatFruit()
        {
            Segments.Add(new SnakeSegment());
        }
        public void Draw(Graphics buffGraph)
        {
            Segments[0].Draw(buffGraph, true, Direction);
            for (int i = 1; i < Segments.Count; i++)
            {
                Segments[i].Draw(buffGraph, false, Direction);
            }
        }

        public void Move()
        {
            int x = Segments[0].X;
            int y = Segments[0].Y;

            switch (Direction)
            {
                case 0:
                    y--;
                    break;
                case 1:
                    x++;
                    break;
                case 2:
                    y++;
                    break;
                case 3:
                    x--;
                    break;
                default:
                    break;
            }
            for (int i = Segments.Count - 1; i > 0; i--)
            {
                Segments[i].X = Segments[i - 1].X;
                Segments[i].Y = Segments[i - 1].Y;
            }
            Segments[0].X = x;
            Segments[0].Y = y;
        }
    }
}
