using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : FieldObject, ISave
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
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("HIT");
            Destroy(this.gameObject);
        }
    }


}
