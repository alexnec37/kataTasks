using System;
using System.Collections.Generic;
using System.Text;

namespace codewars.Labirint
{
    public class PathFinder3__ЕheAlpinist_3
    {
        public static int PathFinder(string mazePrototip)
        {
            var maze = prepareMaze(mazePrototip);
            int res = WaveLabirint(maze);

            return res;
        }

        static int[][] prepareMaze(string mazePrototip)
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
                    maze[i][j] = getDifficultCell(mazeStrList[i - 1][j - 1]);
                }
            }

            return maze;
        }

        static int getDifficultCell(char cell)
        {
            return cell == 'W' ? 0 : int.Parse(cell.ToString()) + 1;
        }

        public static int WaveLabirint(int[][] maze)
        {
            var queueWays = new Queue<(int, int)>();
            int x = 0, y = 0;
            int n = 0;

            int sizeField = maze.Length - 2;
            int sx = 1, sy = 1, tx = sizeField, ty = sizeField;
            int[,] fillmap = preparePassedWays(maze.Length);

            Action<int, int> proc = (newX, newY) =>
            {
                n = calculateWeightStep(maze[y][x], maze[newY][newX], fillmap[y, x]);
                if (fillmap[newY, newX] <= n) return;

                fillmap[newY, newX] = n;
                queueWays.Enqueue((newX, newY));
            };

            queueWays.Enqueue((sx, sy));
            fillmap[sy, sx] = 0;
            while (queueWays.Count != 0)
            {
                (x , y) = queueWays.Dequeue();

                if (maze[y][x + 1] > 0) proc(y, x + 1);
                if (maze[y][x - 1] > 0) proc(y, x - 1);
                if (maze[y + 1][x] > 0) proc(y + 1, x);
                if (maze[y - 1][x] > 0) proc(y - 1, x);
            }

            if (fillmap[ty, tx] == int.MaxValue)
            {
                return -1;
            }
            else
                return fillmap[ty, tx];
        }

        static int[,] preparePassedWays(int length)
        {
            var fillmap = new int[length, length];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    fillmap[i, j] = int.MaxValue;
                }
            }

            return fillmap;
        }

        static int calculateWeightStep(int currCell, int newCell, int currWeight)
        {
            return currWeight + Math.Abs(currCell - newCell);
        }
    }
}
