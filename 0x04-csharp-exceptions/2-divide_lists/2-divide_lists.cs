using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> results_list = new List<int>();
        int c = 0;
        for (int i = 0; i < listLength; i++, c = 0)
        {
            try
            {
                c = list1[i] / list2[i];
                results_list.Add(c);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                results_list.Add(c);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        return results_list;
    }
}