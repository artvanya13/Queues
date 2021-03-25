using System;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue s = new Queue(5);
            s.AddToQueue("Vanya");
            s.Print();
        }
    }
}
