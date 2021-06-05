using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBase : MonoBehaviour,ISave
{
    string prefabName = "none";

    public virtual void SetName(string pName)
    {
        prefabName = pName;
    }

    public virtual void Save(SaveData.ObjectData data)
    {
        data.PrefabName = prefabName;
        data.Position = this.transform.position;
    }

    public virtual void Load(SaveData.ObjectData data)
    {
        this.transform.position = data.Position;
    }
}
