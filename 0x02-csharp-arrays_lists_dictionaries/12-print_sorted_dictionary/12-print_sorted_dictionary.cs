using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var glory_list = myDict.Keys.ToList();
        glory_list.Sort();
        foreach (var key in glory_list)
            Console.WriteLine("{0}: {1}", key, myDict[key]);
    }
}