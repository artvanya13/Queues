using System;
using System.Collections.Generic;
using System.Text;

namespace Queues
{
    class Queue
    {
        public int front = 0;
        public int end = 0;
        private int[] array;

        public Queue (int size)
        {
            array = new int[5];
        }


        public void AddToQueue(int item)
        {
            array[end] = item;
            end = (end + 1) % array.Length;
        }

        public int RemoveFromQueue(int item)
        {
            int k;
            for (int i = 0; i < array.Length; i ++)
            {
                if (i == item)
                    k = i; 
            }
            return array[k];
            front++;
        }
    }
}
