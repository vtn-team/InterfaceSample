using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Parent
{
    /*
    public override void Load(SaveData.ObjectData data)
    {
        this.transform.position = data.Position;
    }

    public override void Save(SaveData.ObjectData data)
    {
        data.PrefabName = this.name.Replace("(Clone)", "");
        data.Position = this.transform.position;
    }
    */

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.gameObject);
            Destroy(this);
        }
    }
    
}
