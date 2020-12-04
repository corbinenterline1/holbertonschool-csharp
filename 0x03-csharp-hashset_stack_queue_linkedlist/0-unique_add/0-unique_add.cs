using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int total = 0;
        HashSet<int> hash_it_out = new HashSet<int>(myList);
        foreach (int i in hash_it_out)
            total += i;
        return total;
    }
}