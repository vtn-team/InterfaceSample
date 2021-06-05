using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : FieldObject
{
    public override void Save(SaveData.ObjectData data)
    {
        // ここに新しい要素を書く
    }

    public override void Load(SaveData.ObjectData data)
    {
        // ここに新しい要素を書く
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
