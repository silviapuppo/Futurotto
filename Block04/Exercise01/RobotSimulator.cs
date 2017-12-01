using System;

namespace Exercise01
{
    public enum Directions
    {
        North, East, South, West
    }

    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

    }

    public class RobotSimulator
    {
        public Point Pos { get; set; }
        public Directions Dir { get; set; }

        public RobotSimulator(Point pos, Directions dir)
        {
            Pos = pos;
            Dir = dir;
        }

        public RobotSimulator() : this(new Point(0,0), Directions.North)
        {
        }

        public void MoveRobot(string moves)
        {
            moves = moves.ToUpper();

            foreach (char c in moves)
            {
                switch (c)
                {
                    case 'R':
                        if (Dir == Directions.West)
                        {
                            Dir = Directions.North;
                        }
                        else
                        {
                            Dir++;
                        }
                        break;
                    case 'L':
                        if (Dir == Directions.North)
                        {
                            Dir = Directions.West;
                        }
                        else
                        {
                            Dir--;
                        }
                        break;
                    case 'A':
                        Pos = AdvanceRobot(Dir, Pos);
                        break;
                }
            }
        }

        private Point AdvanceRobot(Directions dir, Point position)
        {
            switch (dir)
            {
                case Directions.North:
                    position.Y++;
                    break;
                case Directions.East:
                    position.X++;
                    break;
                case Directions.South:
                    position.Y--;
                    break;
                case Directions.West:
                    position.X--;
                    break;
            }
            return position;
        }
    }
}
