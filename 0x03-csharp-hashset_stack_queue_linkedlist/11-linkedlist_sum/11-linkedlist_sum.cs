using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int total = 0;
        var nodey = myLList.First;
        for (; nodey != null; nodey = nodey.Next)
            total += nodey.Value;
        return total;
    }
}