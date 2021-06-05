using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : BaseObject
{
    ///課題:Try
    //public override void Save(SaveData.ObjectData data)
    //{
    //    data.PrefabName = "Enemy";
    //    data.Position = this.transform.position;
    //}

    //課題:Must
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
