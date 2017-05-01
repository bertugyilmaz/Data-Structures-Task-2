using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurgutluBank
{
    public class CircularArrayTypedQueue : IQueue
    {
        private object[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;

        public CircularArrayTypedQueue(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object o)
        {
            if (count == size)
                throw new Exception("Queue dolu.");

            if (front == -1)
                front = 0;

            if (rear == size - 1)
            {
                rear = 0;
                Queue[rear] = o;
            }
            else
                Queue[++rear] = o;

            count++; 
        }

        public bool isEmpty()
        {
            return (count == 0);
        }

        public object Peek()
        {
            return Queue[front];
        }

        public object Remove()
        {
            if (isEmpty())
                throw new Exception("Queue boş.");

            object temp = Queue[front];
            Queue[front] = null;

            if (front == size - 1)
                front = 0;
            else
                front++;

            count--;

            return temp;
        }
    }
}
