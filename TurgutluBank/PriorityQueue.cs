using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurgutluBank
{
    public class PriorityQueue : IQueue
    {
        private object[] Queue;
        private int front = -1;
        
        private int size = 0;
        private int count = 0;

        public PriorityQueue(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object o)
        {
            if (count == size)
            {
                throw new Exception("Queue is full");
            }

            if (isEmpty())
            {
                front++;
                Queue[front] = o;
                count++;
            }
            else
            {
                int i;
                for (i = count - 1; i >= 0; i--)
                {
                    Customer c = (Customer)o;
                    Customer cs = (Customer)Queue[i];

                    if (c.taskTime > cs.taskTime)
                        Queue[i + 1] = Queue[i];
                    else
                        break;
                }
                Queue[i + 1] = o;
                front++;
                count++;
            }
        }

        public object Remove()
        {
            if (this.isEmpty())
            {
                throw new Exception("Queue is empty...");
            }
            object temp = Queue[front];
            Queue[front] = null;
            front--;
            count--;
            return temp;
        }

        public object Peek()
        {
            return Queue[front];
        }

        public bool isEmpty()
        {
            return (count == 0);
        }
    }
}
