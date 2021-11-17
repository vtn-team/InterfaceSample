using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class CalactorBase : MonoBehaviour, ISave
{
    /// <summary>ˆÚ“®</summary>
    protected abstract void Move();

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
