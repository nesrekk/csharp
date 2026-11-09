using System;

namespace Q20_DetectCycle
{
    class Node
    {
        public int Data;
        public Node Next;
        public Node(int data) { Data = data; }
    }

    class Program
    {
        // Floyd: slow moves 1 step, fast moves 2 steps. If they ever meet, there is a cycle.
        static bool HasCycle(Node head)
        {
            Node slow = head, fast = head;
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (slow == fast) return true;
            }
            return false;     // fast reached the end, so no cycle
        }

        static void Main()
        {
            // List without a cycle: 1 -> 2 -> 3 -> 4 -> null
            Node a = new Node(1);
            a.Next = new Node(2);
            a.Next.Next = new Node(3);
            a.Next.Next.Next = new Node(4);
            Console.WriteLine("List 1 -> 2 -> 3 -> 4 -> null : " + (HasCycle(a) ? "Cycle found" : "No cycle"));

            // List with a cycle: 1 -> 2 -> 3 -> 4 -> back to 2
            Node b = new Node(1);
            b.Next = new Node(2);
            b.Next.Next = new Node(3);
            b.Next.Next.Next = new Node(4);
            b.Next.Next.Next.Next = b.Next;
            Console.WriteLine("List 1 -> 2 -> 3 -> 4 -> back to 2 : " + (HasCycle(b) ? "Cycle found" : "No cycle"));
        }
    }
}
