using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : FieldObject
{
    public override void Save(SaveData.ObjectData data)
    {
        data.PrefabName = "Player";
        data.Position = this.transform.position;
    }

    public override void Load(SaveData.ObjectData data)
    {
        this.transform.position = data.Position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("エンター");
        //破壊可能なら消す
        IDestroy canDestroy = collision.gameObject.GetComponent<IDestroy>();
        if (canDestroy != null)
        {
            canDestroy.Death();
        }
    }
}