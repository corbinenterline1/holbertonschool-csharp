﻿using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int max_key = -1;
        string record_keeper = "None";
        foreach(KeyValuePair<string, int> combo in myList)
        {
            if (combo.Value >= max_key)
            {
                max_key = combo.Value;
                record_keeper = combo.Key;
            }
        }
        return record_keeper;
    }
}