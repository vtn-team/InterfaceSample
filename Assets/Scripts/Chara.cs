using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Chara : MonoBehaviour, ISave
{
    public abstract string CharaName { get; }

    public virtual void Save(SaveData.ObjectData data)
    {
        data.PrefabName = CharaName;
        data.Position = this.transform.position;
    }

    public virtual void Load(SaveData.ObjectData data)
    {
        this.transform.position = data.Position;
    }
}
