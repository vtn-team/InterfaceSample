using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : TestA, ISave 
{

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
    public override void Save(SaveData.ObjectData data)
    {
        data.PrefabName = "Enemy";
        data.Position = this.transform.position;
    }
}
