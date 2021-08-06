using System;

///<summary>Base Class.</summary>
public class BaseClass
{
    ///<summary>ID of Inventory object.</summary>
    public string id { get; set; }
    ///<sumamry>Time and date of object creation.</summary>
    public DateTime date_created { get; set; }
    ///<summary>Time and date that object was updated.</summary>
    public DateTime date_updated { get; set; }

    ///<summary>Base Class constructor.</summary>
    public BaseClass()
    {
        this.id = System.Guid.NewGuid().ToString();
        this.date_created = DateTime.Now;
        this.date_updated = DateTime.Now;
    }
}