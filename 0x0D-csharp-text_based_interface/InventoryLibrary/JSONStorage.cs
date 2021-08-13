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
        Dictionary<string, dynamic> temp;
        Dictionary<string, dynamic> loader = new Dictionary<string, dynamic>();
        if (Directory.Exists("storage") && File.Exists("storage/inventory_manager.json"))
        {
            temp = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(File.ReadAllText("storage/inventory_manager.json"));
            var keys = temp.Keys;
            foreach (var key in keys)
                loader.Add(key, deseralizer(temp[key].ToString()));
        }
        this.objects = loader;
    }
    ///<summary>Deserializes based off object types.</summary>
    private dynamic deserializer(string obj)
    {
        Dictionary<string, string> temp = JsonSerializer.Deserialize<Dictionary<string, string>>(obj);
        var keys = temp.Keys;
        if (temp["type"] == "User")
            return (JsonSerializer.Deserialize<User>(obj));
        else if (temp["type"] == "Item")
            return (JsonSerializer.Deserialize<Item>(obj));
        else if (temp["type"] == "Inventory")
            return (JsonSerializer.Deserialize<Inventory>(obj));
        else
            return (JsonSerializer.Deserialize<BaseClass>(obj));
    }
    public bool updateObj<T>(string key, string paramName, dynamic val) {
        var obj = this.objects[key];
        this.objects.Remove(key);
        var jsonString = JsonSerializer.Serialize(obj);
        Dictionary<string, string> objDict = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
        if (objDict.ContainsKey(paramName)) {
            objDict[paramName] = val.ToString();
            jsonString = JsonSerializer.Serialize(objDict);
            obj = JsonSerializer.Deserialize<T>(jsonString);
            New(obj);
            Save();
            return (true);
        }
        else {
            return (false);
        }
    }
}