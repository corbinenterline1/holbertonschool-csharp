using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);
        if (aStack.Count == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine("Top item: {0}", aStack.Peek());
        bool forgot_about_bool = aStack.Contains(search);
        Console.WriteLine("Stack contains {0}: {1}", search, forgot_about_bool);
        while(aStack.Contains(search))
        {
            aStack.Pop();
        }
        aStack.Push(newItem);
        return aStack;
    }
}