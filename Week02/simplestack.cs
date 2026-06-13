using System;
public class SimpleStack
{
    public static void Run()
{
        //Stage 1 create an empty stack
        var stack = new Stack<int>();
        //Stage (back to front):[]
        //Stage 2: Push several values onto the stack
        stack.Push(1);
        //Stack: [1] ← back
        stack.Push(2);
        //Stack: [1, 2] ← back  
        stack.Push(3);
        //Stack: [1, 2, 3] ← back  
        stack.Push(4);
        //Stack: [1, 2, 3, 4] ← back
        stack.Push(5);
        //Stack: [1, 2, 3, 4, 5] ← back

        //Stage 3: Pop one value off
        var a = stack.Pop();
        //removed: 5
        //Stack: [1, 2, 3, 4] ← back

        //Stage 4: Pop more values
        stack.Push(6);
        //Stack: [1, 2, 3, 4, 6] ← back

        stack.Push(7);
        //Stack: [1, 2, 3, 4, 6, 7] ← back

        //Stage 5: Pop two values off
        var b = stack.Pop();
        //removed: 7
        //Stack: [1, 2, 3, 4, 6] ← back

        var c = stack.Pop();
        //removed: 6    
        //Stack: [1, 2, 3, 4] ← back    

        //Stage 6: Push one more value
        stack.Push(8);
        //Stack: [1, 2, 3, 4, 8]← back

        //Stage 7: Pop three values off
        var d = stack.Pop();
        //removed: 8    
        //Stack: [1, 2, 3, 4] ← back

        var e = stack.Pop();
        //removed: 4
        //Stack: [1, 2, 3] ← back

        var f = stack.Pop();
        //removed: 3        
        //Stack: [1, 2] ← back  

        //Stage 8: Pop the last two final values 
        stack.Push(9);
        //Stack: [1, 2, 9] ← back

        stack.Push(10);
        //Stack: [1, 2, 9, 10] ← back


    }
}
