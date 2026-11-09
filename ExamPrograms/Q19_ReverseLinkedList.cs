using System;

namespace Q19_ReverseLinkedList
{
    class Node
    {
        public int Data;
        public Node Next;
        public Node(int data) { Data = data; }
    }

    class Program
    {
        // Walk the list once and turn every Next pointer around
        static Node Reverse(Node head)
        {
            Node prev = null, current = head;
            while (current != null)
            {
                Node next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }

        static void Print(Node head)
        {
            for (Node n = head; n != null; n = n.Next)
                Console.Write(n.Data + (n.Next != null ? " -> " : " -> null\n"));
        }

        static void Main()
        {
            Console.Write("Enter list values separated by spaces: ");
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Node head = null, tail = null;
            foreach (string p in parts)
            {
                Node node = new Node(int.Parse(p));
                if (head == null) head = tail = node;
                else { tail.Next = node; tail = node; }
            }

            Console.Write("Original: ");
            Print(head);
            head = Reverse(head);
            Console.Write("Reversed: ");
            Print(head);
        }
    }
}
