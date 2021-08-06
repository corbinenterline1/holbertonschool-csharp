using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

///<summary>JSON storage.</summary>
public class JSONStorage
{
    ///<summary>Dictionary where keys are <ClassName>.<id> and values are the objects.</summary>
    public Dictionary<string, dynamic> objects { get; set; } = new Dictionary<string, dynamic>();

    ///<summary>Returns all inventory objects.</summary>
    public Dictionary<string, dynamic> All()
    {
        return (objects);
    }
    ///<summary>Adds object to objects.</summary>
    public void New(BaseClass obj)
    {
        string key;
        if (obj == NULL)
            return;
        key = String.Format("{0}.{1}", obj.GetType(), obj.id);
        this.objects.Add(key, obj);
    }
    ///<summary>Saves objects to file.</summary>
    public void Save()
    {
        string jString = JsonSerializer.Serialize(this.objects);
        File.WriteAllText("storage/inventory_manager.json", jString);
    }
    ///<summary>Loads the saved objects saved via serialization.</summary>
    public void Load()
    {
        Dictionary<string, dynamic> loader = new Dictionary<string, dynamic>();
        if (Directory.Exists("storage") && File.Exists("storage/inventory_manager.json"))
        {
            loader = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(File.ReadAllText("storage/inventory_manager.json"));
            this.objects = loader;
        }
    }
}