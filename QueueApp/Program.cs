using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> aQueue = new Queue<int>();
            aQueue.Enqueue(100);
            aQueue.Enqueue(200);
            aQueue.Enqueue(150);

            foreach (var queueValue in aQueue)
            {
                Console.WriteLine(queueValue);
            }
            //Console.WriteLine(aQueue.Dequeue());
            //Console.WriteLine(aQueue.Dequeue());
            //Console.WriteLine(aQueue.Dequeue());


            Console.WriteLine("Queue Count: " +aQueue.Count);
            Console.ReadKey();

        }
    }
}
