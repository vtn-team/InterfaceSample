using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : FieldObject
{
    // Start is called before the first frame update
    public override void Save(SaveData.ObjectData data)
    {
        data.PrefabName = "Enemy";
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
