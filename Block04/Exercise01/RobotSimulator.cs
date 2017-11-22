using System;

namespace Exercise01
{
    public enum Directions
    {
        North, East, South, West
    }

    public class Point
    {
        private int x;
        private int y;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point() : this(0, 0)
        {

        }
    }

    public class RobotSimulator
    {
        private Point pos;
        private int dir;

        public Point Pos
        {
            get
            {
                return pos;
            }
            set
            {
                pos = value;
            }
        }

        public int Dir
        {
            get
            {
                return dir;
            }
            set
            {
                dir = value;
            }
        }

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
