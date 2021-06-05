using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : FieldObject
{
    public override void Save(SaveData.ObjectData data)
    {
        base.Save(data);
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
