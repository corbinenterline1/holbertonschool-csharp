using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> common_list = new List<int>();
        for (int i = 0; i < list2.Count; i++)
        {
            if (list1.Contains(list2[i]))
                common_list.Add(list2[i]);
        }
        common_list.Sort();
        return common_list;
    }
}