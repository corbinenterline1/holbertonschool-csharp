using System;

/// <summary>
/// Custom Object class.
/// </summary>
class Obj
{
    /// <summary>
    /// Method that prints the names of the available properties and methods of an object, format shown in example.
    /// </summary>
    public static void Print(object myObj)
    {
        Console.WriteLine("{0} Properties:", myObj.GetType().Name);
        foreach(var iprop in myObj.GetType().GetProperties())
        {
            Console.WriteLine(iprop.Name);
        }
        Console.WriteLine("{0} Methods:", myObj.GetType().Name);
        foreach(var imeth in myObj.GetType().GetMethods())
        {
            Console.WriteLine(imeth.Name);
        }
    }
}
