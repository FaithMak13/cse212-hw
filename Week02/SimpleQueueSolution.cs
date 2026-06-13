using System;
using System.Collections.Generic;
public class SimpleQueueSolution
{
    public static void Run()
    {
        //Stage 1: Create an empty queue
        var queue = new Queue<int>();
        //Stage 2: Enqueue several values
        queue.Enqueue(1);
        //Queue: [1] ← front
        queue.Enqueue(2);
        //Queue: [1, 2] ← front
        queue.Enqueue(3);
        //Queue: [1, 2, 3] ← front
        queue.Enqueue(4);
        //Queue: [1, 2, 3, 4] ← front
        queue.Enqueue(5);
        //Queue: [1, 2, 3, 4, 5] ← front

        //Stage 3: Dequeue one value
        var a = queue.Dequeue();
        //removed: 1
        //Queue: [2, 3, 4, 5] ← front

        //Stage 4: Dequeue more values
        queue.Enqueue(6);
        //Queue: [2, 3, 4, 5, 6] ← front

        queue.Enqueue(7);
        //Queue: [2, 3, 4, 5, 6, 7] ← front

        //Stage 5: Dequeue two values
        var b = queue.Dequeue();
        //removed: 2
        //Queue: [3, 4, 5, 6, 7] ← front

        var c = queue.Dequeue();
        //removed: 3    
        //Queue: [4, 5, 6, 7] ← front

        //Stage 6: Enqueue one more value
        queue.Enqueue(8);   
        //Queue: [4, 5, 6, 7, 8] ← front

        //Stage 7: Dequeue three values
        var d = queue.Dequeue();
        //removed: 4
        //Queue: [5, 6, 7, 8] ← front

        var e = queue.Dequeue();
        //removed: 5
        //Queue: [6, 7, 8] ← front
        var f = queue.Dequeue();        
        //removed: 6
        //Queue: [7, 8] ← front     

        //Stage 8: Dequeue the last two final values
        var g = queue.Dequeue();    
        //removed: 7                        

        // avoid unused variable warnings
        Console.WriteLine($"Dequeued values: {a}, {b}, {c}, {d}, {e}, {f}, {g}");
    }
}