using System;
using System.Collections.Generic;
using System.Text;

namespace Queues
{
    class Queue
    {
        private string[] Queues;
        private bool CheckFull;

        private int front;
        private int back;
        public Queue(int x)
        {
            Queues = new string[x];
            front = 0;
            back = 0;
            CheckFull = false;
        }


        public bool AddToQueue(string item)
        {
            bool finished = true;
            if (CheckFull == false)
            {
                Queues[back] = item;
                back = (back + 1) % Queues.Length;
                if (front == back)
                {
                    finished = false;
                    CheckFull = true;
                }
            }
            return finished;
        }

        public string RemoveFromQueue()
        {
            string element = "";
            if (CheckFull == false && front == back)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                element = Queues[front];
                front = (front + 1) % Queues.Length;
            }
            return element;
        }

        public void Print ()
        {
            int i = front;
            do
            {
                Console.WriteLine(Queues[i]);
                i = (i + 1) % Queues.Length;
            }
            while (i != back);
        }
    }
}
