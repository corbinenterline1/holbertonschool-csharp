using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine();
            return;
        }
        int i = array.Length - 1;
        for (; i > 0; i--)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine("{0}", array[i]);
    }
}