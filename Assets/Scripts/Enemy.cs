using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : CalactorBase
{
    protected override void Move()
    {
        throw new System.NotImplementedException();
    }

    public override void Save(SaveData.ObjectData data)
    {
        data.PrefabName = "Enemy";
        data.Position = this.transform.position;
    }

    public override void Load(SaveData.ObjectData data)
    {
        this.transform.position = data.Position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
