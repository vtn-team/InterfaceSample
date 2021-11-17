using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Charactor
{
    public override void Save(SaveData.ObjectData data)
    {
        data.PrefabName = "Enemy";
        base.Save(data);
    }
    public override void Load(SaveData.ObjectData data)
    {
        base.Load(data);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
