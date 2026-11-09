using System;

namespace Q28_ValidateBST
{
    class Node
    {
        public int Val;
        public Node Left, Right;
        public Node(int val) { Val = val; }
    }

    class Program
    {
        // Every node must be bigger than min and smaller than max
        static bool IsBST(Node node, long min, long max)
        {
            if (node == null) return true;
            if (node.Val <= min || node.Val >= max) return false;
            return IsBST(node.Left, min, node.Val) && IsBST(node.Right, node.Val, max);
        }

        static void Main()
        {
            //        5
            //      /   \
            //     3     8
            //    / \   / \
            //   2   4 7   9
            Node t1 = new Node(5);
            t1.Left = new Node(3);
            t1.Right = new Node(8);
            t1.Left.Left = new Node(2);
            t1.Left.Right = new Node(4);
            t1.Right.Left = new Node(7);
            t1.Right.Right = new Node(9);
            Console.WriteLine("Tree 1: " + (IsBST(t1, long.MinValue, long.MaxValue) ? "Valid BST" : "Not a valid BST"));

            //        5
            //      /   \
            //     1     4      <- 4 is on the right of 5 but smaller than 5
            //          / \
            //         3   6
            Node t2 = new Node(5);
            t2.Left = new Node(1);
            t2.Right = new Node(4);
            t2.Right.Left = new Node(3);
            t2.Right.Right = new Node(6);
            Console.WriteLine("Tree 2: " + (IsBST(t2, long.MinValue, long.MaxValue) ? "Valid BST" : "Not a valid BST"));
        }
    }
}
