using System;
using Queue.Models;


namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueDT();
            QueueObject();
            QueueGeneric();
        }
        static void QueueDT()
        {
            Console.WriteLine("Homework №13. DateTime queue:");
            CastomQueueDT queue = new CastomQueueDT(10);
            Random gen = new Random();
            DateTime start = new DateTime(1800, 1, 1);
            for (int i = 0; i < 15; i++)
            {
                queue.Enqueue(start.AddDays(gen.Next(80000)));
            }
            for (int i = 0; i < queue.Size; i++)
            {
                start = queue.Dequeue();
                Console.WriteLine(start);
            }
        }
        static void QueueObject()
        {
            Console.WriteLine("Homework №13. Object queue:");
            CastomQueueObject queue = new CastomQueueObject(3);
            object start;
            queue.Enqueue(13);
            queue.Enqueue("Hello");
            queue.Enqueue('h');
            queue.Enqueue(2.34567);
            for (int i = 0; i < queue.Size ; i++)
            {
                start = queue.Dequeue();
                Console.WriteLine(start);
            }
        }
        static void QueueGeneric()
        {
            Console.WriteLine("Homework №13. Generic queue:");
            CastomQueue<Student> queue = new CastomQueue<Student>();
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(new Student());
            }
            Console.WriteLine(queue.Peek());
            for (int i = 0; i < queue.Size; i++)
            {                
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
