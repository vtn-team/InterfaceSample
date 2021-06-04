using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldObject : MonoBehaviour, ISave
{
    [SerializeField] string _prefabName = "";

    public virtual void Save(SaveData.ObjectData data)
    {
        data.PrefabName = _prefabName;
        data.Position = this.transform.position;
    }

    public virtual void Load(SaveData.ObjectData data)
    {
        this.transform.position = data.Position;
    }
}
