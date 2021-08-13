using System;
using System.Collections;

///<summary>User class that inherits from BaseClass.</summary>
public class User : BaseClass
{
    ///<summary>JSON serialization object type.</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public new string type {get; set;} = "User";
    ///<summary>Name of user.</summary>
    public string name { get; set; }
    ///<summary>User constructor.</summary>
    public User(string name)
    {
        this.name = name;
    }
    /// <summary> String override </summary>
    public override string ToString() 
    {
        this.type = null;
        var res = JsonSerializer.Serialize(this);
        this.type = "User";
        return(res);
    }
}