using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        var nodey = myLList.First;
        for (int i = 0; nodey != null; i++, nodey = nodey.Next)
        {
            if (nodey.Value == value)
                return i;
        }
        return -1;
    }
}