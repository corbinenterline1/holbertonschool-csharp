using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> two_dic = new Dictionary<string, int> ();
        foreach(KeyValuePair<string, int> combo in myDict)
            two_dic[combo.Key] = combo.Value * 2;
        return two_dic;
    }
}