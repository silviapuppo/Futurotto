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
        public int Dir { get; set; }

        public RobotSimulator(int x, int y, int dir)
        {
            Pos = new Point(x, y);
            Dir = dir;
        }

        public RobotSimulator() : this(0, 0, 0)
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
                        if (Dir == (int)Directions.West)
                        {
                            Dir = (int)Directions.North;
                        }
                        else
                        {
                            Dir++;
                        }
                        break;
                    case 'L':
                        if (Dir == (int)Directions.North)
                        {
                            Dir = (int)Directions.West;
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

        private Point AdvanceRobot(int dir, Point position)
        {
            switch (dir)
            {
                case (int)Directions.North:
                    position.Y++;
                    break;
                case (int)Directions.East:
                    position.X++;
                    break;
                case (int)Directions.South:
                    position.Y--;
                    break;
                case (int)Directions.West:
                    position.X--;
                    break;
            }
            return position;
        }
    }
}
