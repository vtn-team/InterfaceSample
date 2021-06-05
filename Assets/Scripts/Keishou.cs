using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keishou : MonoBehaviour, ISave
{
    public virtual void Save(SaveData.ObjectData data)
    {
        data.PrefabName = "Player";
        data.PrefabName = "Enemy";
        data.Position = this.transform.position;
    }

    public virtual void Load(SaveData.ObjectData data)
    {
        this.transform.position = data.Position;
    }
}
