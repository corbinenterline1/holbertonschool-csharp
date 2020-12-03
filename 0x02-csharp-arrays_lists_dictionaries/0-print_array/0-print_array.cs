using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else
        {
            int[] new_array = new int[size];
            if (size == 0)
                Console.WriteLine();
            else
            {
                for (int i = 0; i < size; i++)
                {
                    new_array[i] = i;
                    if (i == size - 1)
                        Console.WriteLine("{0}", i);
                    else
                        Console.Write("{0} ", i);
                }
            }
            return new_array;
        }
    }
}