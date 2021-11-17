using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara : MonoBehaviour, ISave
{
    private string m_myName = "Sample";

    public virtual void Load(SaveData.ObjectData data)
    {
        data.PrefabName = MyName;
        data.Position = this.transform.position;
    }

    public virtual void Save(SaveData.ObjectData data)
    {
        this.transform.position = data.Position;
    }

    public string MyName
    {
        get => m_myName;
        set
        {
            value = m_myName;
        }
    }
}
