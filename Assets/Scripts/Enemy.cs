using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : FieldObject
{
    public override void Save(SaveData.ObjectData data)
    {
        base.Save(data);
    }

    public override void Load(SaveData.ObjectData data)
    {
        base.Load(data);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
