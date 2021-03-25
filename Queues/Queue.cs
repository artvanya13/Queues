using System;
using System.Collections.Generic;
using System.Text;

namespace Queues
{
    class Queue
    {
        public int front = 0;
        public int end = 0;
        public int[] array;

        public Queue (int size)
        {
            array = new int[5];
        }


        public bool AddToQueue(int item)
        {
            bool CheckFull = true;
            if (end != front && end != 0)
            {
                array[end] = item;
                end = (end + 1) % array.Length;
                CheckFull = false;
            }
            return CheckFull;
        }

        public int RemoveFromQueue(int item)
        {
            int k = 0;
            for (int i = 0; i < array.Length; i ++)
            {
                if (i == item)
                    k = i; 
            }
            return array[k];
            front ++;
        }

        public void Print (int [] array)
        {
            for (int i = 0; i < array.Length; i ++)
            {
                Console.WriteLine(array[i]);

            }
        }
    }
}
