using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Queue q = new Queue(2);
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            Console.WriteLine("The first element: " + q.First() + "\n");
            q.Dequeue();
            Console.WriteLine("The first element: " + q.First()+"\n");
            */

            //StackLinked List
            /*
            StackLinkedList sl = new StackLinkedList();
            sl.Push(3);
            sl.Push(6);

            Console.WriteLine(sl.Top());
            sl.Pop();
            Console.WriteLine(sl.Top());
            */

            QueueLinkedList ql = new QueueLinkedList();
            ql.Enqueue(1);
            ql.Enqueue(3);

            Console.WriteLine(ql.First());
            ql.Dequeue();
            Console.WriteLine(ql.First());

        }
    }
}
