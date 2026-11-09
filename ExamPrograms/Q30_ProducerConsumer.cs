using System;
using System.Collections.Concurrent;
using System.Threading;

namespace Q30_ProducerConsumer
{
    class Program
    {
        static void Main()
        {
            // A thread-safe queue that holds at most 3 items
            BlockingCollection<int> queue = new BlockingCollection<int>(3);

            Thread producer = new Thread(() =>
            {
                for (int i = 1; i <= 8; i++)
                {
                    Console.WriteLine("Produced " + i);
                    queue.Add(i);              // waits if the queue is full
                    Thread.Sleep(30);
                }
                queue.CompleteAdding();        // no more items are coming
                Console.WriteLine("Producer finished");
            });

            Thread consumer = new Thread(() =>
            {
                int sum = 0;
                foreach (int item in queue.GetConsumingEnumerable())   // waits if the queue is empty
                {
                    Console.WriteLine("        Consumed " + item);
                    sum += item;
                    Thread.Sleep(80);
                }
                Console.WriteLine("Consumer finished, sum of items = " + sum);
            });

            producer.Start();
            consumer.Start();
            producer.Join();                   // wait for both threads to finish
            consumer.Join();
        }
    }
}
