using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (myLList.Count == 0)
            return;
        var nodey = myLList.First;
        for (int i = 0; i <= index && nodey != null; i++)
        {
            if (i != index)
            {
                nodey = nodey.Next;
                continue;
            }
            myLList.Remove(nodey);
            return;
        }
    }
}