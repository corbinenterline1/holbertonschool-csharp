using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        if (myLList.Count == 0)
        {
            myLList.AddFirst(n);
            return myLList.First;
        }
        var nodey = myLList.First;
        for (; nodey != null; nodey = nodey.Next)
        {
            if (n <= nodey.Value)
            {
                myLList.AddBefore(nodey, n);
                return nodey.Previous;
            }
        }
        return myLList.Last;
    }
}