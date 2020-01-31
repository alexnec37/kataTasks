using System;
using System.Collections.Generic;
using System.Text;

namespace SortBinaryTreeByLevels_4
{
    public class Node
    {
        public Node Left;
        public Node Right;
        public int Value;

        public Node(Node l, Node r, int v)
        {
            Left = l;
            Right = r;
            Value = v;
        }
    }

    public class Kata
    {
        public static List<int> TreeByLevels(Node node)
        {
            var res = Across(node);
            return res;
        }

        private static List<int> Across(Node node)
        {
            var res = new List<int>();
            var queue = new Queue<Node>();
            
            if (node != null) queue.Enqueue(node);
            while (queue.Count != 0)
            {
                var x = queue.Dequeue();
                res.Add(x.Value);

                if (x.Left != null)
                {
                    queue.Enqueue(x.Left);
                }
                if (x.Right != null)
                {
                    queue.Enqueue(x.Right);
                }
            }

            return res;
        }

    }
}
