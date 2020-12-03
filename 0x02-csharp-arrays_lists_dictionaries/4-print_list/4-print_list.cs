using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else
        {
            List<int> print_list = new List<int>();
            if (size == 0)
                    Console.WriteLine();
            else
            {
                for (int i = 0; i <= size - 1; i++)
                {
                        print_list.Add(i);
                        if (i != size - 1)
                            Console.Write("{0} ", i);
                        else
                            Console.WriteLine("{0}", i);
                }
            }
            return print_list;
        }
    }
}