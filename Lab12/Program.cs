using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> intQueue = new Queue<int>(5);
        intQueue.Enqueue(1);
        intQueue.Enqueue(2);
        intQueue.Enqueue(3);

        Console.WriteLine("Integer Queue:");
        while (intQueue.Count > 0)
        {
            Console.WriteLine(intQueue.Dequeue());
        }

        Queue<string> stringQueue = new Queue<string>(3);
        stringQueue.Enqueue("first");
        stringQueue.Enqueue("second");
        stringQueue.Enqueue("third");

        Console.WriteLine("\nString Queue:");
        while (stringQueue.Count > 0)
        {
            Console.WriteLine(stringQueue.Dequeue());
        }
    }
}


