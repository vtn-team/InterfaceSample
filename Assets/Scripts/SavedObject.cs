using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavedObject : MonoBehaviour, ISave
{
    private string prefabName;

    public virtual void Save(SaveData.ObjectData data)
    {
        data.PrefabName = prefabName;
        data.Position = this.transform.position;
    }

    public virtual void Load(SaveData.ObjectData data)
    {
        this.transform.position = data.Position;
    }

    protected void setPrefabName(string name = null)
    {
        if(name == null || name == "")
        {
            prefabName = this.name.Replace("(Clone)", "");
        }
        else
        {
            prefabName = name;
        }
    }
}
