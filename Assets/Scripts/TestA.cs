using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestA : MonoBehaviour
{
    public virtual void Save(SaveData.ObjectData data)
    {
        data.PrefabName = "Player";
        data.Position = this.transform.position;
    }

    public virtual void Load(SaveData.ObjectData data)
    {
        this.transform.position = data.Position;
    }
}
