using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : FieldObject, ISave
{
    public override void Save(SaveData.ObjectData data)
    {
        data.PrefabName = "Enemy";
        data.Position = this.transform.position;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("敵にぶつかった");
            Destroy(this.gameObject);
        }

    }
}