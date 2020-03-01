using System;
using System.Collections.Generic;
using System.Text;

namespace codewars.Labirint
{
    public class PathFinder3__ЕheAlpinist_3
    {
        public static int PathFinder(string mazePrototip)
        {
            var mazeStrList = mazePrototip.Split("\n");
            int sizeRow = mazeStrList[0].Length + 2;
            int[][] maze = new int[mazeStrList.Length + 2][];

            maze[0] = new int[sizeRow];
            maze[mazeStrList.Length + 1] = new int[sizeRow];

            for (int i = 1; i <= mazeStrList.Length; i++)
            {
                maze[i] = new int[sizeRow];
                for (int j = 1; j <= sizeRow - 2; j++)
                {
                    maze[i][j] = mazeStrList[i - 1][j - 1] == 'W' ? 0 : int.Parse(mazeStrList[i - 1][j - 1].ToString()) + 1;
                }
            }

            int res = WaveLabirint(maze);

            return res;
        }

        struct Сoordinates
        {
            public int x;
            public int y;
        }

        static Сoordinates[] buf = new Сoordinates[2560];
        static int bufp, bufe;
        static (int, int)[,] fillmap;

        public static int WaveLabirint(int[][] maze)
        {
            int x = 0, y = 0;

            (int, int) n = (0, 0);

            int sizeField = maze.Length - 2;
            int sx = 1, sy = 1, tx = sizeField, ty = sizeField;
            bufp = 0; bufe = 0;
            fillmap = new (int, int)[maze.Length, maze.Length];

            for (int i = 0; i < maze.Length; i++)
            {
                for (int j = 0; j < maze.Length; j++)
                {
                    fillmap[i, j].Item1 = 255;
                    fillmap[i, j].Item2 = 0;
                }
            }

            push(sx, sy, n);
            while (pop(ref x, ref y) > 0)
            {
                if ((x == tx) && (y == ty))
                {
                    break;
                }

                if (maze[y][x + 1] > 0)
                {
                    n.Item2 = maze[y][x + 1] > maze[y][x] || maze[y][x + 1] < maze[y][x] ? fillmap[y, x].Item2 + Math.Abs(maze[y][x + 1] - maze[y][x]) : fillmap[y, x].Item2;
                    n.Item1 = fillmap[y, x].Item1 + n.Item2;
                    push(x + 1, y, n);
                }
                if (maze[y][x - 1] > 0)
                {
                    n.Item2 = maze[y][x - 1] > maze[y][x] || maze[y][x - 1] < maze[y][x] ? fillmap[y, x].Item2 + Math.Abs(maze[y][x - 1] - maze[y][x]) : fillmap[y, x].Item2;
                    n.Item1 = fillmap[y, x].Item1 + n.Item2;
                    push(x - 1, y, n);
                }
                if (maze[y + 1][x] > 0)
                {
                    n.Item2 = maze[y + 1][x] > maze[y][x] || maze[y + 1][x] < maze[y][x] ? fillmap[y, x].Item2 + Math.Abs(maze[y + 1][x] - maze[y][x]) : fillmap[y, x].Item2;
                    n.Item1 = fillmap[y, x].Item1 + n.Item2;
                    push(x, y + 1, n);
                }
                if (maze[y - 1][x] > 0)
                {
                    n.Item2 = maze[y - 1][x] > maze[y][x] || maze[y - 1][x] < maze[y][x] ? fillmap[y, x].Item2 + Math.Abs(maze[y - 1][x] - maze[y][x]) : fillmap[y, x].Item2;
                    n.Item1 = fillmap[y, x].Item1 + n.Item2;
                    push(x, y - 1, n);
                }
            }

            if (fillmap[ty, tx].Item1 == 255)
            {
                return -1;
            }
            else
                return fillmap[y, x].Item2;
        }

        static void push(int x, int y, (int, int) n)
        {
            if (fillmap[y, x].Item1 <= n.Item1) return; // Если новый путь не коpоче-нафиг его

            fillmap[y, x].Item1 = n.Item1;
            fillmap[y, x].Item2 = n.Item2;
            buf[bufe].x = x;
            buf[bufe].y = y;

            bufe++;
        }

        static int pop(ref int x, ref int y)
        {
            if (bufp == bufe) return 0;

            x = buf[bufp].x;
            y = buf[bufp].y;

            bufp++;

            return 1;
        }
    }
}
