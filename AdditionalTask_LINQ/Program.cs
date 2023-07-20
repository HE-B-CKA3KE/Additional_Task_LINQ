using System;
using System.Collections.Generic;
 class Program
{
    static void Main(string[] args)
    {
        Queue<string> queueNames = new Queue<string>();
        Random random = new Random();
         string[] names = { "Alice", "Bob", "Charlie", "David", "Emma", "Frank", "Grace", "Henry", "Isabella", "John" };
         for (int i = 0; i < 10; i++)
        {
            int randomIndex = random.Next(names.Length);
            queueNames.Enqueue(names[randomIndex]);
        }
         Console.WriteLine("Random Names Queue:");
        foreach (string name in queueNames)
        {
            Console.WriteLine(name);
        }
         Console.ReadLine();
    }
}