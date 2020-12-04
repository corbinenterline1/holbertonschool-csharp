using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        var nodey = myLList.First;
        for (int i = 0; i < myLList.Count && nodey != null; i++, nodey = nodey.Next)
        {
            if (i == n)
                return nodey.Value;
        }
        return 0;
    }
}