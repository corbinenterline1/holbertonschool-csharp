using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> ll_cool_j = new LinkedList<int>();
        for (int i = 0; i < size; i++)
        {
            ll_cool_j.AddLast(i);
            Console.WriteLine(ll_cool_j.Last.Value);
        }
        return ll_cool_j;
    }
}