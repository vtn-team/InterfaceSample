using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Parent : MonoBehaviour, ISave
{
    public void Save(SaveData.ObjectData data)
    {
        //data.PrefabName = this.gameObject.name;
        data.PrefabName = this.name.Replace("(Clone)", "");
        data.Position = this.transform.position;
    }

    public void Load(SaveData.ObjectData data)
    {
        this.transform.position = data.Position;
    }
}
