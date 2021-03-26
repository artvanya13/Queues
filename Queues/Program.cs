using System;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue s = new Queue(5);
            s.AddToQueue("Hashir");
            s.AddToQueue("Michael");
            s.AddToQueue("Inna");
            s.AddToQueue("Vanya");
            s.AddToQueue("Sasha");
            s.RemoveFromQueue();
            s.Print();
        }
    }
}
