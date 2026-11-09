using System;
using System.Collections.Generic;

namespace Q27_LRUCache
{
    class LRUCache
    {
        int capacity;
        Dictionary<int, int> values = new Dictionary<int, int>();                       // key -> value
        Dictionary<int, LinkedListNode<int>> nodes = new Dictionary<int, LinkedListNode<int>>(); // key -> its place in the list
        LinkedList<int> order = new LinkedList<int>();                                  // keys, most recent at the front

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
        }

        public int Get(int key)
        {
            if (!values.ContainsKey(key)) return -1;
            MoveToFront(key);                     // it was just used
            return values[key];
        }

        public void Put(int key, int value)
        {
            if (values.ContainsKey(key))
            {
                values[key] = value;              // update and mark as used
                MoveToFront(key);
                return;
            }
            if (values.Count == capacity)         // full: remove the least recently used (back of the list)
            {
                int lru = order.Last.Value;
                order.RemoveLast();
                values.Remove(lru);
                nodes.Remove(lru);
                Console.WriteLine("  evicted key " + lru);
            }
            values[key] = value;
            nodes[key] = order.AddFirst(key);
        }

        void MoveToFront(int key)
        {
            order.Remove(nodes[key]);             // O(1) because we already have the node
            nodes[key] = order.AddFirst(key);
        }
    }

    class Program
    {
        static void Main()
        {
            LRUCache cache = new LRUCache(2);
            Console.WriteLine("Capacity = 2");
            Console.WriteLine("Put(1, 1)"); cache.Put(1, 1);
            Console.WriteLine("Put(2, 2)"); cache.Put(2, 2);
            Console.WriteLine("Get(1) = " + cache.Get(1));
            Console.WriteLine("Put(3, 3)"); cache.Put(3, 3);
            Console.WriteLine("Get(2) = " + cache.Get(2));
            Console.WriteLine("Put(4, 4)"); cache.Put(4, 4);
            Console.WriteLine("Get(1) = " + cache.Get(1));
            Console.WriteLine("Get(3) = " + cache.Get(3));
            Console.WriteLine("Get(4) = " + cache.Get(4));
        }
    }
}
