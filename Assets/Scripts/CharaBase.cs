using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaBase : MonoBehaviour, ISave
{
    public void Save(SaveData.ObjectData data)
    {
        data.PrefabName = gameObject.name;
        data.Position = this.transform.position;
    }

    public void Load(SaveData.ObjectData data)
    {
        this.transform.position = data.Position;
    }
}
