using System;
using System.Collections.Generic;
using System.Text;

namespace PathFinder4_WhereAreYou_4_Testn
{
    public struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class PathFinder4_WhereAreYou_4
    {
        // w = 1, n = 2, e = 3, s = 4
        static int dirrection = 1;
        static Point point = new Point(0, 0);
        static int x = 0;
        static int y = 0;

        static int finite_dimensional(int newDirrection)
        {
            return newDirrection % 4 > 0 ? newDirrection % 4 : newDirrection;
        }


        static int r()
        {
            int tempDirrection = dirrection + 1;
            return finite_dimensional(tempDirrection);
        }
        static int l()
        {
            int tempDirrection = dirrection + 3;
            return finite_dimensional(tempDirrection);
        }

        static int RL()
        {
            int tempDirrection = dirrection + 2;
            return finite_dimensional(tempDirrection);
        }

        static void turn_me(char turn)
        {
            switch (turn)
            {
                case 'r':
                    dirrection = r();
                    break;
                case 'l':
                    dirrection = l();
                    break;
                case 'L':
                case 'R':
                    dirrection = RL();
                    break;
            }
        }

        static void take_steps(int steps)
        {
            switch (dirrection)
            {
                case 1:
                    PathFinder4_WhereAreYou_4.x -= steps;
                    break;
                case 2:
                    PathFinder4_WhereAreYou_4.y += steps;
                    break;
                case 3:
                    PathFinder4_WhereAreYou_4.x += steps;
                    break;
                case 4:
                    PathFinder4_WhereAreYou_4.y -= steps;
                    break;
            }
        }

        public static Point iAmHere(string path)
        {
            string buf = string.Empty;

            foreach (char partAction in path)
            {
                if (char.IsDigit(partAction))
                {
                    buf += partAction;
                    continue;
                }

                if (!string.IsNullOrEmpty(buf))
                {
                    int steps = Convert.ToInt32(buf);
                    buf = string.Empty;
                    take_steps(steps);
                }

                turn_me(partAction);
            }

            if (!string.IsNullOrEmpty(buf))
            {
                int steps = Convert.ToInt32(buf);
                take_steps(steps);
            }

            return new Point(x, y);
        }
    }
}
